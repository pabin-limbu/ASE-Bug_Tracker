using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bugTracker.controller;
using System.IO;
using bugTracker.model;
using System.Text.RegularExpressions;

namespace bugTracker.view
{
    public partial class FormFixBug : Form
    {
        int id;
        Bug bug;
        User user;
        public FormFixBug(int id,User user)
        {
            this.id = id;
            this.user = user;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormFixBug_Load(object sender, EventArgs e)
        {
            BugController bugController = new BugController();
            bug = bugController.getBugById(id);
            Image img = byteArrayToImage(bug.Image);
            pictureBox1.Image = img;
            txtBugId.Text =Convert.ToString( bug.Id);
            txtBugName.Text = bug.BugName;
            txtProjectName.Text = bug.ProjectName;
            txtPackageName.Text = bug.PackageName;
            txtClassName.Text = bug.ClassName;
            txtMethodName.Text = bug.MethodName;
            txtPreviousCode.Text = bug.CodeBlock;
            
            
        }
        // this code block is used to get image from byte[]

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void txtPreviousCode_TextChanged(object sender, EventArgs e)
        {
            // getting keywords/functions
            string keywords = @"\b(public|private|partial|static|namespace|class|using|foreach|in|String|int|Integer|void)\b";
            MatchCollection keywordMatches = Regex.Matches(txtPreviousCode.Text, keywords);

            // getting types/classes from the text 
            string types = @"\b(Console)\b";
            MatchCollection typeMatches = Regex.Matches(txtPreviousCode.Text, types);

            // getting comments (inline or multiline)
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(txtPreviousCode.Text, comments, RegexOptions.Multiline);

            // getting strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(txtPreviousCode.Text, strings);

            // saving the original caret position + forecolor
            int originalIndex = txtPreviousCode.SelectionStart;
            int originalLength = txtPreviousCode.SelectionLength;
            Color originalColor = Color.Black;

            // MANDATORY - focuses a label before highlighting (avoids blinking)
            // titleLabel.Focus();

            // removes any previous highlighting (so modified words won't remain highlighted)
            txtPreviousCode.SelectionStart = 0;
            txtPreviousCode.SelectionLength = txtPreviousCode.Text.Length;
            txtPreviousCode.SelectionColor = originalColor;

            // scanning...
            foreach (Match m in keywordMatches)
            {
                txtPreviousCode.SelectionStart = m.Index;
                txtPreviousCode.SelectionLength = m.Length;
                txtPreviousCode.SelectionColor = Color.Blue;
            }

            foreach (Match m in typeMatches)
            {
                txtPreviousCode.SelectionStart = m.Index;
                txtPreviousCode.SelectionLength = m.Length;
                txtPreviousCode.SelectionColor = Color.DarkCyan;
            }

            foreach (Match m in commentMatches)
            {
                txtPreviousCode.SelectionStart = m.Index;
                txtPreviousCode.SelectionLength = m.Length;
                txtPreviousCode.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches)
            {
                txtPreviousCode.SelectionStart = m.Index;
                txtPreviousCode.SelectionLength = m.Length;
                txtPreviousCode.SelectionColor = Color.Brown;
            }

            // restoring the original colors, for further writing
            txtPreviousCode.SelectionStart = originalIndex;
            txtPreviousCode.SelectionLength = originalLength;
            txtPreviousCode.SelectionColor = originalColor;

            // giving back the focus
            txtPreviousCode.Focus();
        }

        private void txtFixedCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFixedCode_TextChanged_1(object sender, EventArgs e)
        {
            // getting keywords/functions
            string keywords = @"\b(public|private|partial|static|namespace|class|using|foreach|in|String|int|Integer|void)\b";
            MatchCollection keywordMatches = Regex.Matches(txtFixedCode.Text, keywords);

            // getting types/classes from the text 
            string types = @"\b(Console)\b";
            MatchCollection typeMatches = Regex.Matches(txtFixedCode.Text, types);

            // getting comments (inline or multiline)
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(txtFixedCode.Text, comments, RegexOptions.Multiline);

            // getting strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(txtFixedCode.Text, strings);

            // saving the original caret position + forecolor
            int originalIndex = txtFixedCode.SelectionStart;
            int originalLength = txtFixedCode.SelectionLength;
            Color originalColor = Color.Black;

            // MANDATORY - focuses a label before highlighting (avoids blinking)
            // titleLabel.Focus();

            // removes any previous highlighting (so modified words won't remain highlighted)
            txtFixedCode.SelectionStart = 0;
            txtFixedCode.SelectionLength = txtFixedCode.Text.Length;
            txtFixedCode.SelectionColor = originalColor;

            // scanning...
            foreach (Match m in keywordMatches)
            {
                txtFixedCode.SelectionStart = m.Index;
                txtFixedCode.SelectionLength = m.Length;
                txtFixedCode.SelectionColor = Color.Blue;
            }

            foreach (Match m in typeMatches)
            {
                txtFixedCode.SelectionStart = m.Index;
                txtFixedCode.SelectionLength = m.Length;
                txtFixedCode.SelectionColor = Color.DarkCyan;
            }

            foreach (Match m in commentMatches)
            {
                txtFixedCode.SelectionStart = m.Index;
                txtFixedCode.SelectionLength = m.Length;
                txtFixedCode.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches)
            {
                txtFixedCode.SelectionStart = m.Index;
                txtFixedCode.SelectionLength = m.Length;
                txtFixedCode.SelectionColor = Color.Brown;
            }

            // restoring the original colors, for further writing
            txtFixedCode.SelectionStart = originalIndex;
            txtFixedCode.SelectionLength = originalLength;
            txtFixedCode.SelectionColor = originalColor;

            // giving back the focus
            txtFixedCode.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BugController bugController = new BugController();
            DateTime date = DateTime.Now;
            bool status=bugController.InsertFixedBug(Convert.ToInt32(txtBugId.Text),txtFixedCode.Text,user.Username,date);
            if (status == true)
                MessageBox.Show("fixed bug inserted");
            else
                MessageBox.Show("Something went wrong: unable to insert fixed code in database");

        }
    }
}
