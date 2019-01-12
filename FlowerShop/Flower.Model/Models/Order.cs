using Flower.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        public int ID { set; get; }
        public string CustomerName { set; get; }
        public string CustomerAdress { set; get; }
        public string CustomerMobile { set; get; }
        public string CustomerMessage { set; get; }

        public string PaymentMethod { set; get; }
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }
    }
}
