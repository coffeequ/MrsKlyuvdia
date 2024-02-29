using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrsKlyuvdia
{
    interface IObserver
    {
        void update(bool hit, string educate, string advice);
    }
}
