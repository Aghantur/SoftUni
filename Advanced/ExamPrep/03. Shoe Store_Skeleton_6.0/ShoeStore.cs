using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {

        public ShoeStore(string name, int storageCapacity)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            this.Shoes = new();
        }

        public List<Shoe> Shoes { get; set; }
        public string Name { get; set; }
        public int StorageCapacity { get; set; }



        public int Count()
            => this.Shoes.Count;

        public string AddShoe(Shoe shoe)
        {
            if (this.Shoes.Count < this.StorageCapacity)
            {
                this.Shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";

            }
            else
            {
                return $"No more space in the storage room.";
            }

        }

        public int RemoveShoes(string material)
        {
            return Shoes.RemoveAll(x => x.Material.ToLower() == material.ToLower());


        }
        public List<Shoe> GetShoesByType(string type)
        {
            List<Shoe> shoes = new List<Shoe>();


            shoes = Shoes.Where(x => x.Type.ToLower() == type.ToLower()).ToList();

            return shoes;
        }

        public Shoe GetShoeBySize(double size)
        {
            Shoe shoe = Shoes.FirstOrDefault(x => x.Size == size);

            return shoe;
        }
        public string StockList(double size, string type)
        {
            StringBuilder sb = new();
            sb.AppendLine($"Stock list for size {size} - {type} shoes:");

            foreach (var item in this.Shoes.Where(x => x.Size == size && x.Type == type))
            {
                sb.AppendLine(item.ToString());
            }

            if (this.Shoes.Where(x => x.Size == size && x.Type == type).ToList().Count > 0)
            {

                return sb.ToString().TrimEnd();
            }
            else
            {
                return "No matches found!";
            }
        }
    }
}

