using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinancialApp.Models
{
    public class Expense
    {
        [Key]
        public Guid Id { get; set; }
        public int CategoryId { get; set; }
        //Navigation Property
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Informe o nome da pessoa!")]
        public string? Person { get; set; }
        [Required(ErrorMessage = "Informe o nome do gasto!")]
        public string? Name { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Informe o valor do gasto")]
        [DataType(DataType.Currency)]
        public double Value { get; set; }

    }
}
