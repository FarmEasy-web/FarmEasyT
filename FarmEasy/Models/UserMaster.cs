using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FarmEasy.Models
{
    public class UserMaster : IdentityUser
    {
        [Required]
        [Display(Name ="First Name")]
        [RegularExpression("^([a-zA-Z])$", ErrorMessage = "Invalid First Name")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression("^([a-zA-Z])$", ErrorMessage = "Invalid Last Name")]
        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        public string ContactNo { get; set; }

        [Required]
        [RegularExpression("^([a-zA-Z])$", ErrorMessage = "Invalid City")]
        public string City { get; set; }

        public bool IsDeleted { get; set; }
    }
}
