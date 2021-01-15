using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class PriceList : IPriceList
    {
        List<Comodity> list = new List<Comodity>();

        public PriceList(string[] records)
        {
            records.Select(x => x.Split('\t'))
                   .ToList()
                   .ForEach(x => list.Add(new Comodity(x[0], x[1], int.Parse(x[2]))));
        }

        public PriceList()
        {
            list = new List<Comodity>();
        }

        public Comodity Get(string category, string name)
        {
            return list.Where(x => x.Name == name && x.Category == category).FirstOrDefault();
        }

        public List<Comodity> GetMany(string category, string name)
        {
            return list.Where(x => new String(x.Name.Take(name.Length).ToArray()).ToLower() == name.ToLower() 
                   && new String(x.Category.Take(category.Length).ToArray()).ToLower() == category.ToLower())
                       .ToList();
        }
    }
}
