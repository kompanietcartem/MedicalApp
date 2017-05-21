using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalApp.Models
{
    public class Research
    {
        [Key]
        public int Id { get; set; }
        public string Info { get; set; }
        public string Description { get; set; }
    }
}