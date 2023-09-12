using System;
using CMS.UI.Models;

namespace CMS.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Staff staff = new Staff();

            student.firstName = "Rossana";
            Console.WriteLine(student.firstName);
        }
    }
}
