namespace bugTracker.view
{
    partial class FormViewFixedBug
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
            this.txtOriginal = new System.Windows.Forms.RichTextBox();
            this.txtFixed = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(27, 42);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(257, 386);
            this.txtOriginal.TabIndex = 0;
            this.txtOriginal.Text = "";
            this.txtOriginal.TextChanged += new System.EventHandler(this.txtOriginal_TextChanged);
            // 
            // txtFixed
            // 
            this.txtFixed.Location = new System.Drawing.Point(321, 41);
            this.txtFixed.Name = "txtFixed";
            this.txtFixed.Size = new System.Drawing.Size(260, 386);
            this.txtFixed.TabIndex = 1;
            this.txtFixed.Text = "";
            this.txtFixed.TextChanged += new System.EventHandler(this.txtFixed_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fixed";
            // 
            // FormViewFixedBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFixed);
            this.Controls.Add(this.txtOriginal);
            this.Name = "FormViewFixedBug";
            this.Text = "FormViewFixedBug";
            this.Load += new System.EventHandler(this.FormViewFixedBug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtOriginal;
        private System.Windows.Forms.RichTextBox txtFixed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}