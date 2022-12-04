using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class History
    {
        private List<EditorState> states = new();

        public void push(EditorState state) { states.Add(state); }


        public EditorState? pop()
        {
            var lastIndex = states.Count - 1;
            EditorState? state = null;
            if (lastIndex >= 0)
            {
                state = states[lastIndex];
                states.RemoveAt(lastIndex);
            }

            return state;
        }


    }
}
