using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CaoMinhQuang108.Models
{
    [Table("UniversityCMQ108")]
    public class UniversityCMQ108
    {
        [Key]
        public int UniversityId { get; set; }
         public string UniversityName { get; set; }

    }
}