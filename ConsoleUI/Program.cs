using Business.Abstracts;
using Business.Concretes;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash("741963qwe", out passwordHash, out passwordSalt);
            ILoginDal loginDal = new EfLoginDal();


            var login = new Login
            {
                PersonId = 1,
                UserName = "46960020108",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };

            loginDal.Add(login);

            var i =  HashingHelper.VerifyPasswordHash("741963qwe", passwordHash, passwordSalt);
            Console.WriteLine(i);
        }
    }
}