using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaskManager.Entity
{
    public class User
    {
        [Key]
        public int UserId { get; set; } 
        public string Name { get; set; } 
        public string Surname { get; set; } 
        public string HashPassword { get; set; } 
        public string SaltPassword { get; set; } 
        public bool Admin { get; set; } 
    }
}
