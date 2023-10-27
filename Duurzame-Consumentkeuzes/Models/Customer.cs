using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Duurzame_Consumentkeuzes.Models
{
    public class Customer : IdentityUser
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Budget { get; set; }
        public ICollection<Device>? Devices { get; set; }
        public ICollection<EnergyLabel>? EnergyLabels { get; set; }

    }
}
