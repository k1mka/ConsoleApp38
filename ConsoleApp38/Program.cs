namespace ConsoleApp38
{

    public class Gera
    {
        public int a;
        public static int b;
    }

    internal class Program
    {



        static void Main(string[] args)
        {
            Gera.b = 15;

            Gera gera1 = new Gera();
            gera1.a = 12;

            Gera gera2 = new Gera();
            gera1.a = 15;




        }





    }
}

