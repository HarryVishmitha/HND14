using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Leaving_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source=DESKTOP-8PVTG63;Initial Catalog=LeaMS;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string userName = userId.Text;
                    string Password = password.Text;
                    string query = "SELECT COUNT(*) FROM TBUsers WHERE UID COLLATE Latin1_General_BIN = '" + userName + "' AND PassWord COLLATE Latin1_General_BIN = '" + Password +"'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    //cmd.Parameters.AddWithValue("@UID", userName);
                    //cmd.Parameters.AddWithValue("@PassWord", password);

                    //Send data to virtual data table to store user data
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //Find user with UID and his Password
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        //Check user role, Only admins can access to admin portal
                        string query2 = "SELECT acType FROM TBUsers WHERE UID = '" + userName + "'";
                        SqlCommand cmd1 = new SqlCommand(query2, conn);
                        object role = cmd1.ExecuteScalar();
                        string role1 = role.ToString();
                        //MessageBox.Show(role1);
                        if (role1 == "admin")
                        {
                            this.Hide();
                            AdminDash AdminDash = new AdminDash();
                            AdminDash.Show();
                            MessageBox.Show("Welcome Back", "Welcome", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Authenication Error: Only Admins can access to Admin portal", "Authenication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured : " + ex, "Error connecting to database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home logIn = new Home();
            logIn.Show();
        }
    }
}
