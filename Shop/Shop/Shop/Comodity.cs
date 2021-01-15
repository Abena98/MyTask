using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class Comodity
    {
        public string Category { get; }
        public string Name { get; }
        public int Price { get;}

        public Comodity(string category, string name, int price)
        {
            Category = category;
            Name = name;
            Price = price;
        }

        public static Comodity Parse(string record)
        {
            var info = record.Split('\t').ToArray();
            if (info.Length == 3) return new Comodity(info[0], info[1], int.Parse(info[2]));
            throw new ArgumentException();
        }

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}", Category, Name, Price);
        }

    }
}
