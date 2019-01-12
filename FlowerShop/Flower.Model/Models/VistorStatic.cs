using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
