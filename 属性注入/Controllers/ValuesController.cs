﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace 属性注入
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public IUserService UserService {  get; set; }

        [HttpGet]
        public IList<User> GetUsers()
        {
            return UserService.GetUsers();
        }

    }
}
