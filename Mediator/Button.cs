using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Button : UIControl
    {
        private bool isEnable;

        public bool IsEnabled
        {
            get { return isEnable; }
            set
            {
                isEnable = value;
                _owner.Changed(this);
            }
        }
        public Button(DialogBox owner) : base(owner)
        {
        }
    }
}
