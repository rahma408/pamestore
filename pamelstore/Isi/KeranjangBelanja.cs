using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamelstore.Isi
{
    class KeranjangBelanja
    {
        List<Item> itemkeranjangBelanja;
        public List<Diskon> diskonDipakai;
        Payment payment;
        onKeranjangBelanjaChangedListener onKeranjangBelanjaChangedListener;
        private MainWindow mainWindow;

        public KeranjangBelanja(Payment payment, onKeranjangBelanjaChangedListener onKeranjangBelanjaChangedListener)
        {
            this.payment = payment;
            this.onKeranjangBelanjaChangedListener = onKeranjangBelanjaChangedListener;
            this.itemkeranjangBelanja = new List<Item>();
            this.diskonDipakai = new List<Diskon>();
        }

        public KeranjangBelanja(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public List<Item> getItems()
        {
            return this.itemkeranjangBelanja;
        }

        public List<Diskon> getDiskon()
        {
            return this.diskonDipakai;
        }

        public void addDiskon(Diskon diskon)
        {
            this.diskonDipakai.Clear();
            this.diskonDipakai.Add(diskon);
            this.onKeranjangBelanjaChangedListener.addPromoSucceed();
            calculateSubTotal();
        }

        public void addItem(Item item)
        {
            this.itemkeranjangBelanja.Add(item);
            this.onKeranjangBelanjaChangedListener.addItemSucceed();
            calculateSubTotal();
        }

        public void removeItem(Item item)
        {
            this.itemkeranjangBelanja.Remove(item);
            this.onKeranjangBelanjaChangedListener.removeItemSucceed();
            calculateSubTotal();
        }

        private void calculateSubTotal()
        {
            double subTotal = 0;
            double promo = 0;
            foreach (Item item in itemkeranjangBelanja)
            {
                subTotal += item.price;

            }
            foreach (Diskon diskon in diskonDipakai)
            {
                if (diskon.potongan == 10000)
                {
                    promo = 10000;
                }
                else if (diskon.potongan == 30000)
                {

                    promo = (subTotal * 30 / 100);

                    if (promo > 30000)
                    {
                        promo = 30000;
                    }
                    else
                    {
                        promo = (subTotal * 30 / 100);
                    }

                }
                else if (diskon.potongan == 25000)
                {
                    promo = (subTotal * 25 / 100);

                }

            }

            //payment.updateTotal(subTotal, promo);
        }
    }


    interface onKeranjangBelanjaChangedListener
    {
        void removeItemSucceed();
        void addItemSucceed();
        void addPromoSucceed();

    }
}
