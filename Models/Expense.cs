using System.ComponentModel.DataAnnotations;

namespace FinancialApp.Models
{
    public class Expense
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Informe o tipo do gasto!")]
        public Category Category { get; set; }
        [Required(ErrorMessage = "Informe o nome do gasto!")]
        public string Name { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public double Value { get; set; }

    }
}
