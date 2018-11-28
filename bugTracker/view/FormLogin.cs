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
using System.Threading;
using bugTracker.controller;
using bugTracker.model;
namespace bugTracker.view
{
    public partial class FormLogin : Form
    {
        User user;
        Thread thread;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            this.Dispose();
            thread = new Thread(openRegistrationForm);
            thread.Start();
        }

        private void openRegistrationForm() {
            FormRegistration regForm = new FormRegistration();
            Application.Run(regForm);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserController uController = new UserController();
            user=uController.loginUser(txtUsername.Text,txtPassword.Text);
            if (user != null)
            {
                MessageBox.Show("user found " + user.UserType);
            }
            else if (user == null) {

                MessageBox.Show("no user found");
            }
        }
    }
}
