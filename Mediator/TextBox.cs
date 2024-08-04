using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class TextBox : UIControl
    {
        private string content;
        public string Content
        {
            get { return content; }
            set
            {
                content = value;
                _owner.Changed(this);
            }
        }
        public TextBox(DialogBox owner) : base(owner)
        {
        }

    }
}
