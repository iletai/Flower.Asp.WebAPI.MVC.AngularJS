using System.ComponentModel.DataAnnotations;

namespace Flower.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public string ID { set; get; }

        public string Name { set; get; }
        public string Type { set; get; }
    }
}