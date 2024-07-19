using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnovateTaskBack.Models
{
    public class Unit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public uint Id { get; set; }
        [ForeignKey(nameof(InvoiceDetails))]
        public int UnitNo { get; set; }
        public InvoiceDetails invoiceDetails { get; set; }

        public string UnitName { get; set; }
    }
}
