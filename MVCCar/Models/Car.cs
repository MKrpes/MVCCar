namespace MVCCar.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }=string.Empty;
        public string Manufacturer { get; set; }= string.Empty;
        public string Color { get; set; }=string.Empty;
        public int ProductionYear { get; set; }
        public double Price { get; set; }
    }
}
