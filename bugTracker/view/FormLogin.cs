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

namespace bugTracker.view
{
    public partial class FormLogin : Form
    {
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
    }
}
