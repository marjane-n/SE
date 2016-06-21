namespace WindowsFormsApplication2.UI
{
    partial class addLicenses_to_rule
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
            this.licenseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addLicense = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.orgName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // licenseName
            // 
            this.licenseName.Location = new System.Drawing.Point(92, 35);
            this.licenseName.Name = "licenseName";
            this.licenseName.Size = new System.Drawing.Size(167, 20);
            this.licenseName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "نام مجوز";
            // 
            // addLicense
            // 
            this.addLicense.Location = new System.Drawing.Point(177, 130);
            this.addLicense.Name = "addLicense";
            this.addLicense.Size = new System.Drawing.Size(82, 27);
            this.addLicense.TabIndex = 61;
            this.addLicense.Text = "افزودن";
            this.addLicense.UseVisualStyleBackColor = true;
            this.addLicense.Click += new System.EventHandler(this.addLicense_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "نام سازمان";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // orgName
            // 
            this.orgName.Location = new System.Drawing.Point(92, 73);
            this.orgName.Name = "orgName";
            this.orgName.Size = new System.Drawing.Size(167, 20);
            this.orgName.TabIndex = 63;
            this.orgName.TextChanged += new System.EventHandler(this.orgName_TextChanged);
            // 
            // addLicenses_to_rule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 178);
            this.Controls.Add(this.orgName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.licenseName);
            this.Name = "addLicenses_to_rule";
            this.Text = "افزودن مجوز مورد نیاز به قانون";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox licenseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orgName;
    }
}