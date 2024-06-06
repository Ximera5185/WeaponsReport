using System;

namespace WeaponsReport
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Database database = new Database();

            database.GetDataSoldiers();

            Console.ReadKey();
        }
    }
}