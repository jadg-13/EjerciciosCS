using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1.models
{
    public class Student
    {
        public String Cif {  get; set; }
        public String Names { get; set; }

        public DateTime BirthDay { get; set; }

        public double Grades { get; set; }

        public Student(string cif, string names, DateTime birthDay, double grades)
        {
            Cif = cif;
            Names = names;
            BirthDay = birthDay;
            Grades = grades;
        }

        public Student() { }

        public String GetScholarShip()
        {
            if (Grades >= 95 && Grades <= 98) return "Beca 85%";
            else if (Grades >= 99) return "Beca 90%";
            return "No aplica a Beca";
        }
    }
}
