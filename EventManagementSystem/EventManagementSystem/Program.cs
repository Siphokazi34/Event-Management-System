using System;

namespace EventManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            EventManagement eventManagement = new EventManagement();
            UserRegistration userRegistration = new UserRegistration();
            FeedbackManager feedbackManager = new FeedbackManager();

            while (true)
            {
                Console.WriteLine("Event Management System");
                Console.WriteLine("1. Manage Events");
                Console.WriteLine("2. User Registration");
                Console.WriteLine("3. Ticketing");
                Console.WriteLine("4. User Feedback");
                Console.WriteLine("5. Event Analytics");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        eventManagement.ManageEvents();
                        break;
                    case "2":
                        userRegistration.RegisterUser();
                        break;
                    case "3":
                        Console.WriteLine("Ticketing feature under development.");
                        break;
                    case "4":
                        feedbackManager.CollectFeedback();
                        break;
                    case "5":
                        Console.WriteLine("Event analytics feature under development.");
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
