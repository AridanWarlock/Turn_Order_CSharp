using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Order
{
    internal class Fighters_comparer : IComparer<Fighter>
    {
        public int Compare(Fighter x, Fighter y)
        {
            if (x.Initiative > y.Initiative)
                return -1;
            if (x.Initiative < y.Initiative)
                return 1;
            if (x.actor != y.actor && x.actor == "Hero")
                return -1;
            return 0;
        }
    }
}
