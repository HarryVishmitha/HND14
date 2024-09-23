namespace Leaving_Management_System
{
    partial class AdminDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDash));
            this.addNewEmp = new System.Windows.Forms.Button();
            this.welcomeText = new System.Windows.Forms.Label();
            this.Reqs = new System.Windows.Forms.Button();
            this.usersT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.todayleaves = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rosterssche = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pendingreqs = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.datetimeshower = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewEmp
            // 
            this.addNewEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewEmp.FlatAppearance.BorderSize = 10;
            this.addNewEmp.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewEmp.Location = new System.Drawing.Point(397, 161);
            this.addNewEmp.Name = "addNewEmp";
            this.addNewEmp.Size = new System.Drawing.Size(154, 50);
            this.addNewEmp.TabIndex = 0;
            this.addNewEmp.Text = "Register a new Employee";
            this.addNewEmp.UseVisualStyleBackColor = true;
            this.addNewEmp.Click += new System.EventHandler(this.addNewEmp_Click);
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.Location = new System.Drawing.Point(284, 36);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(285, 42);
            this.welcomeText.TabIndex = 1;
            this.welcomeText.Text = "WELCOME BACK";
            // 
            // Reqs
            // 
            this.Reqs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reqs.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reqs.Location = new System.Drawing.Point(625, 161);
            this.Reqs.Name = "Reqs";
            this.Reqs.Size = new System.Drawing.Size(154, 50);
            this.Reqs.TabIndex = 2;
            this.Reqs.Text = "Requested Leaves";
            this.Reqs.UseVisualStyleBackColor = true;
            this.Reqs.Click += new System.EventHandler(this.Reqs_Click);
            // 
            // usersT
            // 
            this.usersT.AutoSize = true;
            this.usersT.BackColor = System.Drawing.Color.White;
            this.usersT.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersT.Location = new System.Drawing.Point(202, 161);
            this.usersT.Name = "usersT";
            this.usersT.Padding = new System.Windows.Forms.Padding(5);
            this.usersT.Size = new System.Drawing.Size(28, 29);
            this.usersT.TabIndex = 9;
            this.usersT.Text = "0";
            this.usersT.Click += new System.EventHandler(this.UID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 161);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Users :-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // todayleaves
            // 
            this.todayleaves.AutoSize = true;
            this.todayleaves.BackColor = System.Drawing.Color.White;
            this.todayleaves.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayleaves.Location = new System.Drawing.Point(263, 201);
            this.todayleaves.Name = "todayleaves";
            this.todayleaves.Padding = new System.Windows.Forms.Padding(5);
            this.todayleaves.Size = new System.Drawing.Size(28, 29);
            this.todayleaves.TabIndex = 11;
            this.todayleaves.Text = "0";
            this.todayleaves.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 201);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Today Leave count :-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rosterssche
            // 
            this.rosterssche.AutoSize = true;
            this.rosterssche.BackColor = System.Drawing.Color.White;
            this.rosterssche.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rosterssche.Location = new System.Drawing.Point(263, 244);
            this.rosterssche.Name = "rosterssche";
            this.rosterssche.Padding = new System.Windows.Forms.Padding(5);
            this.rosterssche.Size = new System.Drawing.Size(28, 29);
            this.rosterssche.TabIndex = 13;
            this.rosterssche.Text = "0";
            this.rosterssche.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 244);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(191, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Today Roster count :-";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pendingreqs
            // 
            this.pendingreqs.AutoSize = true;
            this.pendingreqs.BackColor = System.Drawing.Color.White;
            this.pendingreqs.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingreqs.Location = new System.Drawing.Point(252, 284);
            this.pendingreqs.Name = "pendingreqs";
            this.pendingreqs.Padding = new System.Windows.Forms.Padding(5);
            this.pendingreqs.Size = new System.Drawing.Size(28, 29);
            this.pendingreqs.TabIndex = 15;
            this.pendingreqs.Text = "0";
            this.pendingreqs.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 284);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(177, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pending requests :-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(110, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 10;
            this.button2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(397, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 50);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 10;
            this.button3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(625, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 50);
            this.button3.TabIndex = 18;
            this.button3.Text = "Find an Employee";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 10;
            this.button4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(397, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 50);
            this.button4.TabIndex = 19;
            this.button4.Text = "Add Rosters";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // datetimeshower
            // 
            this.datetimeshower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datetimeshower.AutoSize = true;
            this.datetimeshower.BackColor = System.Drawing.Color.White;
            this.datetimeshower.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeshower.Location = new System.Drawing.Point(320, 89);
            this.datetimeshower.Name = "datetimeshower";
            this.datetimeshower.Size = new System.Drawing.Size(213, 25);
            this.datetimeshower.TabIndex = 20;
            this.datetimeshower.Text = "01-05-2024 13:00:00";
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 10;
            this.button5.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(625, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 50);
            this.button5.TabIndex = 21;
            this.button5.Text = "Leave Reports";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 490);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.datetimeshower);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pendingreqs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rosterssche);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.todayleaves);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usersT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reqs);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.addNewEmp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDash";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewEmp;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Button Reqs;
        private System.Windows.Forms.Label usersT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label todayleaves;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rosterssche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pendingreqs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label datetimeshower;
        private System.Windows.Forms.Button button5;
    }
}