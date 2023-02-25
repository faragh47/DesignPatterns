using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class Task
    {
        private readonly Audit _audit;

        public Task(Audit audit)
        {
            _audit = audit;
        }
        public Task()
        {
            _audit = new Audit();
        }

        public void execute()
        {
            _audit.record();
            doExecute();
        }

        protected  abstract void doExecute();
        
    }
}
