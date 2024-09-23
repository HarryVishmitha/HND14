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
    public partial class ApplyLeave : Form
    {
        private string userName;
        String connectionString = "Data Source=DESKTOP-8PVTG63;Initial Catalog=LeaMS;Integrated Security=True";

        public ApplyLeave(string data)
        {
            InitializeComponent();
            userName = data;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void bacK_Click(object sender, EventArgs e)
        {
            this.Hide();
            empDashboard empDash = new empDashboard(userName);
            empDash.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplyLeave empLeave = new ApplyLeave(userName);
            empLeave.Show();
        }

        private void leaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedL = leaveType.SelectedItem.ToString();

            if (selectedL == "Short Leave")
            {
                LstartTime.Enabled = true;
                LendTime.Enabled = true;

                // Reset to current time for user to select manually
                LstartTime.Value = DateTime.Now;
                LendTime.Value = DateTime.Now.AddMinutes(90); // 1 hour and 30 minutes for short leave
            }
            else
            {
                LstartTime.Enabled = false;
                LendTime.Enabled = false;
                // Set start and end time to represent a full day leave
                LstartTime.Value = new DateTime(leaveDate.Value.Year, leaveDate.Value.Month, leaveDate.Value.Day, 9, 0, 0); // 9:00 AM
                LendTime.Value = new DateTime(leaveDate.Value.Year, leaveDate.Value.Month, leaveDate.Value.Day, 17, 0, 0); // 5:00 PM
            }
        }

        private void requestLeave_Click(object sender, EventArgs e)
        {
            string leavetype = leaveType.SelectedItem.ToString();
            string reason = Lreason.Text;
            string date = leaveDate.Value.ToString("yyyy-MM-dd");
            string startTime = LstartTime.Value.ToString("HH:mm");
            string endTime = LendTime.Value.ToString("HH:mm");
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string timestamp = DateTime.Now.ToString();
            //MessageBox.Show(date);

            if (!string.IsNullOrWhiteSpace(leavetype) && !string.IsNullOrWhiteSpace(reason) && !string.IsNullOrWhiteSpace(date))
            {
                bool isduringroster = checkRosters(userName, leaveDate.Value);
                if (isduringroster)
                {
                    MessageBox.Show("Cannot apply for leave during roster hours.", "Roster Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // #### This part for only short leaves specially
                if (leavetype == "Short Leave")
                {
                    TimeSpan duration = LendTime.Value - LstartTime.Value;
                    if (duration != TimeSpan.FromMinutes(90))
                    {
                        MessageBox.Show("Sorry! Short Leaves duration must be exactly 1 hour and 30 min not less or not more!", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                    string values = "'" + userName + "', '" + leavetype + "', '" + date + "', '" + startTime + "', '" + endTime + "', '" + today + "', '" + timestamp + "', '" + reason + "'";
                    string query = "INSERT INTO RLLeaves (UID, LeaveType, LeavingDate, StartTime, EndTime, AppliedDate, StatusUpdate, Reason) VALUES (" + values + ")";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(query, conn);
                            int RA = cmd.ExecuteNonQuery();

                            if (RA > 0)
                            {
                                MessageBox.Show("Successfully requested new leave!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                ApplyLeave appL = new ApplyLeave(userName);
                                appL.Show();
                            }
                            else
                            {
                                MessageBox.Show("Sorry! Something went wrong and try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        conn.Close();
                    }
                }
                else
                {
                    if (leavetype == "Annual Leave")
                    {
                        if (leaveDate.Value >= DateTime.Now.AddDays(7))
                        {
                            // ###### This code for other leaves
                            string values = "'" + userName + "', '" + leavetype + "', '" + date + "', '" + today + "', '" + timestamp + "', '" + reason + "'";
                            string query = "INSERT INTO RLLeaves (UID, LeaveType, LeavingDate, AppliedDate, StatusUpdate, Reason) VALUES (" + values + ")";
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                try
                                {
                                    conn.Open();
                                    SqlCommand cmd = new SqlCommand(query, conn);
                                    int RA = cmd.ExecuteNonQuery();

                                    if (RA > 0)
                                    {
                                        MessageBox.Show("Successfully requested new leave!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Hide();
                                        ApplyLeave appL = new ApplyLeave(userName);
                                        appL.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sorry! Something went wrong and try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                conn.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Annual leave can only be applied up to 7 days in advance.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if(leavetype == "Casual Leave")
                    {
                        if (leaveDate.Value  >= DateTime.Now)
                        {
                            // ###### This code for other leaves
                            string values = "'" + userName + "', '" + leavetype + "', '" + date + "', '" + today + "', '" + timestamp + "', '" + reason + "'";
                            string query = "INSERT INTO RLLeaves (UID, LeaveType, LeavingDate, AppliedDate, StatusUpdate, Reason) VALUES (" + values + ")";
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            {
                                try
                                {
                                    conn.Open();
                                    SqlCommand cmd = new SqlCommand(query, conn);
                                    int RA = cmd.ExecuteNonQuery();

                                    if (RA > 0)
                                    {
                                        MessageBox.Show("Successfully requested new leave!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Hide();
                                        ApplyLeave appL = new ApplyLeave(userName);
                                        appL.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sorry! Something went wrong and try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                conn.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Casual leave can only be applied before or on the current date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Inputs cannot be empty!", "Inputs are Required!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public bool checkRosters(string uid, DateTime leavedate)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM RLRoster WHERE UID ='" + uid + "' AND EffectiveDates = '" + leavedate + "'";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        TimeSpan rosterStartTime = TimeSpan.Parse(rd["StartTime"].ToString());
                        TimeSpan rosterEndTime = TimeSpan.Parse(rd["EndTime"].ToString());

                        if (LstartTime.Value.TimeOfDay < rosterEndTime && LendTime.Value.TimeOfDay > rosterStartTime)
                        {
                            return true;
                        }
                    }
                }
                conn.Close();
                return false;
            }
        }

    }
}
