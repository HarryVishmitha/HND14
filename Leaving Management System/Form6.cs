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
    public partial class leaveReports : Form
    {
        String connectionString = "Data Source=DESKTOP-8PVTG63;Initial Catalog=LeaMS;Integrated Security=True";
        String SelectedUID;
        DateTime FromD = DateTime.Now;
        DateTime ToD = DateTime.Now;
        public leaveReports()
        {
            InitializeComponent();
        }

        private void bacK_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDash adminDash = new AdminDash();
            adminDash.Show();
        }

        private void leaveReports_Load(object sender, EventArgs e)
        {
            getAllUsers();
            noMsg.Visible = true;
            reports.Visible = false;
        }
        public void getAllUsers()
        {
            List<User> users = new List<User>();
            string getUsers = "SELECT UID, FirstName, LastName FROM TBUsers";
            // Add a default item at the beginning of the list
            users.Add(new User { UID = "", FullName = "Select User to get report of specific user" });
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(getUsers, conn))
                {
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        User user = new User
                         {
                            UID = rdr.GetString(0),
                            FullName = $"{rdr.GetString(1)} {rdr.GetString(2)}"
                         };
                        users.Add(user);
                    }
                }
            }
            selectUID.ValueMember = "UID";
            selectUID.DisplayMember = "UID - FullName";
            selectUID.DataSource = users;
        }

        private void fromD_ValueChanged(object sender, EventArgs e)
        {
            FromD = fromD.Value;
        }

        private void toD_ValueChanged(object sender, EventArgs e)
        {
            ToD = toD.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SelectedUID))
            {
                getAlluserLeavereport();
            }
            else
            {
                getIndividualUserLeavereport();
            }
        }

        private void getAlluserLeavereport()
        {
            string query = "SELECT UID, LeaveType, LeavingDate, StartTime, EndTime, Status, AppliedDate, Reason FROM RLLeaves WHERE LeavingDate BETWEEN '"+ FromD.Date +"' AND '" + ToD.Date +"'";
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter ada = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            noMsg.Visible = false;
                            reports.Visible = true;
                            reports.DataSource = dt;
                            // Adjust column width based on content
                            reports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                            // Adjust row height based on content
                            reports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                            // Enable text wrapping for cells
                            reports.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                            // Adjust header size if needed
                            reports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        }
                        else
                        {
                            noMsg.Visible = true;
                            reports.Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    noMsg.Visible = true;
                    reports.Visible = false;
                    MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void getIndividualUserLeavereport()
        {
            string query = "SELECT UID, LeaveType, LeavingDate, StartTime, EndTime, Status, AppliedDate, Reason FROM RLLeaves WHERE UID = '" + SelectedUID + "' AND LeavingDate BETWEEN '"+ FromD.Date +"' AND '" + ToD.Date +"'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter ada = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            noMsg.Visible = false;
                            reports.Visible = true;
                            reports.DataSource = dt;
                            // Adjust column width based on content
                            reports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                            // Adjust row height based on content
                            reports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                            // Enable text wrapping for cells
                            reports.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                            // Adjust header size if needed
                            reports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        }
                        else
                        {
                            noMsg.Visible = true;
                            reports.Visible = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    noMsg.Visible = true;
                    reports.Visible = false;
                    MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void selectUID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedUID = selectUID.SelectedValue.ToString();
        }
    }

    //User class for users list
    public class User
    {
        public string UID { get; set; }
        public string FullName { get; set; }

        public override string ToString()
        {
            return $"{UID} - {FullName}";
        }
    }
}
