using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class BrowserHistory
    {
        public BrowserHistory()
        {
            Urls=new List<string>();
        }

        public void Init()
        {
            Iterator<string> iterator = new ListIterator(this);

            iterator.push("a");
            iterator.push("b");
            iterator.push("c");
            iterator.push("d");
        }

        public List<string> Urls { get; set; }

        public Iterator<string> CreateIterator()
        {
           return new ListIterator(this);
        }

    }
}
