using System;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ConsignmentShop
{
    public partial class FormAdd : Form
    {

        private ConsignmentShop _parentShop;

        public FormAdd (ConsignmentShop prShop)
        {
            _parentShop = prShop;
            InitializeComponent();
        }

        private void CancBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var type = textBox1.Text;
            var title = textBox2.Text;
            var price = textBox3.Text;

            decimal x;
            decimal.TryParse(price, out x);
            _parentShop._store.Items.Add(new Book()
            {
                Type = type,
                Title = title,
                Price = x,
                Owner = _parentShop._store.Vendors[0]
            });
            _parentShop.UpdateData();
            Close();
        }
    }
}
