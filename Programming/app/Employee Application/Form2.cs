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
    public partial class empDashboard : Form
    {
        private string userName;
        String connectionString = "Data Source=DESKTOP-8PVTG63;Initial Catalog=LeaMS;Integrated Security=True";

        public empDashboard(string data)
        {
            InitializeComponent();
            userName = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplyLeave apply = new ApplyLeave(userName);
            apply.Show();
        }

        private void empDashboard_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    int ALC = 0;
                    int CLC = 0;
                    int SLC = 0;
                    int AL = 0;
                    int CL = 0;
                    int SL = 0;

                    conn.Open();
                    string countquery = "SELECT LeaveType, COUNT(*) AS LC FROM RLLeaves WHERE UID = '" + userName + "' AND Status = 'approved' AND (LeaveType = 'Annual Leave' OR LeaveType = 'Casual Leave') GROUP BY LeaveType; SELECT COUNT(*) AS LC FROM RLLeaves WHERE UID = '" + userName + "' AND Status = 'approved' AND LeaveType = 'Short Leave' AND MONTH(LeavingDate) = MONTH(GETDATE()) AND YEAR(LeavingDate) = YEAR(GETDATE());";
                    using (SqlCommand cmd = new SqlCommand(countquery, conn))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read()) // Call Read() before accessing the data
                            {
                                string leaveType = rdr["LeaveType"].ToString();
                                int LC = Convert.ToInt32(rdr["LC"]);

                                if (leaveType == "Annual Leave")
                                    ALC = LC;
                                else if (leaveType == "Casual Leave")
                                    CLC = LC;
                                if (rdr.NextResult() && rdr.Read()) // Handle short leaves
                                {
                                    SLC = Convert.ToInt32(rdr["LC"]);
                                }
                            }
                        }
                    }
                    string totalcountquery = "SELECT AnnualLeaves, CasualLeaves, ShortLeaves FROM TBUsers WHERE UID = '" + userName + "'";
                    using (SqlCommand cmd1 = new SqlCommand(totalcountquery, conn))
                    {
                        using (SqlDataReader rdr1 = cmd1.ExecuteReader())
                        {
                            if (rdr1.Read()) // Call Read() before accessing the data
                            {
                                AL = Convert.ToInt32(rdr1["AnnualLeaves"]);
                                CL = Convert.ToInt32(rdr1["CasualLeaves"]);
                                SL = Convert.ToInt32(rdr1["ShortLeaves"]);
                            }
                        }
                    }
                    int RAL = AL - ALC;
                    int RCL = CL - CLC;
                    int RSL = SL - SLC;

                    remainingLeaves.Text = Environment.NewLine + "Annual Leaves " + RAL + " out of " + AL + Environment.NewLine +
                        "Casual Leaves " + RCL + " out of " + CL + Environment.NewLine +
                        "Short Leaves " + RSL + " out of " + SL;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("hi");
                    MessageBox.Show("Error Occured : " + ex, "Error connecting to database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
            string query = "SELECT EffectiveDates, StartTime, EndTime " +
               "FROM RLRoster " +
               "WHERE UID = @userName AND EffectiveDates >= @currentDateTime ORDER BY EffectiveDates ASC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to the query
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@currentDateTime", DateTime.Now.ToString("yyyy-MM-dd"));
                        Console.WriteLine("Current DateTime: " + DateTime.Now);
                        SqlDataAdapter ada = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            rosters.DataSource = dt;
                            // Adjust column width based on content
                            rosters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                            // Adjust row height based on content
                            rosters.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                            // Enable text wrapping for cells
                            rosters.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                            // Adjust header size if needed
                            rosters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                            labelMessage.Visible = false;
                            rosters.Visible = true;
                        }
                        else
                        {
                            labelMessage.Visible = true;
                            rosters.Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error in rosters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void reaminingLeaves_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            rLeaves Statusleaves = new rLeaves(userName);
            Statusleaves.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void remainingLeaves_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
