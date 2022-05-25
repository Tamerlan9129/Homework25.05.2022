using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_Simple_School_managemeent_25._05._2022
{
    class User
    {
        //public User(string name, string surname, string username, string password) 
        //{
        //    Name = name;
        //    Surname = surname;
        //    Username = username;
        //    Password = password;
        
        //}
        public string Name;
        public string Surname;
        public string Username;
        public string Password;

        public virtual void GetGrade() 
        {
            //Console.WriteLine("Bu istifadeci telebe deyil");
        }
    }
}
