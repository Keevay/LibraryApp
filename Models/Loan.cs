using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Loan
    {
        public int Id { get; set; }

        // Link to the Book
        public int BookId { get; set; }
        public Book? Book { get; set; }

        // Link to the User (Identity)
        public string? UserId { get; set; }

        [ForeignKey("UserId")]
        public IdentityUser? User { get; set; }

        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}