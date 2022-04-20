using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaskManager.Entity
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
