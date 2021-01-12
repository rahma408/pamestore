# pamestore
## Description
Program pamelstore ini bertujuan menambahkan item ke sebuah keranjang digital Yang kebutuhan Fungsionalnya :

User dapat melihat daftar makanan yang ditawarkan
User dapat memasukkan atau menghapus makanan pilihan ke dalam keranjang - User dapat melihat subtotal makanan yang terdapat pada keranjang
User dapat melihat daftar voucher yang ditawarkan
User dapat menggunakan salah satu voucher
User dapat melihat harga total termasuk potongannya
Scope of Functions

## Berikut beberapa fungsi dari projek ini

Menambahkan barang dengan teknik mvc
Penambahan fungsi voucher
Penambahan messagebox pada saat menghapus

## logika untuk melakukan kalkulasi terdapat pad class Payment.cs

'''



class Payment { OnPaymentChangedListener paymentListener; public Payment(OnPaymentChangedListener paymentListener) {

        this.paymentListener = paymentListener;
    }

    public void updateTotal(double subTotal, double promo)
    {

        double total = subTotal - promo;
        this.paymentListener.onPriceUpdated(subTotal, total, promo);

    }
}


'''
rahma pamela (19.11.2829)
