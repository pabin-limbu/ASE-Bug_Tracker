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
    public partial class FormAddProject : Form
    {
        User user;
        ProjectController projectController;
        public FormAddProject(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            projectController = new ProjectController();
            //     DateTime temp = DateTime.Parse(dtStart.Text);
            //    Console.WriteLine(temp.ToString("yyyy-MM-dd"));
            //   Console.Read();
            //    System.Environment.Exit(1);
            bool status = projectController.addProject(txtTitle.Text, DateTime.Parse(dtStart.Text), DateTime.Parse(dtEnd.Text), areaDescription.Text, user.Id);
            if (status)
                MessageBox.Show("success");
            else
                MessageBox.Show("fail");
        }
    }
}
