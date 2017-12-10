﻿using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }

}

