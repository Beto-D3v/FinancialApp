using System.ComponentModel.DataAnnotations;

namespace FinancialApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o título")]
        public string Title { get; set; } = string.Empty;
    }
}
