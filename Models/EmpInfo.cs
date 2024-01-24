using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapstoneProject.Models
{
    [Table("EmpInfo")]
    public class EmpInfo
    {
        [Key]
        public string EmailId { get; set; }
        public string Name { get; set; }
        public DateTime DOJ { get; set; }
        public int PassCode { get; set; }
    }
}