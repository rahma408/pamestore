using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamelstore.Isi
{

    public class Diskon
    {
        public string diskon { get; set; }
        public double potongan { get; set; }

        public Diskon(string diskon, double potongan)
        {
            this.diskon = diskon;
            this.potongan = potongan;

        }

        internal bool Any(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}

