using Database_2;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Office2010.Excel;
using MySql.Data.MySqlClient;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Database_2
{
    public partial class Form1 : Form
    {

        DatabaseConnection db = new DatabaseConnection();
        Dictionary<int, student> student = new Dictionary<int, student>();

        List<student> StudentList = new List<student>();
        List<subject> SubjectList = new List<subject>();

        DatabaseConnection databaseConnection = new DatabaseConnection();

        public Form1()
        {
            InitializeComponent();


            student = db.GetStudents();


            foreach (student student in student.Values)
            {
                StudentBox.Items.Add($"{student.ID}: {student.FirstName} {student.LastName} {student.Age} {student.Email}");

            }


        }


        private void studentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubjectBox.Items.Clear();

            if (StudentBox.SelectedItem != null)
            {

                string selectedStudentString = StudentBox.SelectedItem.ToString();

                int selectedStudentId = int.Parse(selectedStudentString.Split(':')[0]);

                Dictionary<int, List<string>> studentSubjects = databaseConnection.GetStudentSubjects(selectedStudentId);


                if (studentSubjects.ContainsKey(selectedStudentId))
                {

                    foreach (var subject in studentSubjects[selectedStudentId])
                    {
                        SubjectBox.Items.Add(subject);
                    }
                }
            }
        }


        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = studenttextBox.Text;

                string[] nameParts = fullName.Split(' ');
                string firstName = nameParts[0];
                string lastName = nameParts.Length > 1 ? nameParts[1] : "";


                student newStudent = new student(0, firstName, lastName, 0, "");


                databaseConnection.SaveStudentToDatabase(newStudent);

                MessageBox.Show("Studenten har lagts till i databasen.", "Lägg till student", MessageBoxButtons.OK, MessageBoxIcon.Information);


                studenttextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchPattern = searchBox.Text;
                Dictionary<int, student> searchResult = db.SearchStudentsByFirstName(searchPattern);

                StudentBox.Items.Clear();

                foreach (var student in searchResult.Values)
                {
                    StudentBox.Items.Add($"{student.ID}: {student.FirstName} {student.LastName}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentBox.SelectedItem != null)
                {
                    string selectedStudentString = StudentBox.SelectedItem.ToString();
                    int selectedStudentId = int.Parse(selectedStudentString.Split(':')[0]);


                    bool deleted = db.DeleteStudent(selectedStudentId);

                    if (deleted)
                    {

                        StudentBox.Items.Remove(StudentBox.SelectedItem);
                        MessageBox.Show("Studenten har tagits bort.", "Borttagning lyckades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Misslyckades med att ta bort studenten.", "Fel vid borttagning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vänligen välj en student att ta bort.", "Ingen student vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentBox.SelectedItem != null)
                {

                    string selectedStudentString = StudentBox.SelectedItem.ToString();
                    int selectedStudentId = int.Parse(selectedStudentString.Split(':')[0]);

                    string newLastName = UpdateBox.Text;

                    bool updated = db.UpdateStudentLastName(selectedStudentId, newLastName);

                    if (updated)
                    {
                        StudentBox.Items.Clear();
                        student = db.GetStudents();
                        foreach (student student in student.Values)
                        {
                            StudentBox.Items.Add($"{student.ID}: {student.FirstName} {student.LastName} {student.Age} {student.Email}");
                        }

                        MessageBox.Show("Efternamnet har uppdaterats.", "Uppdatering lyckades", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Misslyckades med att uppdatera efternamnet.", "Fel vid uppdatering", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vänligen välj en student att uppdatera.", "Ingen student vald", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ett fel uppstod: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}







        
    






    

    




    







    























   






   









    
    














































































