using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace proiect.Models
{
    public class Student
    {
        public int ID { get; set; }
        
        
        public String Nume { get; set; }
        public String Prenume { get; set; }


        [Range(1, 3)]
        [Display(Name = "An studiu")]
        public int An_studiu { get; set; }
    }
}
