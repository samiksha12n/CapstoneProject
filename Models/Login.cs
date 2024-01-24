using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapstoneProject.Models
{
    [Table("Login")]
    public class Login
    {
        [Key]
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "User Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}