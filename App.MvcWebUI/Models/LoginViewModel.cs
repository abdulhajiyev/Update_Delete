﻿using System.ComponentModel.DataAnnotations;

namespace App.MvcWebUI.Models
{
    public class LoginViewModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}
