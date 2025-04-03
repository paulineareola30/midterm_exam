using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class StudentPage_Individual : Form
    {
        private int studentId;

        public StudentPage_Individual(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void StudentPage_Individual_Load(object sender, EventArgs e)
        {
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            try
            {
                // MySQL connection string (replace with your own credentials)
                string connectionString = "server=localhost;user=root;password=pauline123;database=studentinfodb";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to get the selected student data
                    string query = "SELECT studentId, firstName, middleName, lastName, houseNo, brgyName, municipality, province, region, country, birthdate, age, studContactNo, emailAddress, guardianFirstName, guardianLastName, hobbies, nickname, courseId, yearId FROM studentrecordtb WHERE studentId = @studentId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentId", studentId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate the labels with the student's details
                        lblStudentId.Text = "Student ID:                   " + reader["studentId"].ToString();
                        lblFirstName.Text = "First Name:                   " + reader["firstName"].ToString();
                        lblMiddleName.Text = "Middle Name:               " + reader["middleName"].ToString();
                        lblLastName.Text = "Last Name:                   " + reader["lastName"].ToString();
                        lblHouseNo.Text = "House No:                    " + reader["houseNo"].ToString();
                        lblBrgyName.Text = "Barangay:                     " + reader["brgyName"].ToString();
                        lblMunicipality.Text = "Municipality:                  " + reader["municipality"].ToString();
                        lblProvince.Text = "Province:                      " + reader["province"].ToString();
                        lblRegion.Text = "Region:                         " + reader["region"].ToString();
                        lblCountry.Text = "Country:                        " + reader["country"].ToString();
                        lblDateOfBirth.Text = "Date of Birth:                " + reader["birthdate"].ToString();
                        lblAge.Text = "Age:                              " + reader["age"].ToString();
                        lblPhoneNumber.Text = "Phone Number:             " + reader["studContactNo"].ToString();
                        lblEmail.Text = "Email Address:               " + reader["emailAddress"].ToString();
                        lblGuardianFirstName.Text = "Guardian First Name:    " + reader["guardianFirstName"].ToString();
                        lblGuardianLastName.Text = "Guardian Last Name:    " + reader["guardianLastName"].ToString();
                        lblHobbies.Text = "Hobbies:                        " + reader["hobbies"].ToString();
                        lblNickname.Text = "Nickname:                     " + reader["nickname"].ToString();
                        lblCourseId.Text = "Course ID:                     " + reader["courseId"].ToString();
                        lblYearId.Text = "Year ID:                         " + reader["yearId"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Student not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student details: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}