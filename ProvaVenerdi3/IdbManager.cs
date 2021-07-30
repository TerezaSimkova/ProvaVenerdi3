using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaVenerdi3
{
    interface IdbManager<T>
    {
        public List<T> Fetch();
    }
}
