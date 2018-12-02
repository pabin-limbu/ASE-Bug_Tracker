namespace bugTracker.view
{
    partial class FormFixBug
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFixedCode = new System.Windows.Forms.RichTextBox();
            this.txtPreviousCode = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBugId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBugName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFixedCode);
            this.panel1.Controls.Add(this.txtPreviousCode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtProjectName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtClassName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtMethodName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPackageName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBugId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBugName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 582);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(459, 547);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(571, 547);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(13, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fixed code";
            // 
            // txtFixedCode
            // 
            this.txtFixedCode.Location = new System.Drawing.Point(80, 370);
            this.txtFixedCode.Name = "txtFixedCode";
            this.txtFixedCode.Size = new System.Drawing.Size(597, 166);
            this.txtFixedCode.TabIndex = 4;
            this.txtFixedCode.Text = "";
            this.txtFixedCode.TextChanged += new System.EventHandler(this.txtFixedCode_TextChanged_1);
            // 
            // txtPreviousCode
            // 
            this.txtPreviousCode.Location = new System.Drawing.Point(80, 186);
            this.txtPreviousCode.Name = "txtPreviousCode";
            this.txtPreviousCode.Size = new System.Drawing.Size(302, 166);
            this.txtPreviousCode.TabIndex = 4;
            this.txtPreviousCode.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(398, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Code Snip Shot";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(397, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 314);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(80, 64);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(302, 20);
            this.txtProjectName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Project";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(80, 116);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(302, 20);
            this.txtClassName.TabIndex = 1;
            this.txtClassName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Class";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(80, 142);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(302, 20);
            this.txtMethodName.TabIndex = 1;
            this.txtMethodName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Method";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(80, 90);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(302, 20);
            this.txtPackageName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Package";
            // 
            // txtBugId
            // 
            this.txtBugId.Location = new System.Drawing.Point(80, 11);
            this.txtBugId.Name = "txtBugId";
            this.txtBugId.Size = new System.Drawing.Size(302, 20);
            this.txtBugId.TabIndex = 1;
            this.txtBugId.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bug id";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBugName
            // 
            this.txtBugName.Location = new System.Drawing.Point(80, 38);
            this.txtBugName.Name = "txtBugName";
            this.txtBugName.Size = new System.Drawing.Size(302, 20);
            this.txtBugName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug name";
            // 
            // FormFixBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 582);
            this.Controls.Add(this.panel1);
            this.Name = "FormFixBug";
            this.Text = "FormFixBug";
            this.Load += new System.EventHandler(this.FormFixBug_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtFixedCode;
        private System.Windows.Forms.RichTextBox txtPreviousCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBugId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBugName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label8;
    }
}