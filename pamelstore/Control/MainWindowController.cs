using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pamelstore.Isi;

namespace pamelstore.Control
{
    class MainWindowController
    {
        KeranjangBelanja keranjangBelanja;


        public MainWindowController(KeranjangBelanja keranjangBelanja)
        {
            this.keranjangBelanja = keranjangBelanja;
        }

        public void addItem(Item item)
        {
            this.keranjangBelanja.addItem(item);
        }

        public void removeItem(Item item)
        {
            this.keranjangBelanja.removeItem(item);
        }

        public List<Item> getItems()
        {
            return this.keranjangBelanja.getItems();
        }

        public void addDiskon(Diskon diskon)
        {

            this.keranjangBelanja.addDiskon(diskon);
        }

        public List<Diskon> getDiskon()
        {
            return this.keranjangBelanja.getDiskon();
        }
    }
}

