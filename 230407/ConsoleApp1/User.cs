using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User
    {
        string[] names = new string[] { "Иван", "Андрей ", "Антон ", "Саша", "Павел" };
        string[] surname = new string[] { "Иванов ", "Андреев", "Антонидзе", "Сандрс", "Павлионо" };

        public string Name;
        public string Surname;
        public int Age;

        public void Trim()
        {
            Name = Name.Trim();
            Surname = Surname.Trim();
        }
        public void Create()
        {
            var random = new Random();
            Name = names[random.Next(5)];
            Surname = surname[random.Next(5)];
            Age = random.Next(30) + 18;
        }
        public bool Validate()
        {
            bool isValid = true;
            if (Name == "" || Name == null)
            {
                isValid = false;
            }
            if (string.IsNullOrEmpty(Surname))
            {
                isValid = false;
            }
            if (Age < 18)
            {
                isValid = false;
            }
            return isValid;

        }
        public void PrintAgeDifference(User[] otherUsers)
        {
            for (int i = 0; i < otherUsers.Length; i++)
            {
                Console.WriteLine(Age - otherUsers[i].Age);
            }
        }

    }
}
