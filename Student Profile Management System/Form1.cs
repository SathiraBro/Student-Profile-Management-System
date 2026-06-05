using Microsoft.Data.SqlClient;
using System.Data;

namespace Student_Profile_Management_System
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();


            if (f2.ShowDialog() == DialogResult.OK)
            {
                if (f2.student != null)
                {
                    AddStudentToDB(f2.student);

                }
            }
        }
        private void UpdataBtn_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();

            if (f2.ShowDialog() == DialogResult.OK)
            {
                if (f2.student != null)
                {
                    //Update details
                    UpdateStudent(f2.student);
                }
            }

        }


        private void RefreshForm()
        {
            Database db = new Database();
            SqlConnection con = db.GetConnection();


            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            StudentsGridView.DataSource = dt;

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            RemoveStudentFromDB();
        }

        void AddStudentToDB(Student s)
        {
            Database db = new Database();
            SqlConnection con = db.GetConnection();

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Student(StudentName,Age,Gender) VALUES(@StudentName,@Age,@Gender)", con);


            cmd.Parameters.AddWithValue("@StudentName", s.Student_Name);
            cmd.Parameters.AddWithValue("@Age", s.Age);
            cmd.Parameters.AddWithValue("@Gender", s.Gender);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            RefreshForm();
        }

        void RemoveStudentFromDB()
        {
            if (StudentsGridView.CurrentRow == null)
            {
                MessageBox.Show("Please Select a row!");
            }
            else
            {
                int id = Convert.ToInt32(StudentsGridView.CurrentRow.Cells["ID"].Value);

                Database db = new Database();
                SqlConnection con = db.GetConnection();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Student WHERE ID = @ID", con);

                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                RefreshForm();
            }
        }

        void UpdateStudent(Student s)
        {
            Database db = new Database();
            SqlConnection con = db.GetConnection();

            if (StudentsGridView.CurrentRow == null)
            {
                MessageBox.Show("Please Select a row!");
            }
            else
            {
                int id = Convert.ToInt32(StudentsGridView.CurrentRow.Cells["ID"].Value);



                SqlCommand cmd = new SqlCommand(
                    "UPDATE Student SET StudentName = @StudentName, Age = @Age, Gender = @Gender WHERE ID = @ID", con);

                cmd.Parameters.AddWithValue("@StudentName", s.Student_Name);
                cmd.Parameters.AddWithValue("@Age", s.Age);
                cmd.Parameters.AddWithValue("@Gender", s.Gender);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                RefreshForm();
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            SqlConnection con = db.GetConnection();

            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                RefreshForm();
            }
            else
            {

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student WHERE StudentName LIKE @name", con);
                da.SelectCommand.Parameters.AddWithValue("@name", "%" + SearchBox.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                StudentsGridView.DataSource = dt;
            }

        }
    }
}
