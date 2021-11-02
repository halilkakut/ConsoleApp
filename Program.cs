using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");
            Console.WriteLine("İsim Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyİsim Giriniz:");
            string lastName = Console.ReadLine(); 

            Console.WriteLine("Merhaba " + name + " " + lastName);
        }
    }
}
