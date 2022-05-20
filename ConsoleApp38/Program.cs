using System;


namespace ConsoleApp38
{

    static class MyExtentions
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine(dateTime);
        }

    }




    internal class Program
    {



        static void Main(string[] args)
        {

            DateTime currentDataTime = DateTime.Now;

            DateTime.Now.Print();

        }





    }
}

