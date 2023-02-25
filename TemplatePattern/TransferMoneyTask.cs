using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class TransferMoneyTask : Task
    {
        protected override void doExecute()
        {
            Console.WriteLine("TransferMoney");
        }
    }
}
