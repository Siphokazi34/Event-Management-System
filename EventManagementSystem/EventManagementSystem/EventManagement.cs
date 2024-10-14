using System;
using System.Collections.Generic;

namespace EventManagementSystem
{
    class EventManagement
    {
        private List<Event> events = new List<Event>();

        public void ManageEvents()
        {
            while (true)
            {
                Console.WriteLine("Event Management");
                Console.WriteLine("1. Create Event");
                Console.WriteLine("2. Update Event");
                Console.WriteLine("3. Delete Event");
                Console.WriteLine("4. View Events");
                Console.WriteLine("5. Back");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateEvent();
                        break;
                    case "2":
                        UpdateEvent();
                        break;
                    case "3":
                        DeleteEvent();
                        break;
                    case "4":
                        ViewEvents();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        private void CreateEvent()
        {
            Console.Write("Enter event name: ");
            string name = Console.ReadLine();
            Console.Write("Enter event date and time (yyyy-mm-dd HH:mm) or press Enter for now: ");
            string input = Console.ReadLine();

            DateTime dateTime;
            if (string.IsNullOrEmpty(input))
            {
                dateTime = DateTime.Now;  // Use current date and time if input is empty
            }
            else
            {
                dateTime = Convert.ToDateTime(input);
            }

            events.Add(new Event { Name = name, DateTime = dateTime });
            Console.WriteLine("Event created successfully.");
        }

        private void UpdateEvent()
        {
            Console.Write("Enter event name to update: ");
            string name = Console.ReadLine();
            Event ev = events.Find(e => e.Name == name);

            if (ev != null)
            {
                Console.Write("Enter new date and time (yyyy-mm-dd HH:mm): ");
                ev.DateTime = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Event updated successfully.");
            }
            else
            {
                Console.WriteLine("Event not found.");
            }
        }

        private void DeleteEvent()
        {
            Console.Write("Enter event name to delete: ");
            string name = Console.ReadLine();
            Event ev = events.Find(e => e.Name == name);

            if (ev != null)
            {
                events.Remove(ev);
                Console.WriteLine("Event deleted successfully.");
            }
            else
            {
                Console.WriteLine("Event not found.");
            }
        }

        private void ViewEvents()
        {
            if (events.Count == 0)
            {
                Console.WriteLine("No events to display.");
                return;
            }

            foreach (var ev in events)
            {
                Console.WriteLine("{ev.Name} - {ev.DateTime:yyyy-MM-dd HH:mm}");
            }
        }
        public class Event
        {
            public string Name { get; set; }
            public DateTime DateTime { get; set; }  // Property to include both date and time
        }
    }
}
