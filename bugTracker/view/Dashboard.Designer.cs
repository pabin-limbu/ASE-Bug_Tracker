namespace bugTracker.view
{
    partial class Dashboard
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddBug = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnGit = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.lblUserName);
            this.panelTop.Controls.Add(this.lblUserType);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 103);
            this.panelTop.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(19, 75);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(35, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "label2";
            this.lblUserName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(19, 48);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(35, 13);
            this.lblUserType.TabIndex = 1;
            this.lblUserType.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Harrington", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug tracker";
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelBottom.Controls.Add(this.btnGit);
            this.panelBottom.Controls.Add(this.button3);
            this.panelBottom.Controls.Add(this.button2);
            this.panelBottom.Controls.Add(this.btnAddBug);
            this.panelBottom.Controls.Add(this.btnAddProject);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 103);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 347);
            this.panelBottom.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "view bug";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "fix bug";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAddBug
            // 
            this.btnAddBug.Location = new System.Drawing.Point(114, 6);
            this.btnAddBug.Name = "btnAddBug";
            this.btnAddBug.Size = new System.Drawing.Size(75, 23);
            this.btnAddBug.TabIndex = 1;
            this.btnAddBug.Text = "Add bug";
            this.btnAddBug.UseVisualStyleBackColor = true;
            this.btnAddBug.Click += new System.EventHandler(this.btnAddBug_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(23, 6);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(75, 23);
            this.btnAddProject.TabIndex = 0;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnGit
            // 
            this.btnGit.Location = new System.Drawing.Point(405, 6);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(75, 23);
            this.btnGit.TabIndex = 4;
            this.btnGit.Text = "git";
            this.btnGit.UseVisualStyleBackColor = true;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddBug;
        private System.Windows.Forms.Button btnGit;
    }
}