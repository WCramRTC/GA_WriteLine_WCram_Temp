using System;

namespace GA_WriteLine_WCram_Temp
{
    internal class Program
    {
        static void Main(string[] args)
        { // <---- This is an opening curly
          //  Console.WriteLine("Does this run?");

            // Console.WriteLine() - Prints a string and moves to the next line
            // Console.Write() - Prints a string and stays on the same line
            // "String"
            // ; - Semi-Colon

            // Console.WriteLine("Hello, Class!");
            Console.Write("Hello, Class");
            Console.WriteLine("This is a string");

            // Name is in a Write, Quote is in a WriteLine
            Console.Write("1.Edsger W.Dijkstra: ");
            Console.WriteLine("Computer science is no more about computers than astronomy is about telescopes.");
            Console.WriteLine(); // A WriteLine without anything in the parentheses will give you a blank space
            Console.Write("2.Alan Kay: ");
            Console.WriteLine(" The best way to predict the future is to invent it.");

            Console.Write("William Cram: ");
            Console.WriteLine("It's not about things being easy, it's about you being Excellent");

        } // <---- Closing Main Curly Brace

    } // End class

} // End namespace
