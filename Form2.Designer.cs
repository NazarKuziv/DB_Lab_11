namespace DB_Lab_11
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title_tBox = new System.Windows.Forms.TextBox();
            this.Author_cBox = new System.Windows.Forms.ComboBox();
            this.Add_Author_button = new System.Windows.Forms.Button();
            this.Ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // Title_tBox
            // 
            this.Title_tBox.Location = new System.Drawing.Point(75, 19);
            this.Title_tBox.Name = "Title_tBox";
            this.Title_tBox.Size = new System.Drawing.Size(270, 26);
            this.Title_tBox.TabIndex = 2;
            // 
            // Author_cBox
            // 
            this.Author_cBox.FormattingEnabled = true;
            this.Author_cBox.Location = new System.Drawing.Point(75, 59);
            this.Author_cBox.Name = "Author_cBox";
            this.Author_cBox.Size = new System.Drawing.Size(270, 28);
            this.Author_cBox.TabIndex = 3;
            // 
            // Add_Author_button
            // 
            this.Add_Author_button.Location = new System.Drawing.Point(16, 107);
            this.Add_Author_button.Name = "Add_Author_button";
            this.Add_Author_button.Size = new System.Drawing.Size(329, 28);
            this.Add_Author_button.TabIndex = 4;
            this.Add_Author_button.Text = "Add Author";
            this.Add_Author_button.UseVisualStyleBackColor = true;
            this.Add_Author_button.Click += new System.EventHandler(this.Add_Author_button_Click);
            // 
            // Ok_button
            // 
            this.Ok_button.Location = new System.Drawing.Point(16, 154);
            this.Ok_button.Name = "Ok_button";
            this.Ok_button.Size = new System.Drawing.Size(329, 28);
            this.Ok_button.TabIndex = 5;
            this.Ok_button.Text = "Ok";
            this.Ok_button.UseVisualStyleBackColor = true;
            this.Ok_button.Click += new System.EventHandler(this.Ok_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 211);
            this.Controls.Add(this.Ok_button);
            this.Controls.Add(this.Add_Author_button);
            this.Controls.Add(this.Author_cBox);
            this.Controls.Add(this.Title_tBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Title_tBox;
        private System.Windows.Forms.ComboBox Author_cBox;
        private System.Windows.Forms.Button Add_Author_button;
        private System.Windows.Forms.Button Ok_button;
    }
}