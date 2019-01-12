using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flower.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        public int ID { set; get; }

        public string Name { set; get; }
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}