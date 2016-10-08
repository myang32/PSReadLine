/********************************************************************++
Copyright (c) Microsoft Corporation.  All rights reserved.
--********************************************************************/

using System;

namespace Microsoft.PowerShell
{
    internal static class Keys
    {
        private static ConsoleKeyInfo Key(char c)
        {
            return new ConsoleKeyInfo(c, 0, false, false, false);
        }

        private static ConsoleKeyInfo Key(int mods, char c)
        {
            return new ConsoleKeyInfo(c, 0, (mods & Shift) != 0, (mods & Alt) != 0, (mods & Control) != 0);
        }

        private static ConsoleKeyInfo Key(ConsoleKey c)
        {
            return new ConsoleKeyInfo((char)0, c, false, false, false);
        }

        private static ConsoleKeyInfo Key(int mods, ConsoleKey c)
        {
            return new ConsoleKeyInfo((char)0, c, (mods & Shift) != 0, (mods & Alt) != 0, (mods & Control) != 0);
        }

        const int Control = 0x1;
        const int Alt = 0x2;
        const int Shift = 0x4;

        public static ConsoleKeyInfo A                     = Key('a');
        public static ConsoleKeyInfo B                     = Key('b');
        public static ConsoleKeyInfo C                     = Key('c');
        public static ConsoleKeyInfo D                     = Key('d');
        public static ConsoleKeyInfo E                     = Key('e');
        public static ConsoleKeyInfo F                     = Key('f');
        public static ConsoleKeyInfo G                     = Key('g');
        public static ConsoleKeyInfo H                     = Key('h');
        public static ConsoleKeyInfo I                     = Key('i');
        public static ConsoleKeyInfo J                     = Key('j');
        public static ConsoleKeyInfo K                     = Key('k');
        public static ConsoleKeyInfo L                     = Key('l');
        public static ConsoleKeyInfo M                     = Key('m');
        public static ConsoleKeyInfo N                     = Key('n');
        public static ConsoleKeyInfo O                     = Key('o');
        public static ConsoleKeyInfo P                     = Key('p');
        public static ConsoleKeyInfo Q                     = Key('q');
        public static ConsoleKeyInfo R                     = Key('r');
        public static ConsoleKeyInfo S                     = Key('s');
        public static ConsoleKeyInfo T                     = Key('t');
        public static ConsoleKeyInfo U                     = Key('u');
        public static ConsoleKeyInfo V                     = Key('v');
        public static ConsoleKeyInfo W                     = Key('w');
        public static ConsoleKeyInfo X                     = Key('x');
        public static ConsoleKeyInfo Y                     = Key('y');
        public static ConsoleKeyInfo Z                     = Key('z');
        public static ConsoleKeyInfo ucA                   = Key('A');
        public static ConsoleKeyInfo ucB                   = Key('B');
        public static ConsoleKeyInfo ucC                   = Key('C');
        public static ConsoleKeyInfo ucD                   = Key('D');
        public static ConsoleKeyInfo ucE                   = Key('E');
        public static ConsoleKeyInfo ucF                   = Key('F');
        public static ConsoleKeyInfo ucG                   = Key('G');
        public static ConsoleKeyInfo ucH                   = Key('H');
        public static ConsoleKeyInfo ucI                   = Key('I');
        public static ConsoleKeyInfo ucJ                   = Key('J');
        public static ConsoleKeyInfo ucK                   = Key('K');
        public static ConsoleKeyInfo ucL                   = Key('L');
        public static ConsoleKeyInfo ucM                   = Key('M');
        public static ConsoleKeyInfo ucN                   = Key('N');
        public static ConsoleKeyInfo ucO                   = Key('O');
        public static ConsoleKeyInfo ucP                   = Key('P');
        public static ConsoleKeyInfo ucQ                   = Key('Q');
        public static ConsoleKeyInfo ucR                   = Key('R');
        public static ConsoleKeyInfo ucS                   = Key('S');
        public static ConsoleKeyInfo ucT                   = Key('T');
        public static ConsoleKeyInfo ucU                   = Key('U');
        public static ConsoleKeyInfo ucV                   = Key('V');
        public static ConsoleKeyInfo ucW                   = Key('W');
        public static ConsoleKeyInfo ucX                   = Key('X');
        public static ConsoleKeyInfo ucY                   = Key('Y');
        public static ConsoleKeyInfo ucZ                   = Key('Z');

        public static ConsoleKeyInfo _0                    = Key('0');
        public static ConsoleKeyInfo _1                    = Key('1');
        public static ConsoleKeyInfo _2                    = Key('2');
        public static ConsoleKeyInfo _3                    = Key('3');
        public static ConsoleKeyInfo _4                    = Key('4');
        public static ConsoleKeyInfo _5                    = Key('5');
        public static ConsoleKeyInfo _6                    = Key('6');
        public static ConsoleKeyInfo _7                    = Key('7');
        public static ConsoleKeyInfo _8                    = Key('8');
        public static ConsoleKeyInfo _9                    = Key('9');

        public static ConsoleKeyInfo RParen                = Key(')');
        public static ConsoleKeyInfo Bang                  = Key('!');
        public static ConsoleKeyInfo At                    = Key('@');
        public static ConsoleKeyInfo Pound                 = Key('#');
        public static ConsoleKeyInfo Dollar                = Key('$');
        public static ConsoleKeyInfo Percent               = Key('%');
        public static ConsoleKeyInfo Uphat                 = Key('^');
        public static ConsoleKeyInfo Ampersand             = Key('&');
        public static ConsoleKeyInfo Star                  = Key('*');
        public static ConsoleKeyInfo LParen                = Key('(');

        public static ConsoleKeyInfo Colon                 = Key(':');
        public static ConsoleKeyInfo Semicolon             = Key(';');
        public static ConsoleKeyInfo Question              = Key('?');
        public static ConsoleKeyInfo Slash                 = Key('/');
        public static ConsoleKeyInfo Tilde                 = Key('~');
        public static ConsoleKeyInfo Backtick              = Key('`');
        public static ConsoleKeyInfo LCurly                = Key('{');
        public static ConsoleKeyInfo LBracket              = Key('[');
        public static ConsoleKeyInfo Pipe                  = Key('|');
        public static ConsoleKeyInfo Backslash             = Key('\\');
        public static ConsoleKeyInfo RCurly                = Key('}');
        public static ConsoleKeyInfo RBracket              = Key(']');
        public static ConsoleKeyInfo SQuote                = Key('\'');
        public static ConsoleKeyInfo DQuote                = Key('"');
        public static ConsoleKeyInfo LessThan              = Key('<');
        public static ConsoleKeyInfo Comma                 = Key(',');
        public static ConsoleKeyInfo GreaterThan           = Key('>');
        public static ConsoleKeyInfo Period                = Key('.');
        public static ConsoleKeyInfo Underbar              = Key('_');
        public static ConsoleKeyInfo Minus                 = Key('-');
        public static ConsoleKeyInfo AltMinus              = Key(Alt, '-');
        public static ConsoleKeyInfo Plus                  = Key('+');
        new
        public static ConsoleKeyInfo Equals                = Key('=');

        public static ConsoleKeyInfo CtrlAt                = Key(Shift | Control, ConsoleKey.D2);
        public static ConsoleKeyInfo AltUnderbar           = Key(Alt, '_');
        public static ConsoleKeyInfo CtrlUnderbar          = Key(Control, (char)31);
        public static ConsoleKeyInfo AltEquals             = Key(Alt, '=');
        public static ConsoleKeyInfo Space                 = Key(' ');
        // Useless because it's caught by the console to bring up the system menu.
        public static ConsoleKeyInfo AltSpace              = Key(Alt, ' ');
        public static ConsoleKeyInfo CtrlSpace             = Key(Control, ' ');
        public static ConsoleKeyInfo AltLess               = Key(Alt, '<');
        public static ConsoleKeyInfo AltGreater            = Key(Alt, '>');
        public static ConsoleKeyInfo CtrlRBracket          = Key(Control, (char)29);
        public static ConsoleKeyInfo AltCtrlRBracket       = Key(Alt | Control, ConsoleKey.Oem6);
        public static ConsoleKeyInfo AltPeriod             = Key(Alt, '.');
        public static ConsoleKeyInfo CtrlAltQuestion       = Key(Shift | Alt | Control, ConsoleKey.Oem2);
        public static ConsoleKeyInfo AltQuestion           = Key(Alt, '?');

        public static ConsoleKeyInfo Alt0                  = Key(Alt, '0');
        public static ConsoleKeyInfo Alt1                  = Key(Alt, '1');
        public static ConsoleKeyInfo Alt2                  = Key(Alt, '2');
        public static ConsoleKeyInfo Alt3                  = Key(Alt, '3');
        public static ConsoleKeyInfo Alt4                  = Key(Alt, '4');
        public static ConsoleKeyInfo Alt5                  = Key(Alt, '5');
        public static ConsoleKeyInfo Alt6                  = Key(Alt, '6');
        public static ConsoleKeyInfo Alt7                  = Key(Alt, '7');
        public static ConsoleKeyInfo Alt8                  = Key(Alt, '8');
        public static ConsoleKeyInfo Alt9                  = Key(Alt, '9');

        public static ConsoleKeyInfo AltA                  = Key(Alt, 'a');
        public static ConsoleKeyInfo AltB                  = Key(Alt, 'b');
        public static ConsoleKeyInfo AltC                  = Key(Alt, 'c');
        public static ConsoleKeyInfo AltD                  = Key(Alt, 'd');
        public static ConsoleKeyInfo AltE                  = Key(Alt, 'e');
        public static ConsoleKeyInfo AltF                  = Key(Alt, 'f');
        public static ConsoleKeyInfo AltG                  = Key(Alt, 'g');
        public static ConsoleKeyInfo AltH                  = Key(Alt, 'h');
        public static ConsoleKeyInfo AltI                  = Key(Alt, 'i');
        public static ConsoleKeyInfo AltJ                  = Key(Alt, 'j');
        public static ConsoleKeyInfo AltK                  = Key(Alt, 'k');
        public static ConsoleKeyInfo AltL                  = Key(Alt, 'l');
        public static ConsoleKeyInfo AltM                  = Key(Alt, 'm');
        public static ConsoleKeyInfo AltN                  = Key(Alt, 'n');
        public static ConsoleKeyInfo AltO                  = Key(Alt, 'o');
        public static ConsoleKeyInfo AltP                  = Key(Alt, 'p');
        public static ConsoleKeyInfo AltQ                  = Key(Alt, 'q');
        public static ConsoleKeyInfo AltR                  = Key(Alt, 'r');
        public static ConsoleKeyInfo AltS                  = Key(Alt, 's');
        public static ConsoleKeyInfo AltT                  = Key(Alt, 't');
        public static ConsoleKeyInfo AltU                  = Key(Alt, 'u');
        public static ConsoleKeyInfo AltV                  = Key(Alt, 'v');
        public static ConsoleKeyInfo AltW                  = Key(Alt, 'w');
        public static ConsoleKeyInfo AltX                  = Key(Alt, 'x');
        public static ConsoleKeyInfo AltY                  = Key(Alt, 'y');
        public static ConsoleKeyInfo AltZ                  = Key(Alt, 'z');

        public static ConsoleKeyInfo CtrlA                 = Key(Control, (char)1);
        public static ConsoleKeyInfo CtrlB                 = Key(Control, (char)2);
        public static ConsoleKeyInfo CtrlC                 = Key(Control, (char)3);
        public static ConsoleKeyInfo CtrlD                 = Key(Control, (char)4);
        public static ConsoleKeyInfo CtrlE                 = Key(Control, (char)5);
        public static ConsoleKeyInfo CtrlF                 = Key(Control, (char)6);
        public static ConsoleKeyInfo CtrlG                 = Key(Control, (char)7);
        public static ConsoleKeyInfo CtrlH                 = Key(Control, (char)8);
        public static ConsoleKeyInfo CtrlI                 = Key(Control, (char)9);
        public static ConsoleKeyInfo CtrlJ                 = Key(Control, (char)10);
        public static ConsoleKeyInfo CtrlK                 = Key(Control, (char)11);
        public static ConsoleKeyInfo CtrlL                 = Key(Control, (char)12);
        public static ConsoleKeyInfo CtrlM                 = Key(Control, (char)13);
        public static ConsoleKeyInfo CtrlN                 = Key(Control, (char)14);
        public static ConsoleKeyInfo CtrlO                 = Key(Control, (char)15);
        public static ConsoleKeyInfo CtrlP                 = Key(Control, (char)16);
        public static ConsoleKeyInfo CtrlQ                 = Key(Control, (char)17);
        public static ConsoleKeyInfo CtrlR                 = Key(Control, (char)18);
        public static ConsoleKeyInfo CtrlS                 = Key(Control, (char)19);
        public static ConsoleKeyInfo CtrlT                 = Key(Control, (char)20);
        public static ConsoleKeyInfo CtrlU                 = Key(Control, (char)21);
        public static ConsoleKeyInfo CtrlV                 = Key(Control, (char)22);
        public static ConsoleKeyInfo CtrlW                 = Key(Control, (char)23);
        public static ConsoleKeyInfo CtrlX                 = Key(Control, (char)24);
        public static ConsoleKeyInfo CtrlY                 = Key(Control, (char)25);
        public static ConsoleKeyInfo CtrlZ                 = Key(Control, (char)26);

        public static ConsoleKeyInfo CtrlShiftC            = Key(Shift | Control, (char)3);

        public static ConsoleKeyInfo AltShiftB             = Key(Alt, 'B');
        public static ConsoleKeyInfo AltShiftF             = Key(Alt, 'F');

        public static ConsoleKeyInfo AltCtrlY              = Key(Alt | Control, ConsoleKey.Y);

        public static ConsoleKeyInfo Backspace             = Key((char)8);
        public static ConsoleKeyInfo CtrlBackspace         = Key(Control, (char)0x7f);
        public static ConsoleKeyInfo AltBackspace          = Key(Alt, (char)8);
        public static ConsoleKeyInfo Delete                = Key(ConsoleKey.Delete);
        public static ConsoleKeyInfo CtrlDelete            = Key(Control, ConsoleKey.Delete);
        public static ConsoleKeyInfo DownArrow             = Key(ConsoleKey.DownArrow);
        public static ConsoleKeyInfo End                   = Key(ConsoleKey.End);
        public static ConsoleKeyInfo CtrlEnd               = Key(Control, ConsoleKey.End);
        public static ConsoleKeyInfo ShiftEnd              = Key(Shift, ConsoleKey.End);
        public static ConsoleKeyInfo Enter                 = Key('\r');
        public static ConsoleKeyInfo Escape                = Key((char)27);
        public static ConsoleKeyInfo Home                  = Key(ConsoleKey.Home);
        public static ConsoleKeyInfo CtrlHome              = Key(Control, ConsoleKey.Home);
        public static ConsoleKeyInfo ShiftHome             = Key(Shift, ConsoleKey.Home);
        public static ConsoleKeyInfo LeftArrow             = Key(ConsoleKey.LeftArrow);
        public static ConsoleKeyInfo RightArrow            = Key(ConsoleKey.RightArrow);
        public static ConsoleKeyInfo Tab                   = Key((char)9);
        public static ConsoleKeyInfo UpArrow               = Key(ConsoleKey.UpArrow);
        public static ConsoleKeyInfo PageUp                = Key(ConsoleKey.PageUp);
        public static ConsoleKeyInfo PageDown              = Key(ConsoleKey.PageDown);
        public static ConsoleKeyInfo ShiftPageUp           = Key(Shift, ConsoleKey.PageUp);
        public static ConsoleKeyInfo ShiftPageDown         = Key(Shift, ConsoleKey.PageDown);
        public static ConsoleKeyInfo CtrlPageUp            = Key(Control, ConsoleKey.PageUp);
        public static ConsoleKeyInfo CtrlPageDown          = Key(Control, ConsoleKey.PageDown);
        public static ConsoleKeyInfo AltPageUp             = Key(Alt, ConsoleKey.PageUp);
        public static ConsoleKeyInfo AltPageDown           = Key(Alt, ConsoleKey.PageDown);

        public static ConsoleKeyInfo ShiftLeftArrow        = Key(Shift, ConsoleKey.LeftArrow);
        public static ConsoleKeyInfo ShiftRightArrow       = Key(Shift, ConsoleKey.RightArrow);
        public static ConsoleKeyInfo CtrlLeftArrow         = Key(Control, ConsoleKey.LeftArrow);
        public static ConsoleKeyInfo CtrlRightArrow        = Key(Control, ConsoleKey.RightArrow);
        public static ConsoleKeyInfo ShiftCtrlLeftArrow    = Key(Shift | Control, ConsoleKey.LeftArrow);
        public static ConsoleKeyInfo ShiftCtrlRightArrow   = Key(Shift | Control, ConsoleKey.RightArrow);

        public static ConsoleKeyInfo ShiftTab
#if UNIX
                                                           = KeyInfo(Shift, ConsoleKey.Tab);
#else
                                                           = Key(Shift, (char)9);
#endif

        public static ConsoleKeyInfo CtrlEnter             = Key(Control, (char)10);
        public static ConsoleKeyInfo CtrlShiftEnter        = Key(Shift | Control, ConsoleKey.Enter);
        public static ConsoleKeyInfo ShiftEnter            = Key(Shift, (char)13);

        public static ConsoleKeyInfo F1                    = Key(ConsoleKey.F1);
        public static ConsoleKeyInfo F2                    = Key(ConsoleKey.F2);
        public static ConsoleKeyInfo F3                    = Key(ConsoleKey.F3);
        public static ConsoleKeyInfo F4                    = Key(ConsoleKey.F4);
        public static ConsoleKeyInfo F5                    = Key(ConsoleKey.F5);
        public static ConsoleKeyInfo F6                    = Key(ConsoleKey.F6);
        public static ConsoleKeyInfo F7                    = Key(ConsoleKey.F7);
        public static ConsoleKeyInfo F8                    = Key(ConsoleKey.F8);
        public static ConsoleKeyInfo F9                    = Key(ConsoleKey.F9);
        public static ConsoleKeyInfo Fl0                   = Key(ConsoleKey.F10);
        public static ConsoleKeyInfo F11                   = Key(ConsoleKey.F11);
        public static ConsoleKeyInfo F12                   = Key(ConsoleKey.F12);
        public static ConsoleKeyInfo F13                   = Key(ConsoleKey.F13);
        public static ConsoleKeyInfo F14                   = Key(ConsoleKey.F14);
        public static ConsoleKeyInfo F15                   = Key(ConsoleKey.F15);
        public static ConsoleKeyInfo F16                   = Key(ConsoleKey.F16);
        public static ConsoleKeyInfo F17                   = Key(ConsoleKey.F17);
        public static ConsoleKeyInfo F18                   = Key(ConsoleKey.F18);
        public static ConsoleKeyInfo F19                   = Key(ConsoleKey.F19);
        public static ConsoleKeyInfo F20                   = Key(ConsoleKey.F20);
        public static ConsoleKeyInfo F21                   = Key(ConsoleKey.F21);
        public static ConsoleKeyInfo F22                   = Key(ConsoleKey.F22);
        public static ConsoleKeyInfo F23                   = Key(ConsoleKey.F23);
        public static ConsoleKeyInfo F24                   = Key(ConsoleKey.F24);

        public static ConsoleKeyInfo AltF1                 = Key(Alt, ConsoleKey.F1);
        public static ConsoleKeyInfo AltF2                 = Key(Alt, ConsoleKey.F2);
        public static ConsoleKeyInfo AltF3                 = Key(Alt, ConsoleKey.F3);
        public static ConsoleKeyInfo AltF4                 = Key(Alt, ConsoleKey.F4);
        public static ConsoleKeyInfo AltF5                 = Key(Alt, ConsoleKey.F5);
        public static ConsoleKeyInfo AltF6                 = Key(Alt, ConsoleKey.F6);
        public static ConsoleKeyInfo AltF7                 = Key(Alt, ConsoleKey.F7);
        public static ConsoleKeyInfo AltF8                 = Key(Alt, ConsoleKey.F8);
        public static ConsoleKeyInfo AltF9                 = Key(Alt, ConsoleKey.F9);
        public static ConsoleKeyInfo AltFl0                = Key(Alt, ConsoleKey.F10);
        public static ConsoleKeyInfo AltF11                = Key(Alt, ConsoleKey.F11);
        public static ConsoleKeyInfo AltF12                = Key(Alt, ConsoleKey.F12);
        public static ConsoleKeyInfo AltF13                = Key(Alt, ConsoleKey.F13);
        public static ConsoleKeyInfo AltF14                = Key(Alt, ConsoleKey.F14);
        public static ConsoleKeyInfo AltF15                = Key(Alt, ConsoleKey.F15);
        public static ConsoleKeyInfo AltF16                = Key(Alt, ConsoleKey.F16);
        public static ConsoleKeyInfo AltF17                = Key(Alt, ConsoleKey.F17);
        public static ConsoleKeyInfo AltF18                = Key(Alt, ConsoleKey.F18);
        public static ConsoleKeyInfo AltF19                = Key(Alt, ConsoleKey.F19);
        public static ConsoleKeyInfo AltF20                = Key(Alt, ConsoleKey.F20);
        public static ConsoleKeyInfo AltF21                = Key(Alt, ConsoleKey.F21);
        public static ConsoleKeyInfo AltF22                = Key(Alt, ConsoleKey.F22);
        public static ConsoleKeyInfo AltF23                = Key(Alt, ConsoleKey.F23);
        public static ConsoleKeyInfo AltF24                = Key(Alt, ConsoleKey.F24);

        public static ConsoleKeyInfo ShiftF3               = Key(Shift, ConsoleKey.F3);
        public static ConsoleKeyInfo ShiftF8               = Key(Shift, ConsoleKey.F8);

        // Keys to ignore 
#if !UNIX
        public static ConsoleKeyInfo VolumeUp              = Key(/*ConsoleKey.VolumeUp*/(ConsoleKey)175);
        public static ConsoleKeyInfo VolumeDown            = Key(/*ConsoleKey.VolumeDown*/(ConsoleKey)174);
        public static ConsoleKeyInfo VolumeMute            = Key(/*ConsoleKey.VolumeMute*/(ConsoleKey)173);
#endif
    }
}
