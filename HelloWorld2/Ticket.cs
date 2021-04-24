using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Ticket : IEquatable<Ticket>
    {
        public int GoodFor { get; set; }
        
        public Ticket(int goodFor)
        {
            this.GoodFor = goodFor;
        }

        public bool Equals(Ticket other)
        {
            return this.GoodFor == other.GoodFor;
        }
    }
}
