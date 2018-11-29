using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bugTracker.view;
using bugTracker.model;

namespace bugTracker.view
{
    public partial class Dashboard : Form
    {
        FormAddProject formAddProject;
        User user;
        public Dashboard(User u)
        {
            this.user = u;
            InitializeComponent();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            formAddProject = new FormAddProject(user);
            formAddProject.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
          
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            StartUp.startUpInstance.Show();

        }
    }
}
