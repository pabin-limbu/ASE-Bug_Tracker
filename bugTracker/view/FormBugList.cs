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
using bugTracker.model;


namespace bugTracker.view
{
    public partial class FormBugList : Form
    {
        User user;
        public FormBugList(User user)
            
        {
            this.user = user;
            InitializeComponent();
        }

        private void myDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormBugList_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Bug_id", typeof(int));
            table.Columns.Add("Name", typeof(String));
            table.Columns.Add("Project", typeof(String));
            table.Columns.Add("Package", typeof(String));
            table.Columns.Add("Class", typeof(String));
            table.Columns.Add("Method", typeof(String));
            table.Columns.Add("Line start", typeof(int));
            table.Columns.Add("Line end", typeof(int));
            table.Columns.Add("Author", typeof(String));
            table.Columns.Add("Fix status", typeof(bool));

            BugController bugController = new BugController();
            List<Bug> allBug = bugController.getAllBug();

            foreach (Bug b in allBug) {
                table.Rows.Add(b.Id, b.BugName, b.ProjectName, b.PackageName, b.ClassName, b.MethodName, b.LineStart, b.LineEnd, b.BugAuthor, b.Status);


            }
            myDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            myDataGrid.MultiSelect = false;
            myDataGrid.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        myDataGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                DataGridViewRow rowIndex = myDataGrid.Rows[myDataGrid.CurrentCell.RowIndex];
                FormFixBug fixBug = new FormFixBug(Convert.ToInt32(rowIndex.Cells["bug_id"].Value),user);
                fixBug.Show();



                

               // label1.Text = "" + myDataGrid.CurrentCell.RowIndex + Convert.ToString(rowIndex.Cells["bug_id"].Value);
            }
            else
                MessageBox.Show("Select a row to fix bug");
            }
        }
}
