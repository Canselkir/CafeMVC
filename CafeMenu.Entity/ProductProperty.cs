using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TaskManager.Entity
{
    public class ProductProperty
    {
        [Key]
        public int ProductProperyId { get; set; }
        public int ProductId { get; set; }
        public int PropertyId { get; set; }
        public Product Product{get;set;}
        public Property Property{get;set;}
    }
}
