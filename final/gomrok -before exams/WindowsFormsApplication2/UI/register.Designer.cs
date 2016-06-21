namespace gomrok
{
    partial class register
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
            this.userName_ = new System.Windows.Forms.TextBox();
            this.password_ = new System.Windows.Forms.TextBox();
            this.registerBtn_ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.org = new System.Windows.Forms.ComboBox();
            this.orgName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userName_
            // 
            this.userName_.Location = new System.Drawing.Point(63, 37);
            this.userName_.Name = "userName_";
            this.userName_.Size = new System.Drawing.Size(100, 20);
            this.userName_.TabIndex = 0;
            // 
            // password_
            // 
            this.password_.Location = new System.Drawing.Point(63, 76);
            this.password_.Name = "password_";
            this.password_.PasswordChar = '*';
            this.password_.Size = new System.Drawing.Size(100, 20);
            this.password_.TabIndex = 1;
            // 
            // registerBtn_
            // 
            this.registerBtn_.Location = new System.Drawing.Point(121, 201);
            this.registerBtn_.Name = "registerBtn_";
            this.registerBtn_.Size = new System.Drawing.Size(75, 23);
            this.registerBtn_.TabIndex = 3;
            this.registerBtn_.Text = "ثبت نام";
            this.registerBtn_.UseVisualStyleBackColor = true;
            this.registerBtn_.Click += new System.EventHandler(this.registerBtn__Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 44);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "نام کاربری";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 83);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "پسورد";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // statusList
            // 
            this.statusList.FormattingEnabled = true;
            this.statusList.Items.AddRange(new object[] {
            "کارشناس گمرک",
            "نماینده سازمان",
            "نماینده وزارت اقتصاد"});
            this.statusList.Location = new System.Drawing.Point(63, 124);
            this.statusList.Name = "statusList";
            this.statusList.Size = new System.Drawing.Size(100, 21);
            this.statusList.TabIndex = 6;
            this.statusList.SelectedIndexChanged += new System.EventHandler(this.statusList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "وضعیت";
            // 
            // org
            // 
            this.org.FormattingEnabled = true;
            this.org.Items.AddRange(new object[] {
            "behdasht",
            "naft",
            "IT",
            "other",
            "ghazadaru",
            "nedaja"});
            this.org.Location = new System.Drawing.Point(63, 164);
            this.org.Name = "org";
            this.org.Size = new System.Drawing.Size(100, 21);
            this.org.TabIndex = 8;
            this.org.Visible = false;
            this.org.SelectedIndexChanged += new System.EventHandler(this.org_SelectedIndexChanged);
            // 
            // orgName
            // 
            this.orgName.AutoSize = true;
            this.orgName.Location = new System.Drawing.Point(211, 172);
            this.orgName.Name = "orgName";
            this.orgName.Size = new System.Drawing.Size(57, 13);
            this.orgName.TabIndex = 9;
            this.orgName.Text = "نام سازمان";
            this.orgName.Visible = false;
            this.orgName.Click += new System.EventHandler(this.label5_Click);
            // 
            // register
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(303, 250);
            this.Controls.Add(this.orgName);
            this.Controls.Add(this.org);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerBtn_);
            this.Controls.Add(this.password_);
            this.Controls.Add(this.userName_);
            this.Name = "register";
            this.Text = "ثبت نام";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label userNameLable;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox userName_;
        private System.Windows.Forms.TextBox password_;
        private System.Windows.Forms.Button registerBtn_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox statusList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox org;
        private System.Windows.Forms.Label orgName;
    }
}