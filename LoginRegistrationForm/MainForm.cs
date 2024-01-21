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

namespace LoginRegistrationForm
{
    
    public partial class MainForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-K25VIFD\SQLEXPRESS01;Initial Catalog=skillSchool;Integrated Security=True;Connect Timeout=30");

        public MainForm()
        {
            InitializeComponent();
        }

        private void logOutbtn_click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                loginForm loginForm = new loginForm();
                loginForm.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbStuRegNo.Items.Clear();

            

            // Check if the database has no student IDs
            if (!DatabaseHasStudentIDs())
            {
                // If no student IDs, add a default registration number
                cmbStuRegNo.Items.Add("S-0001");
                cmbStuRegNo.SelectedIndex = 0;
            }
            else
            {
                // If there are student IDs, load them from the database
                LoadAllRegistrationNumbers();

                // Generate a new registration number
                string newRegNo = GenerateNewRegistrationNumber();
                cmbStuRegNo.Text = newRegNo;

                cleearAllFields();
            }
        }

        private bool DatabaseHasStudentIDs()
        {
            try
            {
                connect.Open();

                string query = "SELECT COUNT(*) FROM student";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    int studentCount = (int)command.ExecuteScalar();

                    // If there are no student IDs, return false
                    return studentCount > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking for student IDs in the database: " + ex.Message);
                return false;
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }


        private void LoadAllRegistrationNumbers()
        {
            cmbStuRegNo.Items.Clear();

            List<string> allRegNumbers = GetAllRegistrationNumbersFromDatabase();

            cmbStuRegNo.Items.AddRange(allRegNumbers.ToArray());

            if (allRegNumbers.Count > 0)
            {
                cmbStuRegNo.SelectedIndex = allRegNumbers.Count - 1;
            }
            else
            {
                cmbStuRegNo.Items.Add("S-0001");
                cmbStuRegNo.SelectedIndex = 0;
            }
            
        }

        private List<string> GetAllRegistrationNumbersFromDatabase()
        {
            List<string> allRegNumbers = new List<string>();

            try
            {
                connect.Open();

                string query = "SELECT studentID FROM student";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allRegNumbers.Add(reader["studentID"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data from the database: " + ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

            return allRegNumbers;
        }

        private List<string> GetExistingRegistrationNumbersFromDatabase()
        {
            List<string> existingRegNumbers = new List<string>();

            try
            {
                connect.Open();

                string query = "SELECT studentID FROM student";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            existingRegNumbers.Add(reader["studentID"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data from the database: " + ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

            return existingRegNumbers;
        }

        private string GenerateNewRegistrationNumber()
        {
            // Fetch the latest registration number from the ComboBox
            string lastRegNumber = cmbStuRegNo.Items.Count > 0 ? cmbStuRegNo.Items[cmbStuRegNo.Items.Count - 1].ToString() : "S-0000";

            // Extract the numeric part
            string numericPart = lastRegNumber.Substring(2);
            int nextNumber = int.Parse(numericPart) + 1;

            // Format the new registration number
            return $"S-{nextNumber:D4}";
        }

        private void btnStuReg_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                // Generate a new registration number
                //  string newRegNumber = GenerateNewRegistrationNumber();

               string regNumber = cmbStuRegNo.Text;


                // Get other student details (you may need to modify this based on your form controls)
                string firstName = txtStuFirstName.Text; // Replace with your actual control name
                string lastName = txtStuLastName.Text; // Replace with your actual control name
                DateTime dob = dtpStuDOB.Value; // Replace with your actual control name

                string gender;

                if (rbtnStuMale.Checked)
                {
                    gender = "Male";
                }
                else if (rbtnStuFemale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    MessageBox.Show("Please select a gender.");
                    return; // Don't proceed if no gender is selected
                }

                string address = txtStuAddress.Text; // Replace with your actual control name
                string email = txtStuEmail.Text; // Replace with your actual control name
                int mobilePhone = int.Parse(txtStuMobile.Text); // Replace with your actual control name
                int homePhone = int.Parse(txtStuHomePhone.Text); // Replace with your actual control name
                string parentName = txtParentName.Text; // Replace with your actual control name
                string parentNIC = txtParentNIC.Text; // Replace with your actual control name
                int parentContactNo = int.Parse(txtParentContact.Text); // Replace with your actual control name

                // Insert the new student record into the database
                string query = "INSERT INTO student (studentID, studentFirstName, studentLastName, studentDOB, studentGender, studentAddress, studentEmail, studentMobilePhone, studentHomePhone, parentName, parentNIC, parentContactNo) " +
                                "VALUES (@studentID, @studentFirstName, @studentLastName, @studentDOB, @studentGender, @studentAddress, @studentEmail, @studentMobilePhone, @studentHomePhone, @parentName, @parentNIC, @parentContactNo)";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@studentID", regNumber);
                    command.Parameters.AddWithValue("@studentFirstName", firstName);
                    command.Parameters.AddWithValue("@studentLastName", lastName);
                    command.Parameters.AddWithValue("@studentDOB", dob);
                    command.Parameters.AddWithValue("@studentGender", gender);
                    command.Parameters.AddWithValue("@studentAddress", address);
                    command.Parameters.AddWithValue("@studentEmail", email);
                    command.Parameters.AddWithValue("@studentMobilePhone", mobilePhone);
                    command.Parameters.AddWithValue("@studentHomePhone", homePhone);
                    command.Parameters.AddWithValue("@parentName", parentName);
                    command.Parameters.AddWithValue("@parentNIC", parentNIC);
                    command.Parameters.AddWithValue("@parentContactNo", parentContactNo);

                    command.ExecuteNonQuery();
                }

                // Display a success message
                MessageBox.Show("Student registration successful!");

                connect.Close();

                // cleearAllFields();

                // Refresh the list of registration numbers

                cmbStuRegNo.Items.Clear();



                // If there are student IDs, load them from the database
                LoadAllRegistrationNumbers();


                // Generate a new registration number
                string newRegNo = GenerateNewRegistrationNumber();
                cmbStuRegNo.Text = newRegNo;

                cleearAllFields();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering student: " + ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void LoadAllIDs()
        {
            try
            {

                // Clear existing items in the ComboBox
                cmbStuRegNo.Items.Clear();

                // Fetch all studentIDs from the database
                string query = "SELECT studentID FROM student";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string studentID = reader["studentID"].ToString();
                            cmbStuRegNo.Items.Add(studentID);
                        }
                    }
                }

                // If there are items in the ComboBox, select the last one
                if (cmbStuRegNo.Items.Count > 0)
                {
                    cmbStuRegNo.SelectedIndex = cmbStuRegNo.Items.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student IDs: " + ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

        }

        private void cleearAllFields()
        {
            txtStuFirstName.Text = string.Empty;
            txtStuLastName.Text = string.Empty;
            dtpStuDOB.Value = DateTime.Now; 
           // rbtnStuMale.Checked = false;
          //  rbtnStuFemale.Checked = false;

            // Clear the parent details fields
            txtStuAddress.Text = string.Empty;
            txtStuEmail.Text = string.Empty;
            txtStuMobile.Text = string.Empty;
            txtStuHomePhone.Text = string.Empty;
            txtParentName.Text = string.Empty;
            txtParentNIC.Text = string.Empty;
            txtParentContact.Text = string.Empty;
        }

        private void btnStuClear_Click(object sender, EventArgs e)
        {
            cleearAllFields();
        }

        private void btnStuUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                // Get the selected student ID from the ComboBox
                string selectedStudentID = cmbStuRegNo.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedStudentID))
                {
                    MessageBox.Show("Please select a student ID.");
                    return;
                }

                // Get other student details (you may need to modify this based on your form controls)
                string firstName = txtStuFirstName.Text; // Replace with your actual control name
                string lastName = txtStuLastName.Text; // Replace with your actual control name
                DateTime dob = dtpStuDOB.Value; // Replace with your actual control name

                string gender;

                if (rbtnStuMale.Checked)
                {
                    gender = "Male";
                }
                else if (rbtnStuFemale.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    MessageBox.Show("Please select a gender.");
                    return; // Don't proceed if no gender is selected
                }

                string address = txtStuAddress.Text; // Replace with your actual control name
                string email = txtStuEmail.Text; // Replace with your actual control name
                int mobilePhone = int.Parse(txtStuMobile.Text); // Replace with your actual control name
                int homePhone = int.Parse(txtStuHomePhone.Text); // Replace with your actual control name
                string parentName = txtParentName.Text; // Replace with your actual control name
                string parentNIC = txtParentNIC.Text; // Replace with your actual control name
                int parentContactNo = int.Parse(txtParentContact.Text); // Replace with your actual control name

                // Update the student record in the database
                string updateQuery = "UPDATE student SET " +
                               "studentFirstName = @studentFirstName, " +
                               "studentLastName = @studentLastName, " +
                               "studentDOB = @studentDOB, " +
                               "studentGender = @studentGender, " +
                               "studentAddress = @studentAddress, " +
                               "studentEmail = @studentEmail, " +
                               "studentMobilePhone = @studentMobilePhone, " +
                               "studentHomePhone = @studentHomePhone, " +
                               "parentName = @parentName, " +
                               "parentNIC = @parentNIC, " +
                               "parentContactNo = @parentContactNo " +
                               "WHERE studentID = @studentID";

                using (SqlCommand command = new SqlCommand(updateQuery, connect))
                {
                    command.Parameters.AddWithValue("@studentID", selectedStudentID);
                    command.Parameters.AddWithValue("@studentFirstName", firstName);
                    command.Parameters.AddWithValue("@studentLastName", lastName);
                    command.Parameters.AddWithValue("@studentDOB", dob);
                    command.Parameters.AddWithValue("@studentGender", gender);
                    command.Parameters.AddWithValue("@studentAddress", address);
                    command.Parameters.AddWithValue("@studentEmail", email);
                    command.Parameters.AddWithValue("@studentMobilePhone", mobilePhone);
                    command.Parameters.AddWithValue("@studentHomePhone", homePhone);
                    command.Parameters.AddWithValue("@parentName", parentName);
                    command.Parameters.AddWithValue("@parentNIC", parentNIC);
                    command.Parameters.AddWithValue("@parentContactNo", parentContactNo);

                    command.ExecuteNonQuery();
                }

                // Display a success message
                MessageBox.Show("Student information updated successfully!");

                connect.Close();

               // cleearAllFields();

                // Refresh the list of registration numbers

                cmbStuRegNo.Items.Clear();



                    // If there are student IDs, load them from the database
                    LoadAllRegistrationNumbers();
                

                    // Generate a new registration number
                    string newRegNo = GenerateNewRegistrationNumber();
                    cmbStuRegNo.Text = newRegNo;

                    cleearAllFields();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student information: " + ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }


        private void cmbStuRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                // Get the selected student ID from the ComboBox
                string selectedStudentID = cmbStuRegNo.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedStudentID))
                {
                    MessageBox.Show("Please select a student ID.");
                    return;
                }

                // Retrieve existing student details from the database
                string query = "SELECT * FROM student WHERE studentID = @studentID";

                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    command.Parameters.AddWithValue("@studentID", selectedStudentID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate form fields with existing values
                            txtStuFirstName.Text = reader["studentFirstName"].ToString();
                            txtStuLastName.Text = reader["studentLastName"].ToString();
                            dtpStuDOB.Value = Convert.ToDateTime(reader["studentDOB"]);

                            string studentgender = reader["studentGender"].ToString();
                            if (studentgender == "Male")
                                rbtnStuMale.Checked = true;
                            else if (studentgender == "Female")
                                rbtnStuFemale.Checked = true;

                            txtStuAddress.Text = reader["studentAddress"].ToString();
                            txtStuEmail.Text = reader["studentEmail"].ToString();
                            txtStuMobile.Text = reader["studentMobilePhone"].ToString();
                            txtStuHomePhone.Text = reader["studentHomePhone"].ToString();
                            txtParentName.Text = reader["parentName"].ToString();
                            txtParentNIC.Text = reader["parentNIC"].ToString();
                            txtParentContact.Text = reader["parentContactNo"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student information: " + ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void btnStuDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                // Get the selected student ID from the ComboBox
                string selectedStudentID = cmbStuRegNo.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(selectedStudentID))
                {
                    MessageBox.Show("Please select a student ID.");
                    return;
                }

                // Confirm with the user before deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this student record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the student record from the database
                    string deleteQuery = "DELETE FROM student WHERE studentID = @studentID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connect))
                    {
                        command.Parameters.AddWithValue("@studentID", selectedStudentID);
                        command.ExecuteNonQuery();
                    }

                    // Display a success message
                    MessageBox.Show("Student record deleted successfully!");

                    connect.Close();

                    // cleearAllFields();

                    // Refresh the list of registration numbers

                    cmbStuRegNo.Items.Clear();



                    // If there are student IDs, load them from the database
                    LoadAllRegistrationNumbers();


                    // Generate a new registration number
                    string newRegNo = GenerateNewRegistrationNumber();
                    cmbStuRegNo.Text = newRegNo;

                    cleearAllFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student record: " + ex.Message);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

    }

}
