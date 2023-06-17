using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        public Catalog(string name, int neededRenovators, string project)
        {
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;

        }

        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }


        public List<Renovator> renovators { get; set; } = new List<Renovator>();


        public int Count { get { return renovators.Count; } }

        public string AddRenovator(Renovator renovator)
        {
            if (renovator.Name == null)
            {
                return "Invalid renovator's information.";
            }

            if (this.Count < this.NeededRenovators && renovator.Rate <= 350)
            {
                this.renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
            else
            {
                return "Invalid renovator's rate.";
            }
        }

        public bool RemoveRenovator(string name)
        {
            Renovator renovator = renovators.FirstOrDefault(x => x.Name == name);
            bool isRemoved = renovators.Remove(renovator);

            return isRemoved;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = renovators.RemoveAll(x => x.Type == type);

            if (count > 0)
            {
                return count;
            }
            else
            {
                return 0;
            }
        }


        public Renovator HireRenovator(string name)
        {

            Renovator renovator = renovators.FirstOrDefault(x => !x.Hired && x.Name == name);

            if (renovator != null)
            {
                renovator.Hired = true;
                return renovator;
            }
            else
            {
                return null;
            }

        }
        public List<Renovator> PayRenovators(int days) => renovators.Where(x => x.Days >= days).ToList();
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {Project}:");
            foreach (var item in renovators.Where(x => !x.Hired))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
