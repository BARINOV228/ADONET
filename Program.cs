using System;
using ADONET.Models;

namespace ADONET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Migrate.GetColumnFromModel(typeof(Student)));
        //    Console.WriteLine(Migrate.GetColumnFromModel(typeof(Kitob)));
        //    Console.WriteLine(Migrate.GetColumnFromModel(typeof(Car)));
        }
    }
}
