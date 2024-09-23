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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Leaving_Management_System
{
    public partial class LeaveDetailsForm : Form
    {
        public int LeaveID;
        public string uid;
        public string leavetype;
        public int leavecount;
        public string leavingMonth1;
        public string leavingYear;
        String connectionString = "Data Source=DESKTOP-8PVTG63;Initial Catalog=LeaMS;Integrated Security=True";
        public LeaveDetailsForm(int leaveID)
        {
            InitializeComponent();
            LeaveID = leaveID;
        }

        private void bacK_Click(object sender, EventArgs e)
        {
            this.Hide();
            reqLeaves req = new reqLeaves();
            req.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LeaveDetailsForm_Load(object sender, EventArgs e)
        {
            string getleavedetails = "SELECT RLLeaves.LeavingID, RLLeaves.UID, RLLeaves.LeaveType, RLLeaves.LeavingDate, RLLeaves.StartTime, RLLeaves.EndTime, RLLeaves.AppliedDate, RLLeaves.Reason," +
                "TBUsers.UID, TBUsers.FirstName, TBUsers.LastName" +
                " FROM RLLeaves JOIN TBUsers ON RLLeaves.UID = TBUsers.UID WHERE RLLeaves.LeavingID = '"+ LeaveID + "'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(getleavedetails, conn))
                {
                    try
                    {
                        SqlDataAdapter ada = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            UID.Text = row["UID"].ToString();
                            uid = row["UID"].ToString();
                            firstName.Text = row["FirstName"].ToString();
                            lastName.Text = row["LastName"].ToString();
                            leaveType.Text = row["LeaveType"].ToString();
                            leavetype = row["LeaveType"].ToString();
                            if (row["LeavingDate"] != DBNull.Value)
                            {
                                leavingDate.Text = Convert.ToDateTime(row["LeavingDate"]).ToString("yyyy-MM-dd");
                                leavingMonth1 = Convert.ToDateTime(row["LeavingDate"]).ToString("MM");
                                leavingYear = Convert.ToDateTime(row["LeavingDate"]).ToString("yyyy");
                            }
                            else
                            {
                                leavingDate.Text = "N/A"; // Handle the case where the LeavingDate is NULL
                            }
                            string stime = row["StartTime"].ToString();
                            string etime = row["EndTime"].ToString();

                            if (!string.IsNullOrWhiteSpace(stime))
                            {
                                startTime.Text = stime;
                            }

                            if (!string.IsNullOrWhiteSpace(etime))
                            {
                                endTime.Text = etime;
                            }

                            reason.Text = row["Reason"].ToString();
                            if (row["AppliedDate"] != DBNull.Value)
                            {
                                applieddate.Text = Convert.ToDateTime(row["AppliedDate"]).ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                applieddate.Text = "N/A"; // Handle the case where the AppliedDate is NULL
                            }
                            getuserleavecount(uid, leavetype, leavingMonth1, leavingYear);

                        }
                        else
                        {
                            MessageBox.Show("Something went wrong! Please try again later or contact developers.", "Something gone wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                conn.Close();
            }
        }
        private void getuserleavecount(string uid, string leavetype, string LeavingMonth, string LeavingYear)
        {
            string query;
            if (leavetype == "Short Leave")
            {
                query = "SELECT COUNT(*) FROM RLLeaves WHERE UID ='" + uid + "' AND LeaveType = '" + leavetype + "' AND Status = 'approved' AND MONTH(LeavingDate) = '" +LeavingMonth+ "' AND YEAR(LeavingDate) = '" +LeavingYear+ "';";
            }
            else
            {
                query = "SELECT COUNT(*) FROM RLLeaves WHERE UID ='" + uid + "' AND LeaveType = '" + leavetype + "' AND Status = 'approved'";
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Execute the query
                        int count = (int)cmd.ExecuteScalar(); // Use ExecuteScalar to get the count directly

                        // Display the count
                        leaveCount.Text = count.ToString();
                        leavecount = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        private bool Getuserhasleavecount(string uid, string leavetype, int leavecount)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    if (leavetype == "Annual Leave")
                    {
                        leavetype = "AnnualLeaves";   
                    }
                    else if (leavetype == "Casual Leave")
                    {
                        leavetype = "CasualLeaves";
                    }
                    else if (leavetype == "Short Leave")
                    {
                        leavetype = "ShortLeaves";
                    }
                    string totalcountquery = "SELECT " + leavetype + " FROM TBUsers WHERE UID = '" + uid + "'";
                    using (SqlCommand cmd1 = new SqlCommand(totalcountquery, conn))
                    {
                        // Execute the query
                        int count = (int)cmd1.ExecuteScalar(); // Use ExecuteScalar to get the count directly
                        if (leavecount < count)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            String today = DateTime.Now.ToString();
            string deniedquery = "UPDATE RLLeaves SET Status = 'denied', StatusUpdate ='" + today + "' WHERE LeavingID ='" + LeaveID + "'";
            string approvequery = "UPDATE RLLeaves SET Status = 'approved', StatusUpdate ='" + today + "' WHERE LeavingID ='" + LeaveID + "'";
            if (Getuserhasleavecount(uid, leavetype, leavecount))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(approvequery, conn);
                        int RA = cmd.ExecuteNonQuery();
                        if (RA > 0)
                        {
                            MessageBox.Show("Successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reqLeaves rf = new reqLeaves();
                            this.Hide();
                            rf.Show();
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
                // Show Yes/No message box when there isn't enough leave balance
                DialogResult dialogResult = MessageBox.Show("User doesn't have enough leave balance. Do you still want to approve this leave?", "Insufficient Leave Balance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    //Update database with approved
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(approvequery, conn);
                            int RA = cmd.ExecuteNonQuery();
                            if (RA > 0)
                            {
                                MessageBox.Show("Successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reqLeaves rf = new reqLeaves();
                                this.Hide();
                                rf.Show();
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
                else if (dialogResult == DialogResult.No)
                {
                    //Update database with denied
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(deniedquery, conn);
                            int RA = cmd.ExecuteNonQuery();
                            if (RA > 0)
                            {
                                MessageBox.Show("Successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reqLeaves rf = new reqLeaves();
                                this.Hide();
                                rf.Show();
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String today = DateTime.Now.ToString();
            string deniedquery = "UPDATE RLLeaves SET Status = 'denied', StatusUpdate ='" + today + "' WHERE LeavingID ='" + LeaveID + "'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(deniedquery, conn);
                    int RA = cmd.ExecuteNonQuery();
                    if (RA > 0)
                    {
                        MessageBox.Show("Successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reqLeaves rf = new reqLeaves();
                        this.Hide();
                        rf.Show();
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
    }
}
