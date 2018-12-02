namespace bugTracker.view
{
    partial class FormRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupGen = new System.Windows.Forms.GroupBox();
            this.groupGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Location = new System.Drawing.Point(88, 42);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(35, 13);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "label1";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(88, 80);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(55, 13);
            this.lblFname.TabIndex = 1;
            this.lblFname.Text = "First name";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(150, 80);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(214, 20);
            this.txtFname.TabIndex = 2;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(88, 106);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(56, 13);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Last name";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(150, 106);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(214, 20);
            this.txtLname.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(88, 140);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(150, 140);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(214, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(88, 173);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(150, 166);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(214, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(88, 205);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 198);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(88, 237);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(56, 13);
            this.lblUserType.TabIndex = 1;
            this.lblUserType.Text = "User Type";
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Items.AddRange(new object[] {
            "Client",
            "Programmer",
            "Tester"});
            this.cboUser.Location = new System.Drawing.Point(150, 236);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(214, 21);
            this.cboUser.TabIndex = 3;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(86, 19);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 4;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(188, 19);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 4;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 334);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(279, 335);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "cancle";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // groupGen
            // 
            this.groupGen.Controls.Add(this.rdoMale);
            this.groupGen.Controls.Add(this.rdoFemale);
            this.groupGen.Location = new System.Drawing.Point(82, 267);
            this.groupGen.Name = "groupGen";
            this.groupGen.Size = new System.Drawing.Size(273, 57);
            this.groupGen.TabIndex = 6;
            this.groupGen.TabStop = false;
            this.groupGen.Text = "Gender";
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.groupGen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblLogo);
            this.Name = "FormRegistration";
            this.Text = "FormRegistration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.groupGen.ResumeLayout(false);
            this.groupGen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupGen;
    }
}