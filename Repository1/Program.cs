using System;

namespace MyConsoleApplication
{
    class Student
    {
        public string name = "";
        public int id;
    };

    class Program
    {
        static void Main(string[] args)
        {

            var Serra = new Student();
            Serra.name = "Serra";
            Serra.id = 1;

            var Chase = new Student();
            Chase.name = "Chase";
            Chase.id = 2;

            var Keem = new Student();
            Keem.name = "Keem";
            Keem.id = 3;

            System.Console.WriteLine(Keem.name);
            System.Console.WriteLine(Keem.id);

        }
    }

}