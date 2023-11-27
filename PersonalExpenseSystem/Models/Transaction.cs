using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalExpenseSystem.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int CategoryId {  get; set; }
        public Category Category { get; set; }

        public int TransactionAmount { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? TransactionNote { get; set; }
        
        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }
}
