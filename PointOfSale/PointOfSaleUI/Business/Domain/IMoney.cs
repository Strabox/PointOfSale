using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleUI.Business.Domain
{
    interface IMoney<T>
    {

        void Add(T money);

        void Subtract(T money);

        void Multiply(int times);

    }
}
