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

namespace bugTracker.view
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserController uController = new UserController();
            uController.adduser("pabin","limbu","limbupabin","lim","abc","admin","male");
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            StartUp.startUpInstance.Show();
            
        }
    }
}
