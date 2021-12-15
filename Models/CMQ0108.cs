using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CaoMinhQuang108.Models
{
    [Table("CMQ0108")]
    public class CMQ0108
    {
        [Key]
        [Display(Name = "Mã CMQ")]
        public int CMQId { get; set; }
        [Display(Name = "Tên CMQ")]
        public string CMQName { get; set; }
        [Display(Name = "Giới Tính CMQ")]
        public string CMQGender { get; set; }

    }
}