using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flower.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
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

        public virtual IEnumerable<Menu> Menus //create key foriegn
        {
            get;set;
        }
    }
}