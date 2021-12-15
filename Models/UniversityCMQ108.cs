using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CaoMinhQuang108.Models
{
    [Table("University")]
    public class University
    {
        [Key]
        public int UniversityId { get; set; }
         public string UniversityName { get; set; }

    }
}