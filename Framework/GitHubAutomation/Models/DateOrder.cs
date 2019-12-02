using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Models
{
    class DateOrder
    {
        private string StartOrder { get; set; }
        private string EndOrder { get; set; }

        public DateOrder(string StartOrder, string EndOrder)
        {
            this.StartOrder = StartOrder;
            this.EndOrder = EndOrder;            
        }

        public string getStartOrder() { return StartOrder; }
        public string getEndOrder() { return EndOrder; }
    }
}
