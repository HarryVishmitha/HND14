namespace Employee_Application
{
    partial class empDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.remainingLeaves = new System.Windows.Forms.Label();
            this.rosters = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rosters)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leaving Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "!!! YOU CANNOT GET LEAVES DURING YOUR ROSTER HOURS!!!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(251, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply new leave";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(453, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Check Application Status";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "You\'ve remaining Leaves";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // remainingLeaves
            // 
            this.remainingLeaves.AutoSize = true;
            this.remainingLeaves.BackColor = System.Drawing.Color.White;
            this.remainingLeaves.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingLeaves.ForeColor = System.Drawing.Color.Black;
            this.remainingLeaves.Location = new System.Drawing.Point(23, 254);
            this.remainingLeaves.Name = "remainingLeaves";
            this.remainingLeaves.Padding = new System.Windows.Forms.Padding(25, 0, 20, 20);
            this.remainingLeaves.Size = new System.Drawing.Size(241, 96);
            this.remainingLeaves.TabIndex = 6;
            this.remainingLeaves.Text = "\r\nAnnual Leaves 0 out of 14 &\r\nCasual Leaves 0 out of 7 &\r\nShort Leaves 0 out of " +
    "2";
            this.remainingLeaves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remainingLeaves.Click += new System.EventHandler(this.remainingLeaves_Click);
            // 
            // rosters
            // 
            this.rosters.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rosters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rosters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rosters.DefaultCellStyle = dataGridViewCellStyle2;
            this.rosters.Location = new System.Drawing.Point(360, 254);
            this.rosters.Name = "rosters";
            this.rosters.ReadOnly = true;
            this.rosters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.rosters.Size = new System.Drawing.Size(461, 244);
            this.rosters.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Your Roster hours";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.White;
            this.labelMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMessage.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(365, 268);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(456, 25);
            this.labelMessage.TabIndex = 20;
            this.labelMessage.Text = "Currently you don\'t have any scheduled rosters";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMessage.Visible = false;
            // 
            // empDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 510);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rosters);
            this.Controls.Add(this.remainingLeaves);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "empDashboard";
            this.Text = "Employee Dashboard";
            this.Load += new System.EventHandler(this.empDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rosters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label remainingLeaves;
        private System.Windows.Forms.DataGridView rosters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMessage;
    }
}