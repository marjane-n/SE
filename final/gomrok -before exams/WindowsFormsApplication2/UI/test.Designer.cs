﻿namespace WindowsFormsApplication2.UI
{
    partial class test
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
            this.test1 = new System.Windows.Forms.Button();
            this.test2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test1
            // 
            this.test1.Location = new System.Drawing.Point(41, 65);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(255, 23);
            this.test1.TabIndex = 0;
            this.test1.Text = "تعیین مجوزهای مورد نیاز یک اظهارنامه";
            this.test1.UseVisualStyleBackColor = true;
            this.test1.Click += new System.EventHandler(this.test1_Click);
            // 
            // test2
            // 
            this.test2.Location = new System.Drawing.Point(41, 125);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(255, 23);
            this.test2.TabIndex = 1;
            this.test2.Text = "کسر از مجوز پس از استفاده در اظهارنامه";
            this.test2.UseVisualStyleBackColor = true;
            this.test2.Click += new System.EventHandler(this.test2_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 203);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test1);
            this.Name = "test";
            this.Text = "آزمون";
            this.Load += new System.EventHandler(this.test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button test1;
        private System.Windows.Forms.Button test2;
    }
}