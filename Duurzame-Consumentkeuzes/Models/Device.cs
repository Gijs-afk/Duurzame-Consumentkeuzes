namespace Duurzame_Consumentkeuzes.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string? Name { get; set; }    
        public string? Brand { get; set; }
        public string? Type { get; set; }
        public DateTime? BuildDate { get; set; }
        public ICollection<Customer>? Customers { get; set; }    
        public int? EnergyLabelId { get; set; }
        public int? ImageId { get; set; }
        public virtual Image? Image { get; set; }
    }
}
