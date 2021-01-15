using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public interface IPriceList
    {
        Comodity Get(string category, string name);

        List<Comodity> GetMany(string category, string name);
    }
}
