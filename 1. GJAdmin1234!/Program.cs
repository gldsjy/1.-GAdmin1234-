using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.GJAdmin1234_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;
            int attempts = 3;
            string correctusername = "Admin";
            string correctpassword = "Admin1234!";
            while (attempts > 0)
            {
                Console.Write("username: ");
                username = Console.ReadLine();
                Console.Write("password: ");
                password = Console.ReadLine();
                if (username == correctusername && password == correctpassword) 
                {
                    Console.WriteLine("");
                    Console.WriteLine("Login successful");
                    break;
                }
                else 
                {                   
                    attempts--;
                    Console.WriteLine("Invalid credentials");
                    Console.WriteLine("");
                    Console.WriteLine(attempts + " attempt/s left");
                    Console.WriteLine("");
                }
            }
            if (attempts == 0)
            {
                Console.WriteLine("Maximum attempts reached");
            }
            Console.ReadKey();   
        }
    }
}
