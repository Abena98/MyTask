using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public interface IWarehouse
    {
        void Add(Comodity comodity, int count);

        void Sale(Comodity comodity, int count);

        int Count(Comodity comodity);

        int CountAll();
    }
}
