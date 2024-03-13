namespace InventoryManagement.Models
{
    public class ComputerModel
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Department { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Serial_number { get; set; }
        public string Responsive { get; set; }
        public string Hostname { get; set; }
        public string Comments { get; set; }
        public bool is_stored { get; set; }
    }
}
