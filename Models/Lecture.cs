using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTL1721050348.Models
{
    public class Lecture :Person
    {
        [StringLength(50)]
        [Display(Name = "Khoa")]

        public string Faculty { get; set; }

        [StringLength(50)]
        [Display(Name = "Bộ môn")]

        public string Department { get; set; }
    }
}