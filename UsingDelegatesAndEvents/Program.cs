using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegatesAndEvents
{
    public delegate void Notifier(string message);

    internal class Program
    {
        static void Main(string[] args)
        {
            var messenger = new ShowMessage();

            Console.WriteLine("Press any key to create the delegate...");
            Console.ReadKey(true);

            // Create a delegate instance and assign the method to it
            Notifier notifier = messenger.ShowMessageOnScreen;

            // Invoke the delegate to display the message on the screen
            notifier("Hello, this is a message displayed on the screen!");

            Console.WriteLine("\nPress any key to change the delegate to send an email...");
            Console.ReadKey(true);

            // Change the delegate to point to the method that simulates sending an email
            notifier += messenger.SendMessageByEmail;

            // Invoke the delegate again to display the message on the screen and simulate sending an email
            notifier("Hello, this is a new important message!");

            Console.ReadKey(true);
        }
    }

    public class ShowMessage
    {
        public void ShowMessageOnScreen(string message)
        {
            Console.WriteLine($"\n[Message on Screen]: {message}");
        }

        public void SendMessageByEmail(string message)
        {
            Console.WriteLine($"\n[Message Sent by Email (Simulation)]: {message}");
        }
    }
}
