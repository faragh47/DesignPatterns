using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class BrushTool : Tool
    {
        public void mouseDown(Tool tool)
        {
            Console.WriteLine("BrushTool Mouse Down");
        }

        public void mouseUp(Tool tool)
        {
            Console.WriteLine("BrushTool Mouse up");
        }
    }
}
