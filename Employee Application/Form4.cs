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

namespace Employee_Application
{
    public partial class rLeaves : Form
    {
        private string userName;
        String connectionString = "Data Source=DESKTOP-8PVTG63;Initial Catalog=LeaMS;Integrated Security=True";

        public rLeaves(string data)
        {
            InitializeComponent();
            userName = data;
        }

        private void bacK_Click(object sender, EventArgs e)
        {
            this.Hide();
            empDashboard empdash = new empDashboard(userName);
            empdash.Show();
        }

        private void rLeaves_Load(object sender, EventArgs e)
        {
            string query = "SELECT TOP 25 LeaveType, Status, LeavingDate, StartTime, EndTime, Reason, AppliedDate, StatusUpdate, LeavingID FROM RLLeaves WHERE UID = @UID ORDER BY AppliedDate DESC";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UID", userName);
                        SqlDataAdapter ada = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            // Add a Button Column for Delete
                            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                            deleteButtonColumn.Name = "Deletebtn";
                            deleteButtonColumn.HeaderText = "Delete";
                            deleteButtonColumn.Text = "Delete";
                            deleteButtonColumn.UseColumnTextForButtonValue = true;
                            rstatusleave.Columns.Add(deleteButtonColumn);
                            rstatusleave.DataSource = dt;
                            // Set button appearance to yellow
                            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Yellow;
                            deleteButtonColumn.DefaultCellStyle.ForeColor = Color.Black; // Optionally, set the text color for better contrast

                            // Adjust column width based on content
                            rstatusleave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                            // Adjust row height based on content
                            rstatusleave.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                            // Enable text wrapping for cells
                            rstatusleave.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                            // Adjust header size if needed
                            rstatusleave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                            // Loop through each row and apply ForeColor based on the Status column
                            foreach (DataGridViewRow row in rstatusleave.Rows)
                            {
                                string statusValue = row.Cells["Status"].Value?.ToString();
                                if (!string.IsNullOrEmpty(statusValue))
                                {
                                    switch (statusValue)
                                    {
                                        case "pending":
                                            row.Cells["Status"].Style.ForeColor = Color.White;
                                            row.Cells["Status"].Style.BackColor = Color.Blue;
                                            break;
                                        case "approved":
                                            row.Cells["Status"].Style.ForeColor = Color.White;
                                            row.Cells["Status"].Style.BackColor = Color.Green;
                                            break;
                                        case "denied":
                                            row.Cells["Status"].Style.ForeColor = Color.White;
                                            row.Cells["Status"].Style.BackColor = Color.Red;
                                            break;
                                        default:
                                            row.Cells["Status"].Style.ForeColor = Color.Black; // Default text color
                                            break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("You didn't apply any leave or something went wrong!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rstatusleave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click was on the button column
            if (e.ColumnIndex == rstatusleave.Columns["Deletebtn"].Index && e.RowIndex >= 0)
            {
                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this leave record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Get the LeaveID from the selected row
                    int leaveId = Convert.ToInt32(rstatusleave.Rows[e.RowIndex].Cells["LeavingID"].Value);

                    // Delete the record from the database
                    string deleteQuery = "DELETE FROM RLLeaves WHERE LeavingID = @LeavingID";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@LeavingID", leaveId);
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Leave record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Refresh the DataGridView
                                    rLeaves_Load(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("Error deleting leave record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
