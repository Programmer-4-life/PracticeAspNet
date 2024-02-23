using System.ComponentModel.DataAnnotations;

namespace FirstApp.Models
{
    public class Category
    { //key for defining that Id is the primary key here
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
