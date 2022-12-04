using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Canvas
    {
        private Tool currentTool;

        public Tool CurrentTool { get => currentTool; set => currentTool = value; }

        public void mouseUp(Tool tool)
        {
            tool.mouseUp(currentTool);
        }

        public void mouseDown(Tool tool)
        {
            tool.mouseDown(currentTool);
        }
    }
}
