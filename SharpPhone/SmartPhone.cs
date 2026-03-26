using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone
{
    public class SmartPhone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int StorageSizeMb { get; set; }
        public decimal Price { get; set; }

        public SmartPhone(int id, string brand, string model, int storageSizeMb, decimal price)
        {
            Id = id;
            Brand = brand;
            Model = model;
            StorageSizeMb = storageSizeMb; 
            Price = price;
        }

    }
}
