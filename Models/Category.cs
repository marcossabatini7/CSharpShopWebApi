using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    // [Table("Categoria")]
    public class Category
    {
        [Key]
        // [Column("Cat_ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        // [DataType("char")]
        public string Title { get; set; }
    }
}