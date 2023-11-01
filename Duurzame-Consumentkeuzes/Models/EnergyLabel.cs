namespace Duurzame_Consumentkeuzes.Models
{
    public class EnergyLabel
    {
        public int Id { get; set; }
        public string? EfficiencyClass { get; set; }
        public string? ImagePath { get; set; }
        public ICollection<Device>? Devices { get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
