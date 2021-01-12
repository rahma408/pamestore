using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pamelstore.Isi;

namespace pamelstore.Control
{
    class PromoController
    {
        private List<Diskon> diskon;

        public PromoController()
        {
            diskon = new List<Diskon>();
        }

        public void addPromo(Diskon diskon)
        {
            this.diskon.Add(diskon);
        }

        public List<Diskon> getDiskon()
        {
            return this.diskon;
        }
    }
}