namespace WindowsFormsApplication2.UI
{
    partial class createRules
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
            this.licenseList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rule_max_totalValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_finish = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.addRuleBtn = new System.Windows.Forms.Button();
            this.deleteLicenseBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.refreshBtn_license = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.rule_min_totalValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.originCountry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addLicenseBtn = new System.Windows.Forms.Button();
            this.goodsList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_startDate = new System.Windows.Forms.CheckBox();
            this.checkBox_finishDate = new System.Windows.Forms.CheckBox();
            this.ruleName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.refresh_licenseBtn = new System.Windows.Forms.Button();
            this.add_licenseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // licenseList
            // 
            this.licenseList.FormattingEnabled = true;
            this.licenseList.Location = new System.Drawing.Point(482, 288);
            this.licenseList.Name = "licenseList";
            this.licenseList.Size = new System.Drawing.Size(175, 108);
            this.licenseList.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(480, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 32);
            this.label6.TabIndex = 78;
            this.label6.Text = "مجوزهای مورد نیاز با وضع قانون";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(625, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "بیشینه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "کمینه";
            // 
            // rule_max_totalValue
            // 
            this.rule_max_totalValue.Location = new System.Drawing.Point(503, 193);
            this.rule_max_totalValue.Name = "rule_max_totalValue";
            this.rule_max_totalValue.Size = new System.Drawing.Size(100, 20);
            this.rule_max_totalValue.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "ارزش کل";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "تا(پایان)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "از(شروع)";
            // 
            // dateTimePicker_finish
            // 
            this.dateTimePicker_finish.Enabled = false;
            this.dateTimePicker_finish.Location = new System.Drawing.Point(398, 88);
            this.dateTimePicker_finish.Name = "dateTimePicker_finish";
            this.dateTimePicker_finish.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_finish.TabIndex = 71;
            this.dateTimePicker_finish.ValueChanged += new System.EventHandler(this.dateTimePicker_finish_ValueChanged);
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Enabled = false;
            this.dateTimePicker_start.Location = new System.Drawing.Point(398, 55);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_start.TabIndex = 70;
            this.dateTimePicker_start.ValueChanged += new System.EventHandler(this.dateTimePicker_start_ValueChanged);
            // 
            // addRuleBtn
            // 
            this.addRuleBtn.BackColor = System.Drawing.Color.Gray;
            this.addRuleBtn.Location = new System.Drawing.Point(79, 384);
            this.addRuleBtn.Name = "addRuleBtn";
            this.addRuleBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addRuleBtn.Size = new System.Drawing.Size(172, 41);
            this.addRuleBtn.TabIndex = 69;
            this.addRuleBtn.Text = "ثبت قانون";
            this.addRuleBtn.UseVisualStyleBackColor = false;
            this.addRuleBtn.Click += new System.EventHandler(this.addRuleBtn_Click);
            // 
            // deleteLicenseBtn
            // 
            this.deleteLicenseBtn.Location = new System.Drawing.Point(214, 337);
            this.deleteLicenseBtn.Name = "deleteLicenseBtn";
            this.deleteLicenseBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.deleteLicenseBtn.Size = new System.Drawing.Size(48, 23);
            this.deleteLicenseBtn.TabIndex = 68;
            this.deleteLicenseBtn.Text = "حذف";
            this.deleteLicenseBtn.UseVisualStyleBackColor = true;
            this.deleteLicenseBtn.Click += new System.EventHandler(this.deleteGoodBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "هوایی",
            "زمینی",
            "دریایی"});
            this.comboBox1.Location = new System.Drawing.Point(51, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 60;
            // 
            // refreshBtn_license
            // 
            this.refreshBtn_license.Location = new System.Drawing.Point(51, 337);
            this.refreshBtn_license.Name = "refreshBtn_license";
            this.refreshBtn_license.Size = new System.Drawing.Size(55, 23);
            this.refreshBtn_license.TabIndex = 67;
            this.refreshBtn_license.Text = "رفرش";
            this.refreshBtn_license.UseVisualStyleBackColor = true;
            this.refreshBtn_license.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(183, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "نحوه ی ورود";
            // 
            // rule_min_totalValue
            // 
            this.rule_min_totalValue.Location = new System.Drawing.Point(503, 164);
            this.rule_min_totalValue.Name = "rule_min_totalValue";
            this.rule_min_totalValue.Size = new System.Drawing.Size(100, 20);
            this.rule_min_totalValue.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(197, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "کشور مبدا";
            // 
            // originCountry
            // 
            this.originCountry.Location = new System.Drawing.Point(51, 103);
            this.originCountry.Name = "originCountry";
            this.originCountry.Size = new System.Drawing.Size(100, 20);
            this.originCountry.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(558, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "تاریخ ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addLicenseBtn
            // 
            this.addLicenseBtn.Location = new System.Drawing.Point(130, 337);
            this.addLicenseBtn.Name = "addLicenseBtn";
            this.addLicenseBtn.Size = new System.Drawing.Size(75, 23);
            this.addLicenseBtn.TabIndex = 63;
            this.addLicenseBtn.Text = "افزودن کالا";
            this.addLicenseBtn.UseVisualStyleBackColor = true;
            this.addLicenseBtn.Click += new System.EventHandler(this.addToGoodBtn_Click);
            // 
            // goodsList
            // 
            this.goodsList.FormattingEnabled = true;
            this.goodsList.Location = new System.Drawing.Point(51, 236);
            this.goodsList.Name = "goodsList";
            this.goodsList.Size = new System.Drawing.Size(211, 95);
            this.goodsList.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "لیست کالاها";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox_startDate
            // 
            this.checkBox_startDate.AutoSize = true;
            this.checkBox_startDate.Location = new System.Drawing.Point(677, 58);
            this.checkBox_startDate.Name = "checkBox_startDate";
            this.checkBox_startDate.Size = new System.Drawing.Size(15, 14);
            this.checkBox_startDate.TabIndex = 80;
            this.checkBox_startDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_startDate.UseVisualStyleBackColor = true;
            this.checkBox_startDate.CheckedChanged += new System.EventHandler(this.checkBox_startDate_CheckedChanged);
            // 
            // checkBox_finishDate
            // 
            this.checkBox_finishDate.AutoSize = true;
            this.checkBox_finishDate.Location = new System.Drawing.Point(677, 95);
            this.checkBox_finishDate.Name = "checkBox_finishDate";
            this.checkBox_finishDate.Size = new System.Drawing.Size(15, 14);
            this.checkBox_finishDate.TabIndex = 81;
            this.checkBox_finishDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_finishDate.UseVisualStyleBackColor = true;
            this.checkBox_finishDate.CheckedChanged += new System.EventHandler(this.checkBox_finishDate_CheckedChanged);
            // 
            // ruleName
            // 
            this.ruleName.Location = new System.Drawing.Point(51, 62);
            this.ruleName.Name = "ruleName";
            this.ruleName.Size = new System.Drawing.Size(100, 20);
            this.ruleName.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(201, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 83;
            this.label11.Text = "نام قانون";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 415);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 86;
            this.button1.Text = "حذف";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refresh_licenseBtn
            // 
            this.refresh_licenseBtn.Location = new System.Drawing.Point(465, 415);
            this.refresh_licenseBtn.Name = "refresh_licenseBtn";
            this.refresh_licenseBtn.Size = new System.Drawing.Size(55, 23);
            this.refresh_licenseBtn.TabIndex = 85;
            this.refresh_licenseBtn.Text = "رفرش";
            this.refresh_licenseBtn.UseVisualStyleBackColor = true;
            this.refresh_licenseBtn.Click += new System.EventHandler(this.refresh_licenseBtn_Click);
            // 
            // add_licenseBtn
            // 
            this.add_licenseBtn.Location = new System.Drawing.Point(544, 415);
            this.add_licenseBtn.Name = "add_licenseBtn";
            this.add_licenseBtn.Size = new System.Drawing.Size(75, 23);
            this.add_licenseBtn.TabIndex = 84;
            this.add_licenseBtn.Text = "افزودن مجوز";
            this.add_licenseBtn.UseVisualStyleBackColor = true;
            this.add_licenseBtn.Click += new System.EventHandler(this.addLicenseBtn_Click);
            // 
            // createRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 465);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refresh_licenseBtn);
            this.Controls.Add(this.add_licenseBtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ruleName);
            this.Controls.Add(this.checkBox_finishDate);
            this.Controls.Add(this.checkBox_startDate);
            this.Controls.Add(this.licenseList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rule_max_totalValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_finish);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.addRuleBtn);
            this.Controls.Add(this.deleteLicenseBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.refreshBtn_license);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rule_min_totalValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.originCountry);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addLicenseBtn);
            this.Controls.Add(this.goodsList);
            this.Controls.Add(this.label5);
            this.Name = "createRules";
            this.Text = "افزودن قانون";
            this.Load += new System.EventHandler(this.createRules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox licenseList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rule_max_totalValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_finish;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Button addRuleBtn;
        private System.Windows.Forms.Button deleteLicenseBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button refreshBtn_license;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox rule_min_totalValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox originCountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addLicenseBtn;
        private System.Windows.Forms.ListBox goodsList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_startDate;
        private System.Windows.Forms.CheckBox checkBox_finishDate;
        private System.Windows.Forms.TextBox ruleName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button refresh_licenseBtn;
        private System.Windows.Forms.Button add_licenseBtn;
    }
}