using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("Ulfet", "Zakirli", 21);
            Console.WriteLine($"First name-{worker.firstname}");
            Console.WriteLine($"Last name-{worker.lastname}");
            Console.WriteLine($"Age-{Worker.age}");

        }
        }

    public class Worker
    {
        public string firstname;
        public string lastname;
        private int age;
    }

    public Worker(string firstname,string  lastname, int age)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
    }
    }
