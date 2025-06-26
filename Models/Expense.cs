using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models
{
    public class Expense
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public double Amount { get; set; }
        [Required]
        public string Category { get; set; } = null!;
        public DateTime Date { get; set; } = DateTime.Now;
        

        /*public Expense(int id, string description, double amount, DateTime date, string category)
        {
            Id = id;
            Description = description;
            Amount = amount;
            Date = date;
            Category = category;
        }*/
    }
}