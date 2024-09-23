namespace Employee_Application
{
    partial class ApplyLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyLeave));
            this.label1 = new System.Windows.Forms.Label();
            this.leaveType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lreason = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leaveDate = new System.Windows.Forms.DateTimePicker();
            this.LstartTime = new System.Windows.Forms.DateTimePicker();
            this.LendTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.requestLeave = new System.Windows.Forms.Button();
            this.bacK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apply for a leave";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // leaveType
            // 
            this.leaveType.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveType.FormattingEnabled = true;
            this.leaveType.Items.AddRange(new object[] {
            "Annual Leave",
            "Casual Leave",
            "Short Leave"});
            this.leaveType.Location = new System.Drawing.Point(207, 103);
            this.leaveType.Name = "leaveType";
            this.leaveType.Size = new System.Drawing.Size(151, 27);
            this.leaveType.TabIndex = 3;
            this.leaveType.SelectedIndexChanged += new System.EventHandler(this.leaveType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leave Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Lreason
            // 
            this.Lreason.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lreason.Location = new System.Drawing.Point(207, 307);
            this.Lreason.Name = "Lreason";
            this.Lreason.Size = new System.Drawing.Size(309, 113);
            this.Lreason.TabIndex = 6;
            this.Lreason.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Why you get a leave";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // leaveDate
            // 
            this.leaveDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.leaveDate.Location = new System.Drawing.Point(207, 155);
            this.leaveDate.Name = "leaveDate";
            this.leaveDate.Size = new System.Drawing.Size(272, 27);
            this.leaveDate.TabIndex = 8;
            // 
            // LstartTime
            // 
            this.LstartTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.LstartTime.Location = new System.Drawing.Point(207, 212);
            this.LstartTime.Name = "LstartTime";
            this.LstartTime.Size = new System.Drawing.Size(272, 27);
            this.LstartTime.TabIndex = 9;
            // 
            // LendTime
            // 
            this.LendTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LendTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.LendTime.Location = new System.Drawing.Point(207, 261);
            this.LendTime.Name = "LendTime";
            this.LendTime.Size = new System.Drawing.Size(272, 27);
            this.LendTime.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Start Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "End Time";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // requestLeave
            // 
            this.requestLeave.BackColor = System.Drawing.Color.Blue;
            this.requestLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestLeave.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLeave.ForeColor = System.Drawing.Color.White;
            this.requestLeave.Location = new System.Drawing.Point(554, 106);
            this.requestLeave.Name = "requestLeave";
            this.requestLeave.Size = new System.Drawing.Size(189, 40);
            this.requestLeave.TabIndex = 13;
            this.requestLeave.Text = "Submit";
            this.requestLeave.UseVisualStyleBackColor = false;
            this.requestLeave.Click += new System.EventHandler(this.requestLeave_Click);
            // 
            // bacK
            // 
            this.bacK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bacK.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bacK.Location = new System.Drawing.Point(27, 23);
            this.bacK.Name = "bacK";
            this.bacK.Size = new System.Drawing.Size(116, 40);
            this.bacK.TabIndex = 14;
            this.bacK.Text = "Back";
            this.bacK.UseVisualStyleBackColor = true;
            this.bacK.Click += new System.EventHandler(this.bacK_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(590, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApplyLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bacK);
            this.Controls.Add(this.requestLeave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LendTime);
            this.Controls.Add(this.LstartTime);
            this.Controls.Add(this.leaveDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lreason);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.leaveType);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplyLeave";
            this.Text = "Apply for a new leave";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox leaveType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox Lreason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker LstartTime;
        private System.Windows.Forms.DateTimePicker LendTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button requestLeave;
        private System.Windows.Forms.Button bacK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker leaveDate;
    }
}