using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserDirectory.Api.Models
{
    public class User
    {
        [Required]
         public int Id { get; set; }

        
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name can't be longer than 50 characters")]


        public string Name { get; set; } 

        [Required(ErrorMessage = "Age is required")]
        [Range(10, 100, ErrorMessage = "Age must be between 10 and 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; } 

        public string State { get; set; } 
                                                                     
        public string Pincode { get; set; } 
    }
}
