using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UrduWordProcessor
{
    class ProcessKeyStrokes
    {
        /// <summary>
        /// This method maps key strokes over InPage Phonetic Keyboard
        /// </summary>
        /// <param name="keyData">The key press data</param>
        /// <returns>The string representation of the key presses</returns>
        public string ProcessPhoneticKeyboard(Keys keyData)
        {
            string data = "";
            switch (keyData)
            {
                // If Shift key is pressed
                case Keys.Y | Keys.Shift:   // ARABIC SIGN SANAH
                    data = "\u0601";
                    break;

                case Keys.D3 | Keys.Shift:  // ARABIC DATE SEPARATOR
                    data = "\u060D";
                    break;

                case Keys.D6 | Keys.Shift:   // ARABIC SIGN SALLALLAHOU ALAYHE WASSALLAM
                    data = "\u0610";
                    break;

                case Keys.E | Keys.Shift:   // ARABIC SIGN ALAYHE ASSALLAM
                    data = "\u0611";
                    break;

                case Keys.L | Keys.Shift:   // ARABIC SIGN RAHMATULLAH ALAYHE
                    data = "\u0612";
                    break;

                case Keys.B | Keys.Shift:   // ARABIC SIGN RADI ALLAHOU ANHU
                    data = "\u0613";
                    break;

                case Keys.Oemplus | Keys.Shift:// ARABIC LETTER WAW WITH HAMZA ABOVE
                    data = "\u0624";
                    break;

                case Keys.D4 | Keys.Shift:  // ARABIC LETTER YEH WITH HAMZA ABOVE
                    data = "\u0626";
                    break;

                case Keys.C | Keys.Shift:   // ARABIC LETTER THEH
                    data = "\u062B";
                    break;

                case Keys.H | Keys.Shift:   // ARABIC LETTER HAH
                    data = "\u062D";
                    break;

                case Keys.K | Keys.Shift:   // ARABIC LETTER KHAH
                    data = "\u062E";
                    break;

                case Keys.Z | Keys.Shift:   // ARABIC LETTER THAL
                    data = "\u0630";
                    break;

                case Keys.S | Keys.Shift:   // ARABIC LETTER SAD
                    data = "\u0635";
                    break;

                case Keys.J | Keys.Shift:   // ARABIC LETTER DAD
                    data = "\u0636";
                    break;

                case Keys.V | Keys.Shift:   // ARABIC LETTER ZAH
                    data = "\u0638";
                    break;

                case Keys.G | Keys.Shift:   // ARABIC LETTER GHAIN
                    data = "\u063A";
                    break;

                case Keys.Oemtilde | Keys.Shift:// ARABIC KASRATAN
                    data = "\u064D";
                    break;

                case Keys.Oemcomma | Keys.Shift:// ARABIC FATHA
                    data = "\u064E";
                    break;

                case Keys.P | Keys.Shift:   // ARABIC DAMMA
                    data = "\u064F";
                    break;

                case Keys.OemPeriod | Keys.Shift:// ARABIC KASRA
                    data = "\u0650";
                    break;

                case Keys.OemMinus | Keys.Shift:// ARABIC SHADDA
                    data = "\u0651";
                    break;

                case Keys.D2 | Keys.Shift:  // ARABIC SUKUN
                    data = "\u0652";
                    break;

                case Keys.A | Keys.Shift:   // ARABIC MADDAH ABOVE
                    data = "\u0653";
                    break;

                case Keys.I | Keys.Shift:   // ARABIC SUBSCRIPT ALEF
                    data = "\u0656";
                    break;

                case Keys.F | Keys.Shift:   // ARABIC SUPERSCRIPT ALEF
                    data = "\u0670";
                    break;

                case Keys.T | Keys.Shift:   // ARABIC LETTER TTEH
                    data = "\u0679";
                    break;

                case Keys.D | Keys.Shift:   // ARABIC LETTER DDAL
                    data = "\u0688";
                    break;

                case Keys.R | Keys.Shift:   // ARABIC LETTER RREH
                    data = "\u0691";
                    break;

                case Keys.X | Keys.Shift:   // ARABIC LETTER JEH
                    data = "\u0698";
                    break;

                case Keys.N | Keys.Shift:   // ARABIC LETTER NOON GHUNNA
                    data = "\u06BA";
                    break;

                case Keys.O | Keys.Shift:   // ARABIC LETTER TEH MARBUTA GOAL
                    data = "\u06C3";
                    break;

                case Keys.W | Keys.Shift:   // ARABIC LIGATURE SALLALLAHOU ALAYHE WASALLAM
                    data = "\uFDFA";
                    break;
                /////////////////////////////////////////////
                //
                // If key press are without Shift Key
                //
                ////////////////////////////////////////////
                case Keys.Oemcomma:         // ARABIC COMMA
                    data = "\u0601";
                    break;

                case Keys.OemBackslash:     // ARABIC POETIC VERSE SIGN
                    data = "\u060E";
                    break;

                case Keys.OemPipe:          // ARABIC SIGN TAKHALLUS
                    data = "\u0614";
                    break;

                case Keys.OemSemicolon:     // ARABIC SEMICOLON
                    data = "\u061B";
                    break;

                case Keys.OemQuestion:      // ARABIC QUESTION MARK
                    data = "\u061F";
                    break;

                case Keys.U:                // ARABIC LETTER HAMZA
                    data = "\u0621";
                    break;

                case Keys.Oemplus:          // ARABIC LETTER ALEF WITH MADDA ABOVE
                    data = "\u0622";
                    break;

                case Keys.OemMinus:         // ARABIC LETTER ALEF WITH HAMZA ABOVE
                    data = "\u0623";
                    break;

                case Keys.A:                // ARABIC LETTER ALEF
                    data = "\u0627";
                    break;

                case Keys.B:                // ARABIC LETTER BEH
                    data = "\u0628";
                    break;

                case Keys.T:                // ARABIC LETTER TEH
                    data = "\u062A";
                    break;

                case Keys.J:                // ARABIC LETTER JEEM
                    data = "\u062C";
                    break;

                case Keys.D:                // ARABIC LETTER DAL
                    data = "\u062F";
                    break;

                case Keys.R:                // ARABIC LETTER REH
                    data = "\u0631";
                    break;

                case Keys.Z:                // ARABIC LETTER ZAIN
                    data = "\u0632";
                    break;

                case Keys.S:                // ARABIC LETTER SEEN
                    data = "\u0633";
                    break;

                case Keys.X:                // ARABIC LETTER SHEEN
                    data = "\u0634";
                    break;

                case Keys.V:                // ARABIC LETTER TAH
                    data = "\u0637";
                    break;

                case Keys.E:                // ARABIC LETTER AIN
                    data = "\u0639";
                    break;

                case Keys.F:                // ARABIC LETTER FEH
                    data = "\u0641";
                    break;

                case Keys.Q:                // ARABIC LETTER QAF
                    data = "\u0642";
                    break;

                case Keys.L:                // ARABIC LETTER LAM
                    data = "\u0644";
                    break;

                case Keys.M:                // ARABIC LETTER MEEM
                    data = "\u0645";
                    break;

                case Keys.N:                // ARABIC LETTER NOON
                    data = "\u0646";
                    break;

                case Keys.W:                // ARABIC LETTER WAW
                    data = "\u0648";
                    break;

                case Keys.Oemtilde:         // ARABIC FATHATAN
                    data = "\u064B";
                    break;

                case Keys.P:                // ARABIC LETTER PEH
                    data = "\u067E";
                    break;

                case Keys.C:                // ARABIC LETTER TCHEH
                    data = "\u0686";
                    break;

                case Keys.K:                // ARABIC LETTER KEHEH
                    data = "\u06A9";
                    break;

                case Keys.G:                // ARABIC LETTER GAF
                    data = "\u06AF";
                    break;

                case Keys.H:                // ARABIC LETTER HEH DOACHASHMEE
                    data = "\u06BE";
                    break;

                case Keys.O:                // ARABIC LETTER HEH GOAL
                    data = "\u06C1";
                    break;

                case Keys.I:                // ARABIC LETTER FARSI YEH
                    data = "\u06CC";
                    break;

                case Keys.Y:                // ARABIC LETTER YEH BARREE
                    data = "\u06D2";
                    break;

                case Keys.OemPeriod:        // ARABIC FULL STOP
                    data = "\u06D4";
                    break;

                case Keys.D0:               // EXTENDED ARABIC-INDIC DIGIT ZERO
                    data = "\u06F0";
                    break;

                case Keys.D1:               // EXTENDED ARABIC-INDIC DIGIT ONE
                    data = "\u06F1";
                    break;

                case Keys.D2:               // EXTENDED ARABIC-INDIC DIGIT TWO
                    data = "\u06F2";
                    break;

                case Keys.D3:               // EXTENDED ARABIC-INDIC DIGIT THREE
                    data = "\u06F3";
                    break;

                case Keys.D4:               // EXTENDED ARABIC-INDIC DIGIT FOUR
                    data = "\u06F4";
                    break;

                case Keys.D5:               // EXTENDED ARABIC-INDIC DIGIT FIVE
                    data = "\u06F5";
                    break;

                case Keys.D6:               // EXTENDED ARABIC-INDIC DIGIT SIX
                    data = "\u06F6";
                    break;

                case Keys.D7:               // EXTENDED ARABIC-INDIC DIGIT SEVEN
                    data = "\u06F7";
                    break;

                case Keys.D8:               // EXTENDED ARABIC-INDIC DIGIT EIGHT
                    data = "\u06F8";
                    break;

                case Keys.D9:               // EXTENDED ARABIC-INDIC DIGIT NINE
                    data = "\u06F9";
                    break;
            }
            return data;
        }
    }
}
