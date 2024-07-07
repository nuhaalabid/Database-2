using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_2
{
    public class subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }


       public List<student> Students{ get; set; } = new List<student>();
   
       
        public subject(int id, string name, string grade)
        {
            Id = id;
            SubjectName = name;
          
        }

       
    }
}
