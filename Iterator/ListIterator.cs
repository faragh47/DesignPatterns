using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ListIterator : Iterator<string>
    {
        private readonly BrowserHistory _browserHistory;
        private int index;
        public int Index { get => index; set => index = value; }

        public ListIterator(BrowserHistory browserHistory)
        {
            _browserHistory = browserHistory;
        }

        public string current()
        {
            return _browserHistory.Urls[index];
        }

        public bool hasNext()
        {
            return (index < _browserHistory.Urls.Count);
        }

        public void next()
        {
            index++;
        }

        public void push(string item)
        {
            _browserHistory.Urls.Add(item);
            next();
        }

        public string pop()
        {
            var index = _browserHistory.Urls.Count() - 1;
            index--;
            return _browserHistory.Urls[index];
        }
    }
}
