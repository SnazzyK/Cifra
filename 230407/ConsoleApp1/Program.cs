using ConsoleApp1;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        User[] users = new User[10];
        for (int i = 0; i < users.Length; i++)
        {
            users[i] = new User();
            users[i].Create();
        }
        users[2].Name = "";
        users[5].Age = 2;

        PrintUsers();
        TrimUsers();
        users[0].PrintAgeDifference(users);
        
      
        




        Console.ReadLine();
     //--------------------------------------------------------------------------------------------------------
        void PrintUsers()
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine("Surname:" + users[i].Surname + " Name:" + users[i].Name + " Age:" + users[i].Age);

                if (users[i].Validate() == false)
                {
                    Console.Write("Не корректный --- ");
                }

            }
        }
        void TrimUsers()
        {

            for (int i = 0; i < users.Length; i++)
            {
                users[i].Trim();
            }

        }
       
    }
}