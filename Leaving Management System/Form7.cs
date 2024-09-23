using System;
using System.Collections;
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
    public partial class addRoster : Form
    {
        String connectionString = "Data Source=DESKTOP-8PVTG63;Initial Catalog=LeaMS;Integrated Security=True";
        String SelectedUID;
        public addRoster()
        {
            InitializeComponent();
        }

        private void addRoster_Load(object sender, EventArgs e)
        {
            getAllUsers12();
            button1.Enabled = false;
        }

        public void getAllUsers12()
        {
            List<User> users = new List<User>();
            string getUsers = "SELECT UID, FirstName, LastName FROM TBUsers";
            // Add a default item at the beginning of the list
            users.Add(new User { UID = "", FullName = "Select User to get report of specific user" });
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(getUsers, conn))
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

        private void bacK_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDash adminDash = new AdminDash();
            adminDash.Show();
        }

        private void selectUID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedUID = selectUID.SelectedValue.ToString();
        }

        private void fromD_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedUID))
            {
                MessageBox.Show("Please select a user", "Select a user", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DateTime RosterDate = fromD.Value;
                string query124 = "SELECT COUNT(*) FROM RLLeaves WHERE LeavingDate = '" + RosterDate + "' AND UID = '" + SelectedUID + "'";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query124, conn))
                        {
                            int count = (int)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("Sorry! Employee already requested a leave.", "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                button1.Enabled = false;
                            }
                            else
                            {
                                button1.Enabled = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        button1.Enabled=false;
                        MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RLRoster (UID, StartTime, EndTime, EffectiveDates) VALUES ('"+ SelectedUID +"', '" + dateTimePicker1.Value.ToString() + "', '" + dateTimePicker2.Value.ToString() + "', '" + fromD.Value.ToString("d") + "')";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int RA = cmd.ExecuteNonQuery();
                        if (RA > 0)
                        {
                            MessageBox.Show("Successfully added roster!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button1.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Sorry! Something went wrong and try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    button1.Enabled = false;
                    MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
