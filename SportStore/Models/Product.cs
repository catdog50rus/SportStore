﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        
        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }


        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        //public string StrPrice { get {return Convert.ToString(Price); } set { } }

        
        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }
    }
}
