using System;

namespace Hw_Simple_School_managemeent_25._05._2022
{
    class Program
    {
        static void Main(string[] args)
        {

            //User person = new User("Tamerlan", "Alimardanli", "atamerlan", "tima");
            User person = new User 
            {
                Name = "Tamerlan",
                Surname = "Alimardanli",
                Username = "atamerlan",
                Password = "tima"
            };

            //User person1 = new Student("Tural", "Shixaliyev", "shixat", "passtur", 90);

            //User person2 = new Student("Yasen", "Mammadov", "yasma", "mampass", 85);
            User person1 = new Student 
            { 
            Name = "Tural",
            Surname = "Shixaliyev",
            Username = "shixat",
            Password = "passtur",
            Grade = 90
            };
            User person2 = new Student 
            {
                Name = "Yasen",
                Surname = "Mammadov",
                Username = "yasma",
                Password = "mampass",
                Grade = 85
            };

            //User person3 = new User("Rabil", "Salmanov", "rabisal", "zabzal");
            User person3 = new User 
            {
                Name = "Rabil",
                Surname = "Salmanov",
                Username = "rabisal",
                Password = "zabzal"

            };
            User[] users = { person, person1, person2, person3 };

            Console.WriteLine("Istifadeci adininizi daxil edin : ");
            string username = Console.ReadLine();
            Console.WriteLine("Password daxil edin : ");
            string password = Console.ReadLine();
            bool flag = false;
            foreach (var per in users) 
            {
                if (per.Username == username && per.Password == password && per is Student)
                {
                    flag = true;
                    per.GetGrade();
                    break;
                }
                //else 
                //{
                //    Console.WriteLine("Istifadeci adi ve ya shifre sehvdi");
                //    break;
                //}

            }
            if(!flag)
            {
                Console.WriteLine("Bu istifadeci telebe deyil");
            }
        }
    }
}
