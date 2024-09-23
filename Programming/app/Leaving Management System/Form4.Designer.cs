namespace Leaving_Management_System
{
    partial class reqLeaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reqLeaves));
            this.bacK = new System.Windows.Forms.Button();
            this.rstatusleave = new System.Windows.Forms.DataGridView();
            this.welcomeText = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rstatusleave)).BeginInit();
            this.SuspendLayout();
            // 
            // bacK
            // 
            this.bacK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bacK.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bacK.Location = new System.Drawing.Point(12, 12);
            this.bacK.Name = "bacK";
            this.bacK.Size = new System.Drawing.Size(116, 40);
            this.bacK.TabIndex = 4;
            this.bacK.Text = "Back";
            this.bacK.UseVisualStyleBackColor = true;
            this.bacK.Click += new System.EventHandler(this.bacK_Click);
            // 
            // rstatusleave
            // 
            this.rstatusleave.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rstatusleave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rstatusleave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rstatusleave.DefaultCellStyle = dataGridViewCellStyle2;
            this.rstatusleave.Location = new System.Drawing.Point(12, 115);
            this.rstatusleave.Name = "rstatusleave";
            this.rstatusleave.ReadOnly = true;
            this.rstatusleave.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.rstatusleave.Size = new System.Drawing.Size(776, 313);
            this.rstatusleave.TabIndex = 18;
            // 
            // welcomeText
            // 
            this.welcomeText.AutoSize = true;
            this.welcomeText.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeText.Location = new System.Drawing.Point(258, 36);
            this.welcomeText.Name = "welcomeText";
            this.welcomeText.Size = new System.Drawing.Size(308, 42);
            this.welcomeText.TabIndex = 19;
            this.welcomeText.Text = "Requested Leaves";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.White;
            this.labelMessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMessage.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(205, 202);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(391, 25);
            this.labelMessage.TabIndex = 21;
            this.labelMessage.Text = "Currently there are no requested leaves.";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMessage.Visible = false;
            // 
            // reqLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.welcomeText);
            this.Controls.Add(this.rstatusleave);
            this.Controls.Add(this.bacK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reqLeaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requested Leaves";
            this.Load += new System.EventHandler(this.reqLeaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rstatusleave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bacK;
        private System.Windows.Forms.DataGridView rstatusleave;
        private System.Windows.Forms.Label welcomeText;
        private System.Windows.Forms.Label labelMessage;
    }
}