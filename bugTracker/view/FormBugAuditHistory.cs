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
    public partial class FormBugAuditHistory : Form
    {
        FixedBug fixedBug;
        BugController bugController;
        public FormBugAuditHistory()
        {
            InitializeComponent();
        }

        private void FormBugAuditHistory_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("fixed ID", typeof(int));
            table.Columns.Add("Bug name", typeof(String));
            table.Columns.Add("Fixed by", typeof(String));
            table.Columns.Add("fixed date", typeof(DateTime));



            BugController bugController = new BugController();
            List<FixedBug> allFixedBug = bugController.getAllFixedBug();

            foreach (FixedBug b in allFixedBug)
            {
                table.Rows.Add(b.FixedBugId, b.BugName, b.BugFixedBy, b.FixedDate);


            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.DataSource = table;
        }

        private void btnViewFixedBug_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
       dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                DataGridViewRow rowIndex = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
                //   FormFixBug fixBug = new FormFixBug(Convert.ToInt32(rowIndex.Cells["bug_id"].Value), user);
                ///  fixBug.Show();
                bugController = new BugController();
                fixedBug = bugController.getFixedBugById((Convert.ToInt32(rowIndex.Cells["fixed ID"].Value)));
                FormViewFixedBug viewFixedBug = new FormViewFixedBug(fixedBug);
                viewFixedBug.Show();




                // label1.Text = "" + myDataGrid.CurrentCell.RowIndex + Convert.ToString(rowIndex.Cells["bug_id"].Value);
            }
            else
                MessageBox.Show("Select a row to fix bug");
        }
    }
}

