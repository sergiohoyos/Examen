using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Reg.Models
{
    

    public class Contact
    {
          [Key]
        public int Friendld { get; set; }
        [Required][Range (5,50)]
        public String Name { get; set; }

        public int list { get; set; }
        [Required]
        public String Email  { get; set; }
        
        [DataTime]
        public int Birthdate { get; set; }

    }
}