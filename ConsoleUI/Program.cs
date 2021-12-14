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
            HashingHelper.CreatePasswordHash("halil25", out passwordHash, out passwordSalt);
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
        }
    }
}