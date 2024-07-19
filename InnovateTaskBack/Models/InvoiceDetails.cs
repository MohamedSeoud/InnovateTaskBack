using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnovateTaskBack.Models
{
    public class InvoiceDetails
    {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int Id { get; set; }

    public string ProductName { get; set; }
    public int UnitNo { get; init; }
    public decimal price { get; set; }
    public decimal quantity { get; set; }
    public decimal total { get; set; }
    public DateTime expiryDate { get; set; }
    }
}
