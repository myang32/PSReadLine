/********************************************************************++
Copyright (c) Microsoft Corporation.  All rights reserved.
--********************************************************************/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.PowerShell.Internal;

namespace Microsoft.PowerShell
{
    /// <summary>
    /// A helper class for converting strings to ConsoleKey chords.
    /// </summary>
    public static class ConsoleKeyChordConverter
    {
        /// <summary>
        /// Converts a string to a sequence of ConsoleKeyInfo.
        /// Sequences are separated by ','.  Modifiers
        /// appear before the modified key and are separated by '+'.
        /// Examples:
        ///     Ctrl+X
        ///     Ctrl+D,M
        ///     Escape,X
        /// </summary>
        public static ConsoleKeyInfo[] Convert(string chord)
        {
            if (string.IsNullOrEmpty(chord))
            {
                throw new ArgumentNullException("chord");
            }

            var result = ConvertChord(chord).ToArray();

            if (result.Length > 2)
            {
                throw new ArgumentException(PSReadLineResources.ChordWithTooManyKeys);
            }

            return result;
        }

        /// <summary>
        /// Custom StartsWith that supports a start index to search from
        /// and ignores case in the user supplied string but assumes lower
        /// case in our provided we're looking for.
        /// </summary>
        private static bool StartsWith(string str, string with, int startIndex)
        {
            if (str.Length - startIndex - with.Length < 0)
                return false;

            var j = 0;
            var i = startIndex;
            while (j < with.Length)
            {
                if (char.ToLowerInvariant(str[i++]) != with[j++])
                {
                    return false;
                }
            }
            return j == with.Length;
        }

        private static IEnumerable<ConsoleKeyInfo> ConvertChord(string chord)
        {
            var expectingAnotherKey = false;
            var control = false;
            var alt = false;
            var shift = false;
            for (int i = 0; i < chord.Length; i++)
            {
                var c = chord[i];
                if (c == 'c' || c == 'C')
                {
                    // Possibly Control/Ctrl
                    if (StartsWith(chord, "control+", i))
                    {
                        control = true;
                        i += 7;
                        continue;
                    }
                    if (StartsWith(chord, "ctrl+", i))
                    {
                        control = true;
                        i += 4;
                        continue;
                    }
                }
                else if (c == 'a' || c == 'A')
                {
                    // Possibly Alt
                    if (StartsWith(chord, "alt+", i))
                    {
                        alt = true;
                        i += 3;
                        continue;
                    }
                }
                else if (c == 's' || c == 'S')
                {
                    // Possibly Shift
                    if (StartsWith(chord, "shift+", i))
                    {
                        shift = true;
                        i += 5;
                        continue;
                    }
                }

                // We frequently expect a single character (even if we're expecting
                // multiple keys in the chord), so check for that first.
                if (i == chord.Length || (i + 1 < chord.Length && chord[i + 1] == ','))
                {
                    // We map Ctrl+(a-z) to the actual control code
                    if (c >= 'a' && c <= 'z' && control && !alt && !shift)
                    {
                        c = (char)(c - 'a' + 1);
                    }
                    yield return new ConsoleKeyInfo(c, 0, shift, alt, control);

                    if (i != chord.Length)
                    {
                        expectingAnotherKey = true;
                    }
                    continue;
                }

                // Multiple characters for our modified key, we need to figure out which key this is.
                var commaIndex = chord.IndexOf(',');
                var tokenLength = commaIndex == -1 ? chord.Length - i : commaIndex - i;
                var token = chord.Substring(i, tokenLength);
                i += tokenLength;
                expectingAnotherKey = commaIndex != -1;

                ConsoleKey key;
                if (!Enum.TryParse(token, ignoreCase: true, result: out key))
                {
                    throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, PSReadLineResources.InvalidSequence, chord));
                }

                var keyChar = '\0';
                switch (key)
                {
                    case ConsoleKey.Backspace:
                        keyChar = '\b';
                        break;
                    case ConsoleKey.Tab:
                        keyChar = '\t';
                        break;
                    case ConsoleKey.Enter:
                        keyChar = '\n';
                        break;
                    case ConsoleKey.Escape:
                        keyChar = (char)0x1B;
                        break;
                    case ConsoleKey.Delete:
                        keyChar = (char)0x7F;
                        break;
                    case ConsoleKey.Spacebar:
                        keyChar = ' ';
                        break;
                }

                if (keyChar != '\0')
                    key = 0;

                yield return new ConsoleKeyInfo(keyChar, key, shift, alt, control);
                shift = false;
                alt = false;
                control = false;
            }

            if (control || shift || alt || expectingAnotherKey)
            {
                // If we get here, we had a modifier but no key
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, PSReadLineResources.InvalidSequence, chord));
            }
        }

        internal static char GetCharFromConsoleKey(ConsoleKey key, ConsoleModifiers modifiers)
        {
            // default for unprintables and unhandled
            char keyChar = '\u0000';

            // emulate GetKeyboardState bitmap - set high order bit for relevant modifier virtual keys
            var state = new byte[256];
            state[NativeMethods.VK_SHIFT] = (byte)(((modifiers & ConsoleModifiers.Shift) != 0) ? 0x80 : 0);
            state[NativeMethods.VK_CONTROL] = (byte)(((modifiers & ConsoleModifiers.Control) != 0) ? 0x80 : 0);
            state[NativeMethods.VK_ALT] = (byte)(((modifiers & ConsoleModifiers.Alt) != 0) ? 0x80 : 0);

            // a ConsoleKey enum's value is a virtual key code
            uint virtualKey = (uint)key;

            // get corresponding scan code
            uint scanCode = NativeMethods.MapVirtualKey(virtualKey, NativeMethods.MAPVK_VK_TO_VSC);

            // get corresponding character  - may be 0, 1 or 2 in length (diacritics)
            var chars = new char[2];
            int charCount = NativeMethods.ToUnicode(
                virtualKey, scanCode, state, chars, chars.Length, NativeMethods.MENU_IS_INACTIVE);

            // TODO: support diacritics (charCount == 2)
            if (charCount == 1)
            {
                keyChar = chars[0];
            }
            return keyChar;
        }
    }
}
