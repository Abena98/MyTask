using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public class Warehouse : IWarehouse
    {
        Dictionary<Comodity, int> dict = new Dictionary<Comodity, int>();

        public Warehouse(string[] records, PriceList list)
        {
            var dictionary = new Dictionary<Tuple<string, string>, int>();
            records.Select(x => x.Split('\t'))
                   .ToList()
                   .ForEach(y => dictionary.Add(Tuple.Create(y[0], y[1]), int.Parse(y[2])));
            var priceList = list.GetMany("", "");
            priceList.Where(x => dictionary.ContainsKey(Tuple.Create(x.Category, x.Name)))
                     .ToList()
                     .ForEach(x => dict[x] = dictionary[Tuple.Create(x.Category, x.Name)]);
        }

        public void Add(Comodity comodity, int count)
        {
            if (!dict.ContainsKey(comodity)) dict.Add(comodity, count);
            else dict[comodity] += count;
        }

        public void Sale(Comodity comodity, int count)
        {
            if (!dict.ContainsKey(comodity)) throw new Exception("Необходимого товара нет на складе");
            if (dict[comodity] < count) throw new Exception("Необходимого количества нет на складе");
            dict[comodity] -= count;
            if (dict[comodity] == 0) dict.Remove(comodity);
        }

        public int Count(Comodity comodity)
        {
            return !dict.ContainsKey(comodity) ? 0 : dict[comodity];
        }

        public int CountAll()
        {
            return dict.Select(x => x.Value).Sum();
        }
    }
}
