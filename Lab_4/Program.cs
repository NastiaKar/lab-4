using static System.Console;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle mot = new Motorcycle();
            WriteLine(mot);
            WriteLine();
            Scooter sc = new Scooter();
            WriteLine(sc);
            WriteLine();
            Car car = new Car();
            WriteLine(car);
            WriteLine();
            Train tr = new Train();
            WriteLine(tr);
            WriteLine();
            ReadKey();
        }
    }
}