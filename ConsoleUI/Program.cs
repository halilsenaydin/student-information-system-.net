using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentDal studentDal = new EfStudentDal();
            var result = studentDal.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine(item.Class);
            }
        }
    }
}