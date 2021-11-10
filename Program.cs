using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton employee = new Singleton();
            employee.PrintMessage("This is the message from employee");

            Singleton student = new Singleton();
            student.PrintMessage("This is the message from student");

            Console.ReadLine();
        }
    }
}
