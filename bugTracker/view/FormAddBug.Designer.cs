namespace bugTracker.view
{
    partial class FormAddBug
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtLineTo = new System.Windows.Forms.TextBox();
            this.lblLineto = new System.Windows.Forms.Label();
            this.txtLineFrom = new System.Windows.Forms.TextBox();
            this.lblLineFrom = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.lbllblPackage = new System.Windows.Forms.Label();
            this.txtBugName = new System.Windows.Forms.TextBox();
            this.lblBugName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.myOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.btnImage);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cboProject);
            this.panel1.Controls.Add(this.lblProject);
            this.panel1.Controls.Add(this.txtLineTo);
            this.panel1.Controls.Add(this.lblLineto);
            this.panel1.Controls.Add(this.txtLineFrom);
            this.panel1.Controls.Add(this.lblLineFrom);
            this.panel1.Controls.Add(this.lblCode);
            this.panel1.Controls.Add(this.txtImagePath);
            this.panel1.Controls.Add(this.txtMethod);
            this.panel1.Controls.Add(this.lblMethod);
            this.panel1.Controls.Add(this.txtClass);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Controls.Add(this.txtPackage);
            this.panel1.Controls.Add(this.lbllblPackage);
            this.panel1.Controls.Add(this.txtBugName);
            this.panel1.Controls.Add(this.lblBugName);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 507);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(287, 272);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(55, 23);
            this.btnImage.TabIndex = 9;
            this.btnImage.Text = "Upload Snipset";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(348, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(450, 481);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(287, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cboProject
            // 
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(78, 88);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(194, 21);
            this.cboProject.TabIndex = 4;
            this.cboProject.SelectedIndexChanged += new System.EventHandler(this.cboProject_SelectedIndexChanged);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(3, 88);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(39, 13);
            this.lblProject.TabIndex = 3;
            this.lblProject.Text = "project";
            // 
            // txtLineTo
            // 
            this.txtLineTo.Location = new System.Drawing.Point(216, 238);
            this.txtLineTo.Name = "txtLineTo";
            this.txtLineTo.Size = new System.Drawing.Size(56, 20);
            this.txtLineTo.TabIndex = 2;
            // 
            // lblLineto
            // 
            this.lblLineto.AutoSize = true;
            this.lblLineto.Location = new System.Drawing.Point(165, 241);
            this.lblLineto.Name = "lblLineto";
            this.lblLineto.Size = new System.Drawing.Size(44, 13);
            this.lblLineto.TabIndex = 1;
            this.lblLineto.Text = "line end";
            // 
            // txtLineFrom
            // 
            this.txtLineFrom.Location = new System.Drawing.Point(78, 238);
            this.txtLineFrom.Name = "txtLineFrom";
            this.txtLineFrom.Size = new System.Drawing.Size(70, 20);
            this.txtLineFrom.TabIndex = 2;
            // 
            // lblLineFrom
            // 
            this.lblLineFrom.AutoSize = true;
            this.lblLineFrom.Location = new System.Drawing.Point(3, 238);
            this.lblLineFrom.Name = "lblLineFrom";
            this.lblLineFrom.Size = new System.Drawing.Size(46, 13);
            this.lblLineFrom.TabIndex = 1;
            this.lblLineFrom.Text = "line start";
            this.lblLineFrom.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(3, 298);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(61, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code block";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(348, 272);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(175, 20);
            this.txtImagePath.TabIndex = 2;
            this.txtImagePath.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(78, 199);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(194, 20);
            this.txtMethod.TabIndex = 2;
            this.txtMethod.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(3, 196);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(42, 13);
            this.lblMethod.TabIndex = 1;
            this.lblMethod.Text = "method";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(78, 161);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(194, 20);
            this.txtClass.TabIndex = 2;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(3, 158);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(31, 13);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "class";
            // 
            // txtPackage
            // 
            this.txtPackage.Location = new System.Drawing.Point(78, 125);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(194, 20);
            this.txtPackage.TabIndex = 2;
            // 
            // lbllblPackage
            // 
            this.lbllblPackage.AutoSize = true;
            this.lbllblPackage.Location = new System.Drawing.Point(3, 122);
            this.lbllblPackage.Name = "lbllblPackage";
            this.lbllblPackage.Size = new System.Drawing.Size(49, 13);
            this.lbllblPackage.TabIndex = 1;
            this.lbllblPackage.Text = "package";
            // 
            // txtBugName
            // 
            this.txtBugName.Location = new System.Drawing.Point(78, 58);
            this.txtBugName.Name = "txtBugName";
            this.txtBugName.Size = new System.Drawing.Size(194, 20);
            this.txtBugName.TabIndex = 2;
            // 
            // lblBugName
            // 
            this.lblBugName.AutoSize = true;
            this.lblBugName.Location = new System.Drawing.Point(3, 55);
            this.lblBugName.Name = "lblBugName";
            this.lblBugName.Size = new System.Drawing.Size(45, 13);
            this.lblBugName.TabIndex = 1;
            this.lblBugName.Text = "Bug title";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 29);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "label2";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(3, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "label1";
            // 
            // myOpenFileDialog
            // 
            this.myOpenFileDialog.FileName = "openFileDialog1";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(12, 327);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(448, 148);
            this.txtCode.TabIndex = 10;
            this.txtCode.Text = "";
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // FormAddBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 507);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddBug";
            this.Text = "FormAddBug";
            this.Load += new System.EventHandler(this.FormAddBug_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtLineTo;
        private System.Windows.Forms.Label lblLineto;
        private System.Windows.Forms.TextBox txtLineFrom;
        private System.Windows.Forms.Label lblLineFrom;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.Label lbllblPackage;
        private System.Windows.Forms.TextBox txtBugName;
        private System.Windows.Forms.Label lblBugName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.OpenFileDialog myOpenFileDialog;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.RichTextBox txtCode;
    }
}