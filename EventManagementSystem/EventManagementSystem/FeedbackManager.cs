using System;
using System.Collections.Generic;

namespace EventManagementSystem
{
    class FeedbackManager
    {
        private List<Feedback> feedbackList = new List<Feedback>();

        public void CollectFeedback()
        {
            Console.Write("Enter event name: ");
            string eventName = Console.ReadLine();
            Console.Write("Enter feedback: ");
            string feedbackText = Console.ReadLine();

            feedbackList.Add(new Feedback { EventName = eventName, FeedbackText = feedbackText });
            Console.WriteLine("Feedback collected successfully.");
        }
        public class Feedback
        {
            public string EventName { get; set; }
            public string FeedbackText { get; set; }
        }
    }
}
