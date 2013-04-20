// -----------------------------------------------------------------------
// <copyright file="ProcessKeyStrokes.cs" company="Riphah International University">
// This class Processes the input Keys and return the urdu text
// </copyright>
// -----------------------------------------------------------------------

namespace UrduWordProcessor.Language
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// This class Processes the input Keys and return the urdu text
    /// </summary>
    public class ProcessKeyStrokes
    {
        /// <summary>
        /// This method returns the keys mapped to the phonetic keyboard of InPage
        /// </summary>
        /// <param name="keyData">The recent pressed key</param>
        /// <returns>Returns a string representation of the pressed key(s)</returns>
        public string ProcessPhoneticKeyboard(Keys keyData)
        {
            string data = "";
            switch (keyData)
            {
                // Keys with Shift Pressed
                case Keys.D6 | Keys.Shift: // ARABIC SIGN SALLALLAHOU ALAYHE WASSALLAM
                    data = "\u0610";
                    break;

                case Keys.E | Keys.Shift:  // ARABIC SIGN ALAYHE ASSALLAM
                    data = "\u0611";
                    break;

                case Keys.L | Keys.Shift:  // ARABIC SIGN RAHMATULLAH ALAYHE
                    data = "\u0612";
                    break;

                case Keys.B | Keys.Shift:  // ARABIC SIGN RADI ALLAHOU ANHU
                    data = "\u0612";
                    break;

                case Keys.H | Keys.Shift: // Hay
                    data = "\u062D";
                    break;

                case Keys.K | Keys.Shift: // Khay
                    data = "\u0628";
                    break;

                case Keys.C | Keys.Shift: // Say
                    data = "\u062B";
                    break;

                case Keys.Z | Keys.Shift: // Zaal
                    data = "\u0630";
                    break;

                case Keys.S | Keys.Shift: // Swaad
                    data = "\u0635";
                    break;

                case Keys.J | Keys.Shift: // Zwaad
                    data = "\u0636";
                    break;

                case Keys.V | Keys.Shift: // Zway
                    data = "\u0636";
                    break;

                case Keys.G | Keys.Shift: // Ghaen
                    data = "\u063A";
                    break;

                case Keys.Y | Keys.Shift: // Sana'ah
                    data = "\u0601";
                    break;

                case Keys.Oemplus | Keys.Shift:// ARABIC LETTER ALEF WITH HAMZA ABOVE
                    data = "\u0623";
                    break;

                case Keys.Oemtilde | Keys.Shift:// ARABIC KASRATAN
                    data = "\u064D";
                    break;

                case Keys.P | Keys.Shift:   // ARABIC DAMMA
                    data = "\u064F";
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
                    data = "\u0691";
                    break;

                case Keys.N | Keys.Shift:   // ARABIC LETTER NOON GHUNNA
                    data = "\u06BA";
                    break;

                case Keys.O | Keys.Shift:   // ARABIC LETTER TEH MARBUTA GOAL
                    data = "\u06C3";
                    break;

                case Keys.Oemcomma | Keys.Shift:     // ARABIC FATHA
                    data = "\u064E";
                    break;

                case Keys.OemPeriod | Keys.Shift:     // ARABIC KASRA
                    data = "\u0650";
                    break;

                case Keys.W | Keys.Shift:// ARABIC LIGATURE SALLALLAHOU ALAYHE WASALLAM
                    data = "\uFDFA";
                    break;

                ///////////////////// Keys normaly pressed \\\\\\\\\\\\\\\\\\\\\\\\\
                case Keys.Oemplus:      // alif-mad
                    data = "\u0622";
                    break;

                case Keys.A:            // Alif
                    data = "\u0627";
                    break;

                case Keys.B:            // Bay
                    data = "\u0628";
                    break;

                case Keys.T:            // Tay
                    data = "\u062A";
                    break;

                case Keys.J:            // Jeem
                    data = "\u062C";
                    break;

                case Keys.D:            // Daal
                    data = "\u062F";
                    break;

                case Keys.R:            // Ray
                    data = "\u0631";
                    break;

                case Keys.Z:            // Zay
                    data = "\u0632";
                    break;

                case Keys.S:            // Seen
                    data = "\u0633";
                    break;

                case Keys.V:            // Tway
                    data = "\u0637";
                    break;

                case Keys.E:            // Aeen
                    data = "\u0639";
                    break;

                case Keys.F:            // Fay
                    data = "\u0641";
                    break;

                case Keys.Q:            // Qaaf
                    data = "\u0642";
                    break;

                case Keys.L:            // Laam
                    data = "\u0644";
                    break;

                case Keys.M:            // Meem
                    data = "\u0645";
                    break;

                case Keys.N:            // Noon
                    data = "\u0646";
                    break;

                case Keys.W:            // Wao
                    data = "\u0648";
                    break;

                case Keys.OemBackslash: // POETIC VERSE SIGN
                    data = "\u060E";
                    break;

                case Keys.Oemtilde:     // Do Zabar
                    data = "\u064B";
                    break;

                case Keys.OemPipe:     // ARABIC SIGN TAKHALLUS
                    data = "\u0614";
                    break;

                case Keys.OemSemicolon: // ARABIC SEMICOLON
                    data = "\u061B";
                    break;

                case Keys.OemQuestion:  // ARABIC QUESTION MARK
                    data = "\u061F";
                    break;

                case Keys.OemMinus:     // ARABIC LETTER ALEF WITH HAMZA ABOVE
                    data = "\u0623";
                    break;

                case Keys.U:            // ARABIC LETTER HAMZA
                    data = "\u0621";
                    break;

                case Keys.P:            // ARABIC LETTER PEH
                    data = "\u067E";
                    break;

                case Keys.C:            // ARABIC LETTER TCHEH
                    data = "\u0686";
                    break;

                case Keys.X:            // Sheen
                    data = "\u0634";
                    break;

                case Keys.K:            // ARABIC LETTER KEHEH
                    data = "\u06A9";
                    break;

                case Keys.G:            // ARABIC LETTER GAF
                    data = "\u06AF";
                    break;

                case Keys.H:            // ARABIC LETTER HEH DOACHASHMEE
                    data = "\u06BE";
                    break;

                case Keys.O:            // ARABIC LETTER HEH GOAL
                    data = "\u06C1";
                    break;

                case Keys.I:            // ARABIC LETTER FARSI YEH
                    data = "\u06CC";
                    break;

                case Keys.Y:            // ARABIC LETTER YEH BARREE
                    data = "\u06D2";
                    break;

                case Keys.OemPeriod:   // ARABIC FULL STOP
                    data = "\u06D4";
                    break;

                case Keys.D0:   // ARABIC Zero
                    data = "\u06F0";
                    break;

                case Keys.D1:   // ARABIC One
                    data = "\u06F1";
                    break;

                case Keys.D2:   // ARABIC Two
                    data = "\u06F2";
                    break;

                case Keys.D3:   // ARABIC Three
                    data = "\u06F3";
                    break;

                case Keys.D4:   // ARABIC Four
                    data = "\u06F4";
                    break;

                case Keys.D5:   // ARABIC Five
                    data = "\u06F5";
                    break;

                case Keys.D6:   // ARABIC Six
                    data = "\u06F6";
                    break;

                case Keys.D7:   // ARABIC Seven
                    data = "\u06F7";
                    break;

                case Keys.D9:   // ARABIC Nine
                    data = "\u06F9";
                    break;
            } // end switch(keyData)
            return data;
        } // end ProcessCmdKey(Keys keyData)
    }
}
