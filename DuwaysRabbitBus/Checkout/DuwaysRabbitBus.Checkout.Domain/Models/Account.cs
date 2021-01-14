
using System.ComponentModel.DataAnnotations.Schema;

namespace DuwaysRabbitBus.Checkout.Domain.Models
{
    /**
     * Account Model class
     * 
     */ 
    public class Account
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal AccountBalance { get;  set; }
    }
}
