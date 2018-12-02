using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bugTracker.model;
using System.Text.RegularExpressions;

namespace bugTracker.view
{
    public partial class FormViewFixedBug : Form
    {
        FixedBug fixedBug;
        
        public FormViewFixedBug(FixedBug fixedBug)
        {
            this.fixedBug    = fixedBug;
            InitializeComponent();
        }

        private void FormViewFixedBug_Load(object sender, EventArgs e)
        {
            txtOriginal.Text = fixedBug.CodeBlock;
            txtFixed.Text = fixedBug.FixedCode;



        }

        private void txtOriginal_TextChanged(object sender, EventArgs e)
        {
            // getting keywords/functions
            string keywords = @"\b(public|private|partial|static|namespace|class|using|foreach|in|String|int|Integer|void)\b";
            MatchCollection keywordMatches = Regex.Matches(txtOriginal.Text, keywords);

            // getting types/classes from the text 
            string types = @"\b(Console)\b";
            MatchCollection typeMatches = Regex.Matches(txtOriginal.Text, types);

            // getting comments (inline or multiline)
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(txtOriginal.Text, comments, RegexOptions.Multiline);

            // getting strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(txtOriginal.Text, strings);

            // saving the original caret position + forecolor
            int originalIndex = txtOriginal.SelectionStart;
            int originalLength = txtOriginal.SelectionLength;
            Color originalColor = Color.Black;

            // MANDATORY - focuses a label before highlighting (avoids blinking)
            // titleLabel.Focus();

            // removes any previous highlighting (so modified words won't remain highlighted)
            txtOriginal.SelectionStart = 0;
            txtOriginal.SelectionLength = txtOriginal.Text.Length;
            txtOriginal.SelectionColor = originalColor;

            // scanning...
            foreach (Match m in keywordMatches)
            {
                txtOriginal.SelectionStart = m.Index;
                txtOriginal.SelectionLength = m.Length;
                txtOriginal.SelectionColor = Color.Blue;
            }

            foreach (Match m in typeMatches)
            {
                txtOriginal.SelectionStart = m.Index;
                txtOriginal.SelectionLength = m.Length;
                txtOriginal.SelectionColor = Color.DarkCyan;
            }

            foreach (Match m in commentMatches)
            {
                txtOriginal.SelectionStart = m.Index;
                txtOriginal.SelectionLength = m.Length;
                txtOriginal.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches)
            {
                txtOriginal.SelectionStart = m.Index;
                txtOriginal.SelectionLength = m.Length;
                txtOriginal.SelectionColor = Color.Brown;
            }

            // restoring the original colors, for further writing
            txtOriginal.SelectionStart = originalIndex;
            txtOriginal.SelectionLength = originalLength;
            txtOriginal.SelectionColor = originalColor;

            // giving back the focus
            txtOriginal.Focus();
        }

        private void txtFixed_TextChanged(object sender, EventArgs e)
        {
            // getting keywords/functions
            string keywords = @"\b(public|private|partial|static|namespace|class|using|foreach|in|String|int|Integer|void)\b";
            MatchCollection keywordMatches = Regex.Matches(txtFixed.Text, keywords);

            // getting types/classes from the text 
            string types = @"\b(Console)\b";
            MatchCollection typeMatches = Regex.Matches(txtFixed.Text, types);

            // getting comments (inline or multiline)
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(txtFixed.Text, comments, RegexOptions.Multiline);

            // getting strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(txtFixed.Text, strings);

            // saving the original caret position + forecolor
            int originalIndex = txtFixed.SelectionStart;
            int originalLength = txtFixed.SelectionLength;
            Color originalColor = Color.Black;

            // MANDATORY - focuses a label before highlighting (avoids blinking)
            // titleLabel.Focus();

            // removes any previous highlighting (so modified words won't remain highlighted)
            txtFixed.SelectionStart = 0;
            txtFixed.SelectionLength = txtFixed.Text.Length;
            txtFixed.SelectionColor = originalColor;

            // scanning...
            foreach (Match m in keywordMatches)
            {
                txtFixed.SelectionStart = m.Index;
                txtFixed.SelectionLength = m.Length;
                txtFixed.SelectionColor = Color.Blue;
            }

            foreach (Match m in typeMatches)
            {
                txtFixed.SelectionStart = m.Index;
                txtFixed.SelectionLength = m.Length;
                txtFixed.SelectionColor = Color.DarkCyan;
            }

            foreach (Match m in commentMatches)
            {
                txtFixed.SelectionStart = m.Index;
                txtFixed.SelectionLength = m.Length;
                txtFixed.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches)
            {
                txtFixed.SelectionStart = m.Index;
                txtFixed.SelectionLength = m.Length;
                txtFixed.SelectionColor = Color.Brown;
            }

            // restoring the original colors, for further writing
            txtFixed.SelectionStart = originalIndex;
            txtFixed.SelectionLength = originalLength;
            txtFixed.SelectionColor = originalColor;

            // giving back the focus
            txtFixed.Focus();
        }
    }
}
