using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public abstract class clsAbsClients
    {
        public abstract int Id { get; set; }

        public abstract string Name { get; set; }

        public abstract string Pin { get; set; }

        public abstract string RFC { get; set; }

        public abstract int RegimentType { get; set; }

        public abstract string ContactName { get; set; }
    }
}
