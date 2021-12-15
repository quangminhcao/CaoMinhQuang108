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
        [Display(Name = "Mã NVN")]
        public int NVNId { get; set; }
        [Display(Name = "Tên NVN")]
        public string NVNName { get; set; }
        [Display(Name = "Giới Tính NVN")]
        public string NVNGender { get; set; }

    }
}