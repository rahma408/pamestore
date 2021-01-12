using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using pamelstore.Control;
using pamelstore.Isi;

namespace pamelstore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,
       OnMenuChangedListener,
       onKeranjangBelanjaChangedListener,
       OnPromoChangedListener
    {
        MainWindowController controller;

        public MainWindow()
        {
            InitializeComponent();
            KeranjangBelanja keranjangBelanja = new KeranjangBelanja(this);
            controller = new MainWindowController(keranjangBelanja);

            listKeranjangBelanja.ItemsSource = controller.getItems();
            listBoxPromo.ItemsSource = controller.getDiskon();

        }

        public void addItemSucceed()
        {
            listKeranjangBelanja.Items.Refresh();
        }

        public void OnMenuSelected(Item item)
        {
            controller.addItem(item);
        }

        public void removeItemSucceed()
        {
            listKeranjangBelanja.Items.Refresh();
        }

        public void addPromoSucceed()
        {
            listBoxPromo.Items.Refresh();
        }



        private void onDaftarMenuClicked(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.SetOnItemSelectedListener(this);
            menu.Show();
        }

        private void onlistKeranjangBelanjaDoubleClicked(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Kamu ingin menghapus item ini?",
                   "Konfirmasi", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ListBox listBox = sender as ListBox;
                Item item = listBox.SelectedItem as Item;
                controller.removeItem(item);
            }
        }

        private void onBtnGantiPromoClicked(object sender, RoutedEventArgs e)
        {
            Promo promo = new Promo();
            promo.SetOnPromoSelectedListener(this);
            promo.Show();


        }

        public void OnPromoSelected(Diskon diskon)
        {
            controller.addDiskon(diskon);
        }
    }

}