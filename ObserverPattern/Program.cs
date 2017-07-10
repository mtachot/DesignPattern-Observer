using ObserverPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Subject subject = new Subject();

            new HexaObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.SetState(15);

            Console.WriteLine("\n");

            Console.WriteLine("Second state change: 10");
            subject.SetState(10);

            Console.ReadLine();
        }
    }
}
