using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;



namespace editor
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuOpen;
        private System.Windows.Forms.MenuItem menuNew;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.MenuItem menuSave;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuWordCount;
        private System.Windows.Forms.OpenFileDialog openFile1;
        private System.Windows.Forms.SaveFileDialog saveFile1;
        private MenuItem menuDelimCount;
        private IContainer components;



        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }



        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuWordCount = new System.Windows.Forms.MenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuOpen = new System.Windows.Forms.MenuItem();
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.menuNew = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuDelimCount = new System.Windows.Forms.MenuItem();
            this.openFile1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFile1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // menuWordCount
            // 
            this.menuWordCount.Index = 0;
            this.menuWordCount.Text = "&Word count";
            this.menuWordCount.Click += new System.EventHandler(this.menuWordCount_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1195, 549);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem7});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuOpen,
            this.menuSave,
            this.menuNew,
            this.menuItem4,
            this.menuExit});
            this.menuItem1.Text = "&File";
            // 
            // menuOpen
            // 
            this.menuOpen.Index = 0;
            this.menuOpen.Text = "&Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Index = 1;
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuNew
            // 
            this.menuNew.Index = 2;
            this.menuNew.Text = "&New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "-";
            // 
            // menuExit
            // 
            this.menuExit.Index = 4;
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuWordCount,
            this.menuDelimCount});
            this.menuItem7.Text = "Tools";
            // 
            // menuDelimCount
            // 
            this.menuDelimCount.Index = 1;
            this.menuDelimCount.Text = "Delimiter count";
            this.menuDelimCount.Click += new System.EventHandler(this.menuDelimCount_Click);
            // 
            // openFile1
            // 
            this.openFile1.DefaultExt = "rtf";
            // 
            // saveFile1
            // 
            this.saveFile1.DefaultExt = "rtf";
            this.saveFile1.FileName = "doc1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(1195, 549);
            this.Controls.Add(this.richTextBox1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.ResumeLayout(false);

        }
        #endregion



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }



        private void menuOpen_Click(object sender, System.EventArgs e)
        {
            openFile1.DefaultExt = "txt";
            openFile1.Filter = "Text files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf";
            openFile1.InitialDirectory = Path.GetDirectoryName(Application.StartupPath + "\\test\\");

            if (openFile1.ShowDialog() == DialogResult.OK && openFile1.FileName.Length > 0)
            {
                // Load file into the RichTextBox.
                if (openFile1.FilterIndex == 1)
                    richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
                else
                    richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);
            }
        }



        private void menuSave_Click(object sender, EventArgs e)
        {
            saveFile1.DefaultExt = "rtf";
            saveFile1.Filter = "RTF Files (*.rtf)|*.rtf|Text files (*.txt)|*.txt";
            saveFile1.InitialDirectory = Path.GetDirectoryName(Application.StartupPath + "\\test\\");

            if (saveFile1.ShowDialog() == DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                saveFile1.AddExtension = true;

                if (System.IO.Path.GetExtension(saveFile1.FileName) == "")
                    saveFile1.FileName = saveFile1.FileName + ".xxx";

                // Save contents of RichTextBox to file.				
                if (saveFile1.FilterIndex == 1)
                    richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
                else
                    richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }



        private void menuNew_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }



        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        // -------------------------------------------------------------------------------------------
        string DELIMS = " .,?!-_+*/";
        int charcount = 0;



        private bool IsDelimiter(char c)
        {
            if (DELIMS.Contains(c.ToString()))
                return true;
            else
                return false;
        }



        private void FindDelims()
        {
            string s = richTextBox1.Text;
            int delimcount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (IsDelimiter(s[i]))
                    delimcount++;
            }

            MessageBox.Show("Number of delimiters is " + delimcount,
                "Statistics",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }



        private bool ScrollThroughWord(string s)
        {
            bool wordfound = false;

            while ((charcount < s.Length) && !(IsDelimiter(s[charcount])))
            {
                charcount++;
                wordfound = true;
            }

            return wordfound;
        }


        private void ScrollThroughDelims(string s)
        {
            while ((charcount < s.Length) && IsDelimiter(s[charcount]))
            {
                charcount++;
            }
        }



        private void CountWordsAndCharacters()
        {
            string s = richTextBox1.Text;
            charcount = 0;
            int wordcount = 0;

            while (charcount < s.Length)
            {
                ScrollThroughDelims(s);
                if (ScrollThroughWord(s))
                {
                    wordcount++;
                }
            }

            MessageBox.Show("Number of words: " + wordcount + " - Characters: " + charcount,
                "Statistics",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }



        private void menuWordCount_Click(object sender, EventArgs e)
        {
            CountWordsAndCharacters();
        }



        private void menuDelimCount_Click(object sender, EventArgs e)
        {
            FindDelims();
        }
    }
}
