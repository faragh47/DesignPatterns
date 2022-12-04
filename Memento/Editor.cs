using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Editor
    {
        private string content;

        public string Content { get => content; set => content = value; }


        public EditorState createState()
        {
            return new EditorState(content);
        }

        public void restore(EditorState state)
        {
            content = state.Content;
        }

    }
}
