using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_2
{
    public class student

    {
       
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        


        public List<subject> Subjects { get; set; } = new List<subject>();
       

        public student(int id, string firstName, string lastName, int age, string email)

        {

            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
        }

       



    }
}
