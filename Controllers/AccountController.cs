using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentItAPI.Entities;
using RentItAPI.Models;
using RentItAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentItAPI.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountservice;
        public AccountController(IAccountService accountService)
        {
            _accountservice = accountService;
        }

        [Route("register")]
        [HttpPut]
        public ActionResult RegisterUser([FromBody] RegisterUserDto dto)
        {
            _accountservice.RegisterUser(dto);
            return Ok(dto);
        }





    }
}
