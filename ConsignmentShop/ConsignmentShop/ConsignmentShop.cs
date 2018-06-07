using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ConsignmentShopLibrary.Services;

namespace ConsignmentShop
{
    public partial class ConsignmentShop : Form
    {
        public Store _store;
        public readonly List<Item> _shoppingCartData = new List<Item>();
        public readonly BindingSource _itemsBinding = new BindingSource();
        public readonly BindingSource _cartBinding = new BindingSource();
        public readonly BindingSource _vendorBinding = new BindingSource();
        public decimal _storeProfit;

        public ConsignmentShop()
        {
            InitializeComponent();
            SetUpData();
            UpdateData();

            ItemsListBox.DisplayMember = "Display";
            ItemsListBox.ValueMember = "Display";

            _cartBinding.DataSource = _shoppingCartData;
            ShoppingCartListBox.DataSource = _cartBinding;

            ShoppingCartListBox.DisplayMember = "Display";
            ShoppingCartListBox.ValueMember = "Display";

            _vendorBinding.DataSource = _store.Vendors;
            vendorListBox.DataSource = _vendorBinding;

            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";
        }

        public void SetUpData()
        {
            _store = StoreService.ReadFromFile();

            if (_store == null)
            {
                _store = new Store();

                _store.Vendors.Add(new Vendor { FirstName = "Владимир", LastName = "Путин" });
                _store.Vendors.Add(new Vendor { FirstName = "Ксения", LastName = "Собчак" });

                _store.Items.Add(new Book
                {
                    Title = "Гарри Поттер",
                    Description = "Книга о волшебнике",
                    Price = 250,
                    Owner = _store.Vendors[1]
                });
                _store.Items.Add(new Book
                {
                    Title = "Моби Дик",
                    Description = "Книга о ките",
                    Price = 200,
                    Owner = _store.Vendors[0]
                });
                _store.Items.Add(new Book
                {
                    Title = "Алиса в стране чудес",
                    Description = "Книга о приключениях девочки",
                    Price = 150,
                    Owner = _store.Vendors[1]
                });
                _store.Items.Add(new Book
                {
                    Title = "Маленький принц",
                    Description = "Книга о мальчике и лисе",
                    Price = 100,
                    Owner = _store.Vendors[1]
                });
                _store.Items.Add(new Book
                {
                    Title = "451° по Фаренгейту",
                    Description = "Книга, в которой говорится, что температура воспламенения бумаги составляет 451 ° F",
                    Price = 200,
                    Owner = _store.Vendors[0]
                });
                _store.Items.Add(new Clothes
                {
                    Title = "Пулловер",
                    Description = "Теплая толстовка без пряжек с высоким воротником",
                    Price = 500,
                    Owner = _store.Vendors[0]
                });
                _store.Items.Add(new Clothes
                {
                    Title = "Джинсы",
                    Description = "Жесткие брюки из джинсовой ткани",
                    Price = 450,
                    Owner = _store.Vendors[1]
                });
                _store.Items.Add(new Clothes
                {
                    Title = "Рубашка",
                    Description = "Одежда для верхней части тела из хлопка или аналогичной ткани",
                    Price = 300,
                    Owner = _store.Vendors[0]
                });
                _store.Items.Add(new Clothes
                {
                    Title = "Куртка",
                    Description = "Короткая верхняя одежда, плотно закрепленная",
                    Price = 1100,
                    Owner = _store.Vendors[1]
                });
                _store.Items.Add(new Clothes
                {
                    Title = "Кепка",
                    Description = "Мужской мягкий головной убор с козырьком",
                    Price = 150,
                    Owner = _store.Vendors[0]
                });

                _store.Name = "Rich family";
            }
        }

        public void UpdateData()
        {    
            _itemsBinding.DataSource = _store.Items.Where(x => x.Sold == false).ToList();
            ItemsListBox.DataSource = _itemsBinding;
        }

        public void AddToCart_Click(object sender, EventArgs e)
        {
            var selectedItem = (Item)ItemsListBox.SelectedItem;
            _shoppingCartData.Add(selectedItem);
            _cartBinding.ResetBindings(false);
        }

        public void makePurchase_Click(object sender, EventArgs e)
        {
            foreach(Item item in _shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Commission * item.Price;
                _storeProfit +=(decimal)item.Commission * item.Price;
            }
            _shoppingCartData.Clear();

            _itemsBinding.DataSource = _store.Items.Where(x => x.Sold == false).ToList();

            storeProfitValue.Text = string.Format("{0}₽", _storeProfit);

            _cartBinding.ResetBindings(false);
            _itemsBinding.ResetBindings(false);
            _vendorBinding.ResetBindings(false);
        }

        public void AddBtn_Click(object sender, EventArgs e)
        {
            var formAdd = new FormAdd(this);
            formAdd.Show();
        }

        public void DelBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = (Item)ItemsListBox.SelectedItem;
            _store.Items.Remove(selectedItem);
            _itemsBinding.DataSource = _store.Items.Where(x => x.Sold == false).ToList();
            _itemsBinding.ResetBindings(false);
        }

        public void EditBtn_Click(object sender, EventArgs e)
        {
            var formEdit = new FormEdit(this);
            formEdit.Show();
        }

        private void buttonSaveToXML_Click(object sender, EventArgs e)
        {
            StoreService.SaveToFile(_store);
        }
    }
}
