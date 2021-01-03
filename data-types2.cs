using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Lonetree";

            string message = "My name is " + FirstName + LastName;

            string capsMessage = message.ToUpper();

            string lowerMessage = message.ToLower();
            
            Console.WriteLine(message)
            Console.Read()
        }
    }
}