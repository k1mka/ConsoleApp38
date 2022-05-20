using System;


namespace ConsoleApp38
{

    class Connection
    {
        private static string connectionstring = " local DB";

        public void Print()
        {
            Console.WriteLine("Использую: " + connectionstring);
        }
    }



    internal class Program
    {



        static void Main(string[] args)
        {
            Connection connection = new Connection();
            connection.Print();


        }





    }
}

