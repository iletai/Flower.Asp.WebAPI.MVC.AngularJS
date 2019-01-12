using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flower.Model.Models
{
    [Table("VistorStatic")]
    public class VistorStatic
    {
        [Key]
        public int ID { set; get; }

        public DateTime VistedDate { set; get; }
        public string IPAdress { set; get; }
    }
}