using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            this.Vehicles = new();
        }

        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public int GetCount()
           => this.Vehicles.Count;
        public void AddVehicle(Vehicle vehicle)
        {
            if (this.Vehicles.Count < this.Capacity)
            {
                this.Vehicles.Add(vehicle);

            }
            
        }
        public bool RemoveVehicle(string vin)
        {
            Vehicle vehicle = this.Vehicles.FirstOrDefault(x => x.VIN == vin);

            bool isRemoved = this.Vehicles.Remove(vehicle);
            return isRemoved;
        }
        public Vehicle GetLowestMileage() => this.Vehicles.OrderBy(x => x.Mileage).FirstOrDefault();

        public string Report()
        {
            StringBuilder sb = new();

            foreach (var item in Vehicles)
            {
                sb.AppendLine(item.ToString());
            }

            Console.WriteLine("Vehicles in the preparatory:");

            return sb.ToString().TrimEnd();
        }
    }
}
