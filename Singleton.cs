using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    public class Singleton
    {
        public static int counter = 0;
        public Singleton()
        {
            counter++;
            Console.WriteLine("Counter value: " + counter.ToString());
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
