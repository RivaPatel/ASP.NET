using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
         public class furniture
        {
            public string material;
            public int price;

            public furniture(string material, int price)
            {
                this.material = material;
                this.price = price;
            }


        }
        internal class Table : furniture
        {

            public double height;
            public double surface_area;


            public Table(string material, int price, double height, double surface_area) : base(material, price)
            {
                this.material = material;
                this.price = price;
                this.height = height;
                this.surface_area = surface_area;

            }

            public void display()
            {
                Console.WriteLine("material: " + material);
                Console.WriteLine("price: " + price);
                Console.WriteLine("height: " + this.height);
                Console.WriteLine("surface_area: " + this.surface_area);
            }


        }
    
}
