﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs.Users
{
    public class UserLoginDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
