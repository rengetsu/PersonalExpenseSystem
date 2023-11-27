using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalExpenseSystem.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CategoryName { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string CategoryIcon { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string CategoryType { get; set; } = "Expense";
    }
}
