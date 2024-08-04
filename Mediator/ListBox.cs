using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ListBox : UIControl
    {
        private string selection;

        public string Selection
        {
            get { return selection; }
            set
            {
                selection = value;
                _owner.Changed(this);
            }
        }
        public ListBox(DialogBox owner) : base(owner)
        {
        }
    }
}
