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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Keys = OpenQA.Selenium.Keys;

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

        private void btnAddBug_Click(object sender, EventArgs e)
        {
            FormAddBug addBugForm = new FormAddBug(user);
            addBugForm.Show();
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            openGit("changsu.pabin337@gmail.com","48753621g");

        }

        public void openGit(String username,String password) {
            IWebDriver driver = new ChromeDriver();
            driver.Url="https://github.com/login";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("login_field")).SendKeys(username);
            driver.FindElement(By.Id("password")).SendKeys(password+Keys.Enter);
          
            driver.FindElement(By.XPath("//*[@id=\"dashboard\"]/div[1]/div/div[2]/ul/li/div/a")).Click();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBugList bugList = new FormBugList(user);
            bugList.Show();
        }

        private void btnFixedBug_Click(object sender, EventArgs e)
        {
            FormBugAuditHistory auditForm = new FormBugAuditHistory();
            auditForm.Show();
        }
    }
}
