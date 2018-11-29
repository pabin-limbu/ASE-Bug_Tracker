using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bugTracker.view
{
    public partial class StartUp : Form
    {
        public static StartUp startUpInstance;
        public StartUp()
        {
            startUpInstance = this;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
            StartUp.startUpInstance.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegistration regis = new FormRegistration();
            regis.Show();
            startUpInstance.Hide();
        }
    }
}
