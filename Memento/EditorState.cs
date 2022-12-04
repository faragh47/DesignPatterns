using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class EditorState
    {
        private string content;

        public string Content { get => content; set => content = value; }


        public EditorState(string content)
        {
            this.content = content;
        }

    }
}
