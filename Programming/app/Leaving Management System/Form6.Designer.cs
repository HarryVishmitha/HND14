namespace Leaving_Management_System
{
    partial class leaveReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(leaveReports));
            this.welcomeText = new System.Windows.Forms.Label();
            this.bacK = new System.Windows.Forms.Button();
            this.selectUID = new System.Windows.Forms.ComboBox();
            this.fromD = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toD = new System.Windows.Forms.DateTimePicker();
            this.reports = new System.Windows.Forms.DataGridView();
            this.noMsg = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reports)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.Location = new System.Drawing.Point(309, 47);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(246, 42);
            this.welcomeText.TabIndex = 22;
            this.welcomeText.Text = "Leave Reports";
            // 
            // bacK
            // 
            this.bacK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bacK.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bacK.Location = new System.Drawing.Point(29, 21);
            this.bacK.Name = "bacK";
            this.bacK.Size = new System.Drawing.Size(116, 40);
            this.bacK.TabIndex = 21;
            this.bacK.Text = "Back";
            this.bacK.UseVisualStyleBackColor = true;
            this.bacK.Click += new System.EventHandler(this.bacK_Click);
            // 
            // selectUID
            // 
            this.selectUID.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectUID.FormattingEnabled = true;
            this.selectUID.Location = new System.Drawing.Point(40, 106);
            this.selectUID.Name = "selectUID";
            this.selectUID.Size = new System.Drawing.Size(301, 27);
            this.selectUID.TabIndex = 23;
            this.selectUID.Text = "Select User to get report of specific user";
            this.selectUID.SelectedIndexChanged += new System.EventHandler(this.selectUID_SelectedIndexChanged);
            // 
            // fromD
            // 
            this.fromD.CalendarFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromD.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromD.Location = new System.Drawing.Point(442, 107);
            this.fromD.Name = "fromD";
            this.fromD.Size = new System.Drawing.Size(150, 27);
            this.fromD.TabIndex = 24;
            this.fromD.ValueChanged += new System.EventHandler(this.fromD_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "To";
            // 
            // toD
            // 
            this.toD.CalendarFont = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toD.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toD.Location = new System.Drawing.Point(656, 107);
            this.toD.Name = "toD";
            this.toD.Size = new System.Drawing.Size(150, 27);
            this.toD.TabIndex = 26;
            this.toD.ValueChanged += new System.EventHandler(this.toD_ValueChanged);
            // 
            // reports
            // 
            this.reports.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reports.DefaultCellStyle = dataGridViewCellStyle2;
            this.reports.Location = new System.Drawing.Point(13, 202);
            this.reports.Name = "reports";
            this.reports.ReadOnly = true;
            this.reports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.reports.Size = new System.Drawing.Size(838, 322);
            this.reports.TabIndex = 28;
            // 
            // noMsg
            // 
            this.noMsg.AutoSize = true;
            this.noMsg.BackColor = System.Drawing.Color.White;
            this.noMsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.noMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noMsg.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noMsg.Location = new System.Drawing.Point(303, 289);
            this.noMsg.Name = "noMsg";
            this.noMsg.Size = new System.Drawing.Size(259, 25);
            this.noMsg.TabIndex = 29;
            this.noMsg.Text = "There are nothing to show";
            this.noMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noMsg.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(315, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 38);
            this.button1.TabIndex = 30;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // leaveReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.noMsg);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromD);
            this.Controls.Add(this.selectUID);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.bacK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "leaveReports";
            this.Text = "Leave Reports";
            this.Load += new System.EventHandler(this.leaveReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Button bacK;
        private System.Windows.Forms.ComboBox selectUID;
        private System.Windows.Forms.DateTimePicker fromD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker toD;
        private System.Windows.Forms.DataGridView reports;
        private System.Windows.Forms.Label noMsg;
        private System.Windows.Forms.Button button1;
    }
}