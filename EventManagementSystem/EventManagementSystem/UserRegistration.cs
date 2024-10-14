using System;
using System.Collections.Generic;

namespace EventManagementSystem
{
    class UserRegistration
    {
        private List<User> users = new List<User>();

        public void RegisterUser()
        {
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();
            Console.Write("Enter user email: ");
            string email = Console.ReadLine();

            users.Add(new User { Name = name, Email = email });
            Console.WriteLine("User registered successfully.");
        }
        public class User
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
    }
}
