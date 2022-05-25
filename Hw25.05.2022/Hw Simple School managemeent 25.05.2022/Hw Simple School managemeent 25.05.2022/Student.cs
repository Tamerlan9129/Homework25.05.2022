using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_Simple_School_managemeent_25._05._2022
{
    class Student : User
    {
        //public Student(string name, string surname, string username, string password, int grade)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Username = username;
        //    Password = password;
        //    Grade = grade;
        //}

        public int Grade;

        public override void GetGrade() 
        {
            Console.WriteLine(Grade);
        }
            
    }
}
