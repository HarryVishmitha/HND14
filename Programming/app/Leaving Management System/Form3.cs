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
    public partial class FaddNewEmp : Form
    {
        public FaddNewEmp()
        {
            InitializeComponent();
        }

        private void bacK_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDash adminDash = new AdminDash();
            adminDash.Show();
        }

        private void UId_TextChanged(object sender, EventArgs e)
        {
            //string Uid = UId.Text;
            //if (Uid == "")
            //{
            //    MessageBox.Show("User Id cannot be empty!", "Input required!",MessageBoxButtons.OK, MessageBoxIcon.Information );
            //}
            //if (int.TryParse(UId.Text, out int employeeID))
            //{
            //    MessageBox.Show("Well done");
            //}
            //else
            //{
            //    MessageBox.Show("Please enter a valid number!", "Error - Numbers only", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar))
            {
                // Allow only digits (0-9)
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;  // Stop the character from being entered into the control
                    MessageBox.Show("Please enter a valid number!", "Error - Numbers only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void annualLeaves_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar))
            {
                // Allow only digits (0-9)
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;  // Stop the character from being entered into the control
                    MessageBox.Show("Please enter a valid number!", "Error - Numbers only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void casualLeaves_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar))
            {
                // Allow only digits (0-9)
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;  // Stop the character from being entered into the control
                    MessageBox.Show("Please enter a valid number!", "Error - Numbers only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void shortLeaves_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar))
            {
                // Allow only digits (0-9)
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;  // Stop the character from being entered into the control
                    MessageBox.Show("Please enter a valid number!", "Error - Numbers only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Add button
        private void button1_Click(object sender, EventArgs e)
        {
            String UID = UId.Text;
            String PW = password.Text;
            String FN = firstName.Text;
            String LN = lastName.Text;
            String JD = dateTimePicker1.Value.ToString();
            String role = acType.SelectedItem.ToString();
            int Salary, AL, CL, SL;

            //function for check user inputs not empty
            if (!string.IsNullOrWhiteSpace(UID) &&
                !string.IsNullOrWhiteSpace(FN) &&
                !string.IsNullOrWhiteSpace(LN) &&
                !string.IsNullOrWhiteSpace(JD) &&
                !string.IsNullOrWhiteSpace(role) &&
                int.TryParse(salary.Text, out Salary) &&
                int.TryParse(annualLeaves.Text, out AL) &&
                int.TryParse(casualLeaves.Text, out CL) &&
                int.TryParse(shortLeaves.Text, out SL))
            {
                String values = "'" + UID + "', '" + PW + "', '','" + FN + "', '" + LN + "', '" + Salary + "', '" + AL + "', '" + CL + "', '" + SL + "', '" + JD + "', '" + role + "'";
                String connectionString = "Data Source=DESKTOP-8PVTG63;Initial Catalog=LeaMS;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        //Check for UID not exists
                        string query2 = "SELECT COUNT(*) FROM TBUsers WHERE UID = '" + UID + "'";
                        SqlCommand cmd1 = new SqlCommand(query2, conn);
                        int count = (int)cmd1.ExecuteScalar();
                        //checking database rows for UID
                        if (count > 0)
                        {
                            MessageBox.Show("User ID Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            String queryInsert = "INSERT INTO TBUsers (UID, PassWord, Emp_Username, FirstName, LastName, Salary, AnnualLeaves, CasualLeaves, ShortLeaves, joinedDate, acType) VALUES (" + values + ")";
                            using (SqlCommand cmd = new SqlCommand(queryInsert, conn))
                            {

                                //check for affcted rows
                                int RA = cmd.ExecuteNonQuery();
                                if (RA > 0)
                                {
                                    MessageBox.Show("Successfully added one user!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    FaddNewEmp faddNewEmp = new FaddNewEmp();
                                    faddNewEmp.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Sorry! Something went wrong and try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Error " + ex + "", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Inputs cannot be empty!", "Inputs are Required!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //this.Hide();
            //FaddNewEmp newEmp = new FaddNewEmp();
            //newEmp.Show();
            //MessageBox.Show("New user added Successfully!", "Successfully added", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FaddNewEmp newEmp = new FaddNewEmp();
            newEmp.Show();
        }

        private void annualLeaves_TextChanged(object sender, EventArgs e)
        {
            //string AL = firstName.Text;
            //if (AL == "")
            //{
            //    MessageBox.Show("First Name cannot be empty!", "Input required!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            //string FirstName = firstName.Text;
            //if (FirstName == "")
            //{
            //    MessageBox.Show("First Name cannot be empty!", "Input required!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            //string LastName = lastName.Text;
            //if (LastName == "")
            //{
            //    MessageBox.Show("Lastname cannot be empty!", "Input required!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //string JD = dateTimePicker1.Text;
            //if (JD == "")
            //{
            //    MessageBox.Show("Joined Date cannot be empty!", "Input required!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void acType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string role = acType.Text;
            //if (role == "")
            //{
            //    MessageBox.Show("Role cannot be empty!", "Input required!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void casualLeaves_TextChanged(object sender, EventArgs e)
        {

        }

        private void shortLeaves_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
