using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }
       
    }
}
