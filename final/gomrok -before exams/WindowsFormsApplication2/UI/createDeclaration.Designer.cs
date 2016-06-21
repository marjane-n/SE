namespace gomrok
{
    partial class createDeclaration
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
            this.ssn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.goodsList = new System.Windows.Forms.ListBox();
            this.addToGoodBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.totalValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.originCountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.deleteGoodBtn = new System.Windows.Forms.Button();
            this.addDeclareBtn = new System.Windows.Forms.Button();
            this.show_license = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.confirm = new System.Windows.Forms.Button();
            this.ownedLicense = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addToOwnedLicense = new System.Windows.Forms.Button();
            this.confirmOwnedLicense = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ssn
            // 
            this.ssn.Location = new System.Drawing.Point(484, 48);
            this.ssn.Name = "ssn";
            this.ssn.Size = new System.Drawing.Size(100, 20);
            this.ssn.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "شناسه ملی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام خانوادگی ";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(484, 104);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "نام";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(484, 78);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 20);
            this.firstName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(518, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "اطلاعات تاجر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(518, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "لیست کالاها";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goodsList
            // 
            this.goodsList.FormattingEnabled = true;
            this.goodsList.Location = new System.Drawing.Point(455, 167);
            this.goodsList.Name = "goodsList";
            this.goodsList.Size = new System.Drawing.Size(211, 95);
            this.goodsList.TabIndex = 8;
            this.goodsList.SelectedIndexChanged += new System.EventHandler(this.goodsList_SelectedIndexChanged);
            // 
            // addToGoodBtn
            // 
            this.addToGoodBtn.Location = new System.Drawing.Point(534, 281);
            this.addToGoodBtn.Name = "addToGoodBtn";
            this.addToGoodBtn.Size = new System.Drawing.Size(75, 23);
            this.addToGoodBtn.TabIndex = 9;
            this.addToGoodBtn.Text = "افزودن کالا";
            this.addToGoodBtn.UseVisualStyleBackColor = true;
            this.addToGoodBtn.Click += new System.EventHandler(this.addToGoodBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ارزش کل";
            // 
            // totalValue
            // 
            this.totalValue.Location = new System.Drawing.Point(130, 79);
            this.totalValue.Name = "totalValue";
            this.totalValue.Size = new System.Drawing.Size(100, 20);
            this.totalValue.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "کشور مبدا";
            // 
            // originCountry
            // 
            this.originCountry.Location = new System.Drawing.Point(130, 111);
            this.originCountry.Name = "originCountry";
            this.originCountry.Size = new System.Drawing.Size(100, 20);
            this.originCountry.TabIndex = 4;
            this.originCountry.TextChanged += new System.EventHandler(this.originCountry_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "تاریخ اظهارنامه";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "نحوه ی ورود";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(455, 281);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(55, 23);
            this.refreshBtn.TabIndex = 21;
            this.refreshBtn.Text = "رفرش";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "هوایی",
            "زمینی",
            "دریایی"});
            this.comboBox1.Location = new System.Drawing.Point(130, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // deleteGoodBtn
            // 
            this.deleteGoodBtn.Location = new System.Drawing.Point(618, 281);
            this.deleteGoodBtn.Name = "deleteGoodBtn";
            this.deleteGoodBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteGoodBtn.Size = new System.Drawing.Size(48, 23);
            this.deleteGoodBtn.TabIndex = 23;
            this.deleteGoodBtn.Text = "حذف";
            this.deleteGoodBtn.UseVisualStyleBackColor = true;
            this.deleteGoodBtn.Click += new System.EventHandler(this.deleteGoodBtn_Click);
            // 
            // addDeclareBtn
            // 
            this.addDeclareBtn.BackColor = System.Drawing.Color.Gray;
            this.addDeclareBtn.Location = new System.Drawing.Point(42, 239);
            this.addDeclareBtn.Name = "addDeclareBtn";
            this.addDeclareBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addDeclareBtn.Size = new System.Drawing.Size(172, 23);
            this.addDeclareBtn.TabIndex = 24;
            this.addDeclareBtn.Text = "ثبت اظهارنامه";
            this.addDeclareBtn.UseVisualStyleBackColor = false;
            this.addDeclareBtn.Click += new System.EventHandler(this.addDeclareBtn_Click);
            // 
            // show_license
            // 
            this.show_license.BackColor = System.Drawing.Color.Gray;
            this.show_license.Location = new System.Drawing.Point(42, 281);
            this.show_license.Name = "show_license";
            this.show_license.Size = new System.Drawing.Size(172, 23);
            this.show_license.TabIndex = 25;
            this.show_license.Text = "نمایش مجوز های لازم";
            this.show_license.UseVisualStyleBackColor = false;
            this.show_license.Click += new System.EventHandler(this.show_license_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Gray;
            this.confirm.Location = new System.Drawing.Point(42, 202);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(172, 23);
            this.confirm.TabIndex = 27;
            this.confirm.Text = "بررسی و تایید اظهارنامه";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // ownedLicense
            // 
            this.ownedLicense.Location = new System.Drawing.Point(287, 192);
            this.ownedLicense.Multiline = true;
            this.ownedLicense.Name = "ownedLicense";
            this.ownedLicense.Size = new System.Drawing.Size(106, 47);
            this.ownedLicense.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "مجوزهای موجود";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // addToOwnedLicense
            // 
            this.addToOwnedLicense.Location = new System.Drawing.Point(317, 255);
            this.addToOwnedLicense.Name = "addToOwnedLicense";
            this.addToOwnedLicense.Size = new System.Drawing.Size(55, 23);
            this.addToOwnedLicense.TabIndex = 30;
            this.addToOwnedLicense.Text = "افزودن";
            this.addToOwnedLicense.UseVisualStyleBackColor = true;
            this.addToOwnedLicense.Click += new System.EventHandler(this.addToOwnedLicense_Click);
            // 
            // confirmOwnedLicense
            // 
            this.confirmOwnedLicense.Location = new System.Drawing.Point(317, 281);
            this.confirmOwnedLicense.Name = "confirmOwnedLicense";
            this.confirmOwnedLicense.Size = new System.Drawing.Size(55, 23);
            this.confirmOwnedLicense.TabIndex = 31;
            this.confirmOwnedLicense.Text = "تایید";
            this.confirmOwnedLicense.UseVisualStyleBackColor = true;
            this.confirmOwnedLicense.Click += new System.EventHandler(this.confirmOwnedLicense_Click);
            // 
            // createDeclaration
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(707, 336);
            this.Controls.Add(this.confirmOwnedLicense);
            this.Controls.Add(this.addToOwnedLicense);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ownedLicense);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.show_license);
            this.Controls.Add(this.addDeclareBtn);
            this.Controls.Add(this.deleteGoodBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.originCountry);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addToGoodBtn);
            this.Controls.Add(this.goodsList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ssn);
            this.Name = "createDeclaration";
            this.Text = "اظهارنامه";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ssn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox goodsList;
        private System.Windows.Forms.Button addToGoodBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox originCountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button deleteGoodBtn;
        private System.Windows.Forms.Button addDeclareBtn;
        private System.Windows.Forms.Button show_license;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox ownedLicense;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addToOwnedLicense;
        private System.Windows.Forms.Button confirmOwnedLicense;
    }
}