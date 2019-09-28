

namespace Reg.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
   public enum TypeList
   {
        Hugo,
        Homero,
        Horacio,
        Huevo,
        Heladera
    }
    public class Contact
    {
        [Key]
        public int Friendld { get; set; }
        [Required][Range (5,50)]
        public String Name { get; set; }

        public TypeList List { get; set; }
        [Required]
        public String Email  { get; set; }
        
        [DataTime]
        public int Birthdate { get; set; }

    }
}