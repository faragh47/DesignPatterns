using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface Iterator<T>
    {
        bool hasNext();
        T current();
        void next();
        void push(T item);
        T pop();
    }
}
