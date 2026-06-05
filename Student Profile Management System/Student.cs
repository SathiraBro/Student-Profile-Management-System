using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Profile_Management_System
{
    public class Student
    {
        public string Student_Name { get; set; }
        public decimal Age { get;  set; }
        public string Gender { get; set; }

        public Student(string name,decimal age,string gender)
        {
            Student_Name = name;
            Age = age;
            Gender = gender;
        }

    }
}
