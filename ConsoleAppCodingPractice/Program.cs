using ConsoleAppCodingPractice.Concepts;
using ConsoleAppCodingPractice.Concepts.DS;
using System;

namespace ConsoleAppCodingPractice
{
    class Program
    {
        static void Main( string[] args )
        {
            IStartMain logic = new MyQueue();
            logic.BootStrap();
            Console.ReadLine();
        }
    }
}
