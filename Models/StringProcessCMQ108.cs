using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CaoMinhQuang108.Models
{
    [Table("StringProcessCMQ108")]
    public class StringProcessCMQ108 : CMQ0108
    {
        public string Universisty { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
         }
}
