using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flower.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID
        {
            set; get;
        }

        [Required]
        public string Name
        {
            set; get;
        }

        [Required]
        public string URL
        {
            set; get;
        }

        public int? DisplayOrder //? alow null
        {
            set; get;
        }

        [Required]
        public int GroupID
        {
            set; get;
        }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup //help point to Menu
        {
            set; get;
        }

        public string Target
        {
            set; get;
        }

        public bool Status
        {
            set; get;
        }
    }
}