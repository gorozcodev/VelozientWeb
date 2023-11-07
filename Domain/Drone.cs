namespace VelozientWeb.Domain
{
    public class Drone
    {
        public string Name { get; }
        public int MaxCapacity { get; }
        public int RemainingCapacity { get; set; }
        public List<DeliveryLocation> Deliveries { get; }

        public Drone(string name, int maxCapacity)
        {
            Name = name;
            MaxCapacity = maxCapacity;
            RemainingCapacity = maxCapacity;
            Deliveries = new List<DeliveryLocation>();
        }
    }
}
