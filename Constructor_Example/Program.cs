using System;
using System.Text;
using System.Threading.Channels;

namespace Constructor_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            DefConstructor dc = new DefConstructor();
            dc.DoThis();
            AddConstructor ac = new AddConstructor();
            ac.DoThat();

        }
    }
    public class DefConstructor
    {
        public void DoThis()
        {
            Console.WriteLine("DoThis has run...");
        }

    }
    public class AddConstructor
    {
        public AddConstructor()
        {
            Console.WriteLine("the constructor has been called...");
        }
        public void DoThat()
        {
            Console.WriteLine("DoThat has has been executed...");
        }

    }



}
