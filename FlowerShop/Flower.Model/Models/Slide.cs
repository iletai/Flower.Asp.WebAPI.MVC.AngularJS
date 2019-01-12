using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flower.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        public int ID { set; get; }

        public string Name { set; get; }
        public string Description { set; get; }
        public string Image { set; get; }
        public string URL { set; get; }
        public int DisplayOrder { set; get; }
        public bool Status { set; get; }
    }
}