using ConsignmentShopLibrary;
using System;
using System.Windows.Forms;

namespace ConsignmentShop
{
    public partial class FormEdit : Form
    {
        private ConsignmentShop _parentShop;

        public FormEdit(ConsignmentShop prShop)
        {
            _parentShop = prShop;
            InitializeComponent();

            var selectedItem = (Item)_parentShop.ItemsListBox.SelectedItem;

            textBox1.Text = selectedItem.Type;
            textBox2.Text = selectedItem.Title;
            textBox3.Text = selectedItem.Price + "";
        }

        private void CancBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = (Item)_parentShop.ItemsListBox.SelectedItem;

            decimal.TryParse(textBox3.Text, out var price);

            selectedItem.Type = textBox1.Text;
            selectedItem.Title = textBox2.Text;
            selectedItem.Price = price;

            _parentShop.UpdateData();
            Close();
        }
    }
}
