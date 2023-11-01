using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Duurzame_Consumentkeuzes.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string? Name { get; set; }    
        public string? Brand { get; set; }
        public string? Type { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Price { get; set; }
        public DateTime? BuildDate { get; set; }
        public ICollection<Customer>? Customers { get; set; }    
        public EnergyLabel? EnergyLabel { get; set; }
        public int? EnergyLabelId { get; set; }
        public string? ImagePath { get; set; }
    }
}
