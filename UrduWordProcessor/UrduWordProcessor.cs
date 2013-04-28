//uf wrfgwrg wruf
using DevExpress.XtraBars.Ribbon;
using System.Drawing.Text;
using System.IO;
using DevExpress.XtraBars.Helpers;
using System.ComponentModel;
using System.Threading;
using System.Globalization;
using UrduWordProcessor.Properties;
using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using UrduWordProcessor.Language;
using NHunspell;
using System.Drawing;

namespace UrduWordProcessor
{
    public partial class urduWordProcessor : RibbonForm
    {
        // Variable declarations
        float zoomFactor;
        float selectionFontSize;
        PrivateFontCollection fontCollection;
        FileSystemWatcher fontWatcher;
        FindBox findBox;
        ProcessKeyStrokes processKeyStrokes;

        Hunspell spellChecker;

        private int indexOfSearchText = 0;
        private int start = 0;

        private bool urduSelected;
        private string keyboardLayout;

        // Method and constructor declarations
        public urduWordProcessor() // constructor
        {
            InitializeComponent();
            InitSkinGallery();
            
            // register custom events
            registerEvents();
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        // Method Declarations

        /// <summary>
        /// This method checks the urdu spellings
        /// </summary>
        private void checkUrduSpell()
        {
            string lastWord = "";
            int index = 0;
            for (int i = document.TextLength - 1; i >= 0; i--)
            {
                if (document.Text[i] == ' ')
                {
                    index = i;
                    break;
                }
            }
            lastWord = document.Text.Substring(index);
            
            if (!spellChecker.Spell(lastWord))
            {
                document.SelectionStart = index;
                document.SelectionLength = lastWord.Length;
                document.SelectionColor = Color.Red;
                document.DeselectAll();
                document.SelectionStart = document.TextLength;
                document.SelectionLength = 0;
                document.SelectionColor = Color.Black;
            }
        } // end GetLastWord()

        /// <summary>
        /// This method is used to register different events and initialize attributes
        /// </summary>
        private void registerEvents()
        {
            spellChecker = new Hunspell("dic/ur.aff", "dic/ur.dic");
            //spellChecker.Load("dic/ur.aff", "dic/ur.dic");
            
            keyboardLayout = "phonetic";
            processKeyStrokes = new ProcessKeyStrokes();
            urduSelected = true;

            changeUIText();
            
            // if the default language has been changed
            Settings.Default.PropertyChanged += new PropertyChangedEventHandler(Default_PropertyChanged);

            // set zoom factor to 1 initially
            zoomFactor = 1.0f;

            // selection fon size
            selectionFontSize = 0;

            fontCollection = new PrivateFontCollection();
            fontWatcher = new FileSystemWatcher(@"fonts");

            // font size of the selected text should be shown in the font size combo box
            document.SelectionChanged += new EventHandler(document_SelectionChanged);

            // keep an eye on fonts
            fontWatcher.Filter = ".ttf";
            fontWatcher.NotifyFilter = NotifyFilters.LastAccess |
                                             NotifyFilters.LastWrite |
                                             NotifyFilters.FileName |
                                             NotifyFilters.DirectoryName;
            fontWatcher.IncludeSubdirectories = true;
            fontWatcher.Changed += new FileSystemEventHandler(fontWatcher_Changed);
            fontWatcher.Renamed += new RenamedEventHandler(fontWatcher_Renamed);
            fontWatcher.Deleted += new FileSystemEventHandler(fontWatcher_Deleted);
            fontWatcher.Created += new FileSystemEventHandler(fontWatcher_Created);

            // set fonts
            repositoryItemFontEdit.AutoComplete = true;
            FontEdit fontEdit = new FontEdit();
            fontEdit.Properties.Items.AddRange(fontCollection.Families);
        } // end registerEvents()

        /// <summary>
        /// This method zooms the document
        /// </summary>
        /// <param name="value">Value ranges from 1.0 - 63.0</param>
        private void zoomRichTB(float value)
        {
            if (value < 1)
                value = 1;
            else if (value >= 63)
                value = 63;
            document.ZoomFactor = value;
            zoomFactor = value;
        } // end zoomRichTB(float value)

        /// <summary>
        /// This method finds the particular sub-string in the document
        /// </summary>
        /// <param name="txtToSearch">Text to be searched in the document</param>
        /// <param name="searchStart">The starting position of the string to be searched</param>
        /// <param name="searchEnd">The ending position of the string top be searched</param>
        /// <returns>The index of the matched string</returns>
        public int FindMyText(string txtToSearch, int searchStart, int searchEnd)
        {
            // Unselect the previously searched string
            if (searchStart > 0 && searchEnd > 0 && indexOfSearchText >= 0)
            {
                document.Undo();
            } // end if()

            // Set the return value to -1 by default.
            int retVal = -1;

            // A valid starting index should be specified.
            // if indexOfSearchText = -1, the end of search
            if (searchStart >= 0 && indexOfSearchText >= 0)
            {
                // A valid ending index
                if (searchEnd > searchStart || searchEnd == -1)
                {
                    // Find the position of search string in RichTextBox
                    indexOfSearchText = document.Find(txtToSearch, searchStart, searchEnd, RichTextBoxFinds.None);
                    // Determine whether the text was found in document.
                    if (indexOfSearchText != -1)
                    {
                        // Return the index to the specified search text.
                        retVal = indexOfSearchText;
                    } // end if()
                } // end if()
            } // end if()
            return retVal;
        } // end FindMyText(string txtToSearch, int searchStart, int searchEnd)

        /// <summary>
        /// This method switched the current User Interface language between English
        /// and Urdu
        /// </summary>
        private static void changeUIText()
        {
            //MessageBox.Show(Settings.Default.CurrentLanguage);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(Settings.Default.CurrentLanguage);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Default.CurrentLanguage);
        } // end void changeUIText()

        /// <summary>
        /// This method shows the under-construction message box
        /// </summary>
        private static void underConstruction()
        {
            MessageBox.Show("This feature is currently underconstruction!");
        } // end underConstruction()

        // Listeners Declaration
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.Oemplus)) // zoom in
            {
                zoomFactor++;
                this.zoomRichTB(zoomFactor);
                return true;
            }
            if (keyData == (Keys.Control | Keys.OemMinus)) // zoom out
            {
                zoomFactor--;
                this.zoomRichTB(zoomFactor);
                return true;
            }
            if (keyData == (Keys.Control | Keys.Space)) // Switch Language
            {
                urduSelected = !urduSelected;
                if (urduSelected)
                    keyboardSwitchBtn.Caption = "Keyboard: اُردو";
                else
                    keyboardSwitchBtn.Caption = "Keyboard: English";
                return true;
            }
            if(keyData == Keys.Back) // use default thingy
                return base.ProcessCmdKey(ref msg, keyData);
            if (keyData == Keys.Space) // for word segmentation
            {
                checkUrduSpell();
                return base.ProcessCmdKey(ref msg, keyData);
            }
            if (urduSelected)
            {
                if (keyData == Keys.Space)
                {
                    MessageBox.Show("sdfdgh");
                    
                }
                if (keyboardLayout.Equals("phonetic"))
                {
                    if (keyData == Keys.I) // concatenate hamza and chotti yeh
                    {
                        if (document.Text.EndsWith("ء"))
                        {
                            document.Text = document.Text.Substring(0, document.TextLength - 1);
                            document.AppendText("ئی");
                        }
                        else
                        {
                            document.AppendText(processKeyStrokes.ProcessPhoneticKeyboard(keyData));
                        }
                    }
                    else if (keyData == Keys.Y) // concatenate hamza and barri yeh
                    {
                        if (document.Text.EndsWith("ء"))
                        {
                            document.Text = document.Text.Substring(0, document.TextLength - 1);
                            document.AppendText("ئے");
                        }
                        else
                        {
                            document.AppendText(processKeyStrokes.ProcessPhoneticKeyboard(keyData));
                        }
                    }
                    else
                    {
                        document.AppendText(processKeyStrokes.ProcessPhoneticKeyboard(keyData));
                    }
                }
                return true;
            } // end if (urduSelected)
            return base.ProcessCmdKey(ref msg, keyData);
        }

        void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            changeUIText();
        }

        void fontWatcher_Created(object sender, FileSystemEventArgs e)
        {
            fontCollection.AddFontFile(e.FullPath);
        }

        void fontWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            fontCollection.AddFontFile(e.FullPath);
        }

        void fontWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            fontCollection.AddFontFile(e.FullPath);
        }

        void fontWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            fontCollection.AddFontFile(e.FullPath);
        }

        void document_SelectionChanged(object sender, EventArgs e)
        {
            selectionFontSize = document.SelectionFont.Size;
        }

        private static void navBarControl_Click(object sender, EventArgs e)
        {

        }

        private static void pictureEdit_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private static void barCheckItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private static void barEditItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void findribbongroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            findBox = new FindBox();
            findBox.findSearchBtn.Click += new EventHandler(FindBoxBtn_Click);
            findBox.Show();
        }

        void FindBoxBtn_Click(object sender, EventArgs e)
        {
            this.FindMyText(findBox.searchTermsTxt.Text, 0, document.TextLength - 1);
            this.Select();
        }

        void findBoxSearchBtn_Click(object sender, EventArgs e)
        {
            int startIndex = 0;

            char[] term = findBox.searchTermsTxt.Text.ToCharArray();
            startIndex = this.document.Find(term, startIndex);
            
            //document.Select(startIndex, term.Length);
            document.SelectionStart = startIndex;
            document.SelectionLength = term.Length;
            this.Select();
            MessageBox.Show("Found: " + document.Text.Substring(startIndex, term.Length));
        }

        private static void barEditItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void iClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void zoomTrackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
            float value = float.Parse(zoomTrackBarControl1.EditValue.ToString());
            zoomRichTB(value);
        }

        private static void barEditItemFontSIze_EditValueChanged(object sender, EventArgs e)
        {
            //document.SelectionFont = new Font(
        }

        private static void barEditItemFonts_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItemFacebook_ItemClick(object sender, ItemClickEventArgs e)
        {
            FacebookAuthentication fa = new FacebookAuthentication();
            fa.Type = "wall";
            fa.Show();
            fa.LoadAuthorize();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Options uwpo = new Options();
            uwpo.Show();
        }

        // if SwtichUILang is clicked
        private void barButtonItemSwitchUILang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Settings.Default.CurrentLanguage.Equals("en"))
            {
                Settings.Default.CurrentLanguage = "ur-PK";
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ur-PK");
                //MessageBox.Show(Settings.Default.CurrentLanguage);
            }
            else if (Settings.Default.CurrentLanguage.Equals("ur-PK"))
            {
                Settings.Default.CurrentLanguage = "en";
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            }
            Settings.Default.Save();
        }

        private void barButtonItemFacebookPage_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Settings.Default.FacebookPageID.Equals("-1"))
            {
                MessageBox.Show("You need to specify facebook page id first!");
            }
            else
            {
                FacebookAuthentication fa = new FacebookAuthentication() { Type = "page" };
                fa.Show();
                fa.LoadAuthorize();
            }
        }

        private void iNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void iOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void iSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void iSaveAs_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void iHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void headerRibbonpagegroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void Footerribbonpagegroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void tableribbonpagegroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void passwordribbonpagegroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void barButtonItemSendAsEmail_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void barButtonItemWordPress_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void barButtonItemTwitter_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void barButtonItemFBLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void Dictionaryribbonpagegroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void SpellCheckerribbongroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void texttospeechribbonhomepage_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void barButtonItemMailMerge_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void iAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            underConstruction();
        }

        private void document_TextChanged(object sender, EventArgs e)
        {
            start = 0;
            indexOfSearchText = 0;
        }

        private void keyboardSwitchBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (urduSelected)
            {
                urduSelected = !urduSelected;
                keyboardSwitchBtn.Caption = "Keyboard: English";
            }
            else
            {
                urduSelected = !urduSelected;
                keyboardSwitchBtn.Caption = "Keyboard: اُردو";
            }
        }

        private void spellingsButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            document.SelectAll();
            document.SelectionColor = Color.Black;
            document.DeselectAll();
            
            spellChecker1.Check(document);
        }
    }
}