using RentItAPI.Entities;
using RentItAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentItAPI.Services
{
    public interface IAccountService
    {
        void RegisterUser(RegisterUserDto dto);
        // void ChangeAccountDetails()
        void DeleteUser(User user);
    }
}
