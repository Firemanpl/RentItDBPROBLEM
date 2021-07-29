using Microsoft.AspNetCore.Identity;
using RentItAPI.Entities;
using RentItAPI.Exceptions;
using RentItAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentItAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly AppDbContext _dbcontext;
        private readonly IPasswordHasher<User> _passwordhasher;

        public AccountService(AppDbContext dbContext, IPasswordHasher<User> passwordHasher)
        {
            _dbcontext = dbContext;
            _passwordhasher = passwordHasher;
        }

        public void DeleteUser (User user)
        {
            
        }
        public void RegisterUser(RegisterUserDto dto)
        {
           if (dto.Password == dto.ConfirmPassword)
            {
                var newUser = new User
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Email = dto.Email,
                    PhoneNumber = dto.PhoneNumber,
                    DateOfBirth = dto.DateOfBirth,
                    AccountNumber = dto.AccountNumber,
                };
                var hashedPassword = _passwordhasher.HashPassword(newUser, dto.Password);
                newUser.PasswordHash = hashedPassword;
                _dbcontext.Users.Add(newUser);
                _dbcontext.SaveChanges(); 
            }

           else
            {
                throw new RepeatPasswordException("Values in fields \"Repeat password\" and \"Password\" must be same.");
            }
        }
    }
}
