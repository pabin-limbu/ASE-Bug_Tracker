using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using bugTracker.controller;
using bugTracker.model;
using System.Text.RegularExpressions;


namespace bugTracker.view
{
    public partial class FormAddBug : Form
    {
        User user;
        BugController bugController;
        ProjectController projectController;
        Project project;
        public FormAddBug(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

                private void btnImage_Click(object sender, EventArgs e)
        {
            try
            {

                
                myOpenFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                if (myOpenFileDialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {
                    txtImagePath.Text = myOpenFileDialog.FileName;
                    pictureBox1.ImageLocation = myOpenFileDialog.FileName;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("big big big" + ex.Message);
            }

        }
        //method to convert Imag into byte[] which is used to save image information in database as BLOB type. 
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bugController = new BugController();
            DateTime date = new DateTime();
            date = DateTime.Now;
            project = (Project)cboProject.SelectedItem; 
            bool status = bugController.addBug(txtBugName.Text, project.Id,txtPackage.Text, txtClass.Text, txtMethod.Text, Convert.ToInt32(txtLineFrom.Text), Convert.ToInt32
                (txtLineTo.Text), txtCode.Text, imageToByteArray(pictureBox1.Image), date, false,user.Id);

            if (status) { MessageBox.Show("Bug Information added");this.Dispose(); }
        
                    }

        private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAddBug_Load(object sender, EventArgs e)
        {
            List<Project> allProject;
            projectController = new ProjectController();
            allProject = projectController.getAllProject();

            foreach (Project p in allProject) {
                cboProject.DisplayMember = p.Title;
                   cboProject.Items.Add(p);
     
            }

        
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            // getting keywords/functions
            string keywords = @"\b(public|private|partial|static|namespace|class|using|foreach|in|String|int|Integer|void)\b";
            MatchCollection keywordMatches = Regex.Matches(txtCode.Text, keywords);

            // getting types/classes from the text 
            string types = @"\b(Console)\b";
            MatchCollection typeMatches = Regex.Matches(txtCode.Text, types);

            // getting comments (inline or multiline)
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(txtCode.Text, comments, RegexOptions.Multiline);

            // getting strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(txtCode.Text, strings);

            // saving the original caret position + forecolor
            int originalIndex = txtCode.SelectionStart;
            int originalLength = txtCode.SelectionLength;
            Color originalColor = Color.Black;

            // MANDATORY - focuses a label before highlighting (avoids blinking)
            // titleLabel.Focus();

            // removes any previous highlighting (so modified words won't remain highlighted)
            txtCode.SelectionStart = 0;
            txtCode.SelectionLength = txtCode.Text.Length;
            txtCode.SelectionColor = originalColor;

            // scanning...
            foreach (Match m in keywordMatches)
            {
                txtCode.SelectionStart = m.Index;
                txtCode.SelectionLength = m.Length;
                txtCode.SelectionColor = Color.Blue;
            }

            foreach (Match m in typeMatches)
            {
                txtCode.SelectionStart = m.Index;
                txtCode.SelectionLength = m.Length;
                txtCode.SelectionColor = Color.DarkCyan;
            }

            foreach (Match m in commentMatches)
            {
                txtCode.SelectionStart = m.Index;
                txtCode.SelectionLength = m.Length;
                txtCode.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches)
            {
                txtCode.SelectionStart = m.Index;
                txtCode.SelectionLength = m.Length;
                txtCode.SelectionColor = Color.Brown;
            }

            // restoring the original colors, for further writing
            txtCode.SelectionStart = originalIndex;
            txtCode.SelectionLength = originalLength;
            txtCode.SelectionColor = originalColor;

            // giving back the focus
            txtCode.Focus();
        }
    }
}
