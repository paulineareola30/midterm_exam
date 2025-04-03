using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class Student_Page : Form
    {
        // MySQL connection string (replace with your own credentials)
        private string connectionString = "server=localhost;user=root;password=pauline123;database=studentinfodb";


        public Student_Page()
        {
            InitializeComponent();
        }

        private void Student_Page_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to get the student data
                    string query = "SELECT studentId, firstName, middleName, lastName FROM studentrecordtb";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Check if DataTable is not empty
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No student data found.");
                    }

                    // Add "VIEW" button only if it doesn't exist
                    if (!StudentListDataGridView.Columns.Contains("ViewButton"))
                    {
                        DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn
                        {
                            Name = "ViewButton",
                            HeaderText = "Action",
                            Text = "VIEW",
                            UseColumnTextForButtonValue = true
                        };
                        StudentListDataGridView.Columns.Add(viewButtonColumn);
                    }

                    // Bind data to DataGridView
                    StudentListDataGridView.DataSource = dt;

                    // Set the column headers to more user-friendly names
                    foreach (DataGridViewColumn column in StudentListDataGridView.Columns)
                    {
                        if (column.Name == "firstName")
                        {
                            column.HeaderText = "First Name";
                        }
                        else if (column.Name == "middleName")
                        {
                            column.HeaderText = "Middle Name";
                        }
                        else if (column.Name == "lastName")
                        {
                            column.HeaderText = "Last Name";
                        }
                        else if (column.Name == "studentId")
                        {
                            column.HeaderText = "Student ID";
                        }
                    }

                    // Move the "Action" button column to the far right
                    StudentListDataGridView.Columns["ViewButton"].DisplayIndex = StudentListDataGridView.Columns.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student data: " + ex.Message);
            }
        }


        private void StudentListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the "VIEW" button was clicked
            if (e.ColumnIndex == StudentListDataGridView.Columns["ViewButton"].Index && e.RowIndex >= 0)
            {
                // Ensure 'studentId' is in the correct column index
                var studentIdCell = StudentListDataGridView.Rows[e.RowIndex].Cells["studentId"];
                if (studentIdCell != null && studentIdCell.Value != DBNull.Value)
                {
                    int studentId = Convert.ToInt32(studentIdCell.Value);

                    // Open StudentPage_Individual form and pass the selected studentId
                    StudentPage_Individual studentPage = new StudentPage_Individual(studentId);
                    studentPage.Show();
                }
                else
                {
                    MessageBox.Show("Student ID is missing or invalid.");
                }
            }
        }
    }
}
