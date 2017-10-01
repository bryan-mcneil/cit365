using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_BryanMcNeil
{
    class DeskQuote
    {
        public Desk desk { get; set; }
        public double TotalPrice { get; set; }
        public int rushDays { get; set; }
        public bool isRushDay { get; set; }
    }
}
