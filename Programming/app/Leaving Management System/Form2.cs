using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leaving_Management_System
{
    public partial class AdminDash : Form
    {
        DateTime today = DateTime.Now;
        String connectionString = "Data Source=DESKTOP-8PVTG63;Initial Catalog=LeaMS;Integrated Security=True";
        public AdminDash()
        {
            InitializeComponent();
            // Initialize Timer
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //Show date and time now
            DateTime now = DateTime.Now;
            datetimeshower.Text = now.ToString("dd-MM-yyyy HH:mm:ss");
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            userscount(sender, e);
            todayleavecount(sender, e);
            todayrostercount(sender, e);
            pendingLeaves(sender, e);
        }

        //Total of users
        private void userscount(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM TBUsers";
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
                        usersT.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        //Today leaves count
        private void todayleavecount(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM RLLeaves WHERE CONVERT(date, LeavingDate) = '" + today.Date + "'";
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
                        todayleaves.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        //Today rosters count
        private void todayrostercount(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM RLRoster WHERE CONVERT(date, EffectiveDates) = '" + today.Date + "'";
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
                        rosterssche.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        //Pending leaves
        private void pendingLeaves(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM RLLeaves WHERE Status = 'pending'";
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
                        pendingreqs.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured : " + ex, "Error connection with database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
            }
        }

        private void addNewEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaddNewEmp AddNewEmp = new FaddNewEmp();
            AddNewEmp.Show();
        }

        private void Reqs_Click(object sender, EventArgs e)
        {
            this.Hide();
            reqLeaves reqsT = new reqLeaves();
            reqsT.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDash adD = new AdminDash();
            adD.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            addRoster ar = new addRoster();
            ar.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            leaveReports Rp = new leaveReports();
            Rp.Show();
        }
    }
}
