using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int hp, string regNumber)
        {
            Make = make;
            Model = model;
            this.hp = hp;
            RegNumber = regNumber;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int hp { get; set; }
        public string RegNumber { get; set; }

        public override string ToString()
        {
                StringBuilder sb = new();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"HorsePower: {hp}");
            sb.AppendLine($"RegistrationNumber: {RegNumber}");

            return sb.ToString().TrimEnd();
        }
    }
}
