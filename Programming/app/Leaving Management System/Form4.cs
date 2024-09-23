using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leaving_Management_System
{
    public partial class reqLeaves : Form
    {
        String connectionString = "Data Source=DESKTOP-8PVTG63;Initial Catalog=LeaMS;Integrated Security=True";

        public reqLeaves()
        {
            InitializeComponent();
            rstatusleave.CellClick += new DataGridViewCellEventHandler(rstatusleave_CellClick);
        }

        private void bacK_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDash adminDash = new AdminDash();
            adminDash.Show();
        }

        private void reqLeaves_Load(object sender, EventArgs e)
        {
            string pendingquery = "SELECT * FROM RLLeaves WHERE Status='pending'";
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand(pendingquery, conn))
                {
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        // Add action button column
                        DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
                        viewButtonColumn.HeaderText = "Action";
                        viewButtonColumn.Text = "View";
                        viewButtonColumn.UseColumnTextForButtonValue = true;
                        viewButtonColumn.Name = "btnViewLeave";
                        rstatusleave.Columns.Add(viewButtonColumn);
                        rstatusleave.DataSource = dt;
                        // Adjust column width based on content
                        rstatusleave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        // Adjust row height based on content
                        rstatusleave.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        // Enable text wrapping for cells
                        rstatusleave.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                        // Adjust header size if needed
                        rstatusleave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                        labelMessage.Visible = false;
                        rstatusleave.Visible = true;
                    }
                    else
                    {
                        labelMessage.Visible = true;
                        rstatusleave.Visible = false;
                    }
                }
            }
        }
        private void rstatusleave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click was on the button column
            if (e.ColumnIndex == rstatusleave.Columns["btnViewLeave"].Index && e.RowIndex >= 0)
            {
                // Get the LeaveID or any other identifying value from the selected row
                int leaveId = Convert.ToInt32(rstatusleave.Rows[e.RowIndex].Cells["LeavingID"].Value);
                // Open the next form and pass the leaveId
                this.Hide();
                LeaveDetailsForm leaveDetails = new LeaveDetailsForm(leaveId);
                leaveDetails.Show();
            }
        }
    }
}
