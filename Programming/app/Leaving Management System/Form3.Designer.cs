namespace Leaving_Management_System
{
    partial class FaddNewEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaddNewEmp));
            this.bacK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UId = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.acType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.casualLeaves = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.annualLeaves = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.shortLeaves = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bacK
            // 
            this.bacK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bacK.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bacK.Location = new System.Drawing.Point(24, 24);
            this.bacK.Name = "bacK";
            this.bacK.Size = new System.Drawing.Size(116, 40);
            this.bacK.TabIndex = 3;
            this.bacK.Text = "Back";
            this.bacK.UseVisualStyleBackColor = true;
            this.bacK.Click += new System.EventHandler(this.bacK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "User ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UId
            // 
            this.UId.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UId.Location = new System.Drawing.Point(177, 153);
            this.UId.Name = "UId";
            this.UId.Size = new System.Drawing.Size(150, 27);
            this.UId.TabIndex = 5;
            this.UId.Text = "E";
            this.UId.TextChanged += new System.EventHandler(this.UId_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(177, 282);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 27);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // acType
            // 
            this.acType.DisplayMember = "Admin";
            this.acType.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acType.FormattingEnabled = true;
            this.acType.Items.AddRange(new object[] {
            "admin",
            "employee"});
            this.acType.Location = new System.Drawing.Point(177, 325);
            this.acType.Name = "acType";
            this.acType.Size = new System.Drawing.Size(150, 27);
            this.acType.TabIndex = 7;
            this.acType.Text = "admin";
            this.acType.SelectedIndexChanged += new System.EventHandler(this.acType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(177, 196);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(150, 27);
            this.firstName.TabIndex = 9;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(177, 239);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(150, 27);
            this.lastName.TabIndex = 11;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Joined Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Role";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Short Leaves";
            // 
            // casualLeaves
            // 
            this.casualLeaves.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casualLeaves.Location = new System.Drawing.Point(548, 285);
            this.casualLeaves.Name = "casualLeaves";
            this.casualLeaves.Size = new System.Drawing.Size(150, 27);
            this.casualLeaves.TabIndex = 21;
            this.casualLeaves.Text = "7";
            this.casualLeaves.TextChanged += new System.EventHandler(this.casualLeaves_TextChanged);
            this.casualLeaves.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.casualLeaves_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Casual Leaves";
            // 
            // annualLeaves
            // 
            this.annualLeaves.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualLeaves.Location = new System.Drawing.Point(548, 236);
            this.annualLeaves.Name = "annualLeaves";
            this.annualLeaves.Size = new System.Drawing.Size(150, 27);
            this.annualLeaves.TabIndex = 19;
            this.annualLeaves.Text = "14";
            this.annualLeaves.TextChanged += new System.EventHandler(this.annualLeaves_TextChanged);
            this.annualLeaves.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.annualLeaves_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(387, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Annual Leaves";
            // 
            // salary
            // 
            this.salary.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(548, 193);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(150, 27);
            this.salary.TabIndex = 15;
            this.salary.TextChanged += new System.EventHandler(this.salary_TextChanged);
            this.salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(467, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "Salary";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(195, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 41);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add New Employee";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(433, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 41);
            this.button2.TabIndex = 24;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // shortLeaves
            // 
            this.shortLeaves.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortLeaves.Location = new System.Drawing.Point(548, 334);
            this.shortLeaves.Name = "shortLeaves";
            this.shortLeaves.Size = new System.Drawing.Size(150, 27);
            this.shortLeaves.TabIndex = 25;
            this.shortLeaves.Text = "2";
            this.shortLeaves.TextChanged += new System.EventHandler(this.shortLeaves_TextChanged);
            this.shortLeaves.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.shortLeaves_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "(per month)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(474, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "(per year)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(474, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "(per year)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto Medium", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(235, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(330, 42);
            this.label13.TabIndex = 29;
            this.label13.Text = "Add New Employee";
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(548, 154);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(150, 27);
            this.password.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(430, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 25);
            this.label14.TabIndex = 30;
            this.label14.Text = "Password";
            // 
            // FaddNewEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shortLeaves);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.casualLeaves);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.annualLeaves);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.acType);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.UId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bacK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FaddNewEmp";
            this.Text = "Add new employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bacK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox acType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox casualLeaves;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox annualLeaves;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox shortLeaves;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label14;
    }
}