using EsenAppFramework.BarkodApp.Entities.Concrete;
using EsenAppFramework.BarkodApp.UI.Helper;
using EsenAppFramework.BarkodApp.UI.Model.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EsenAppFramework.BarkodApp.UI.Helper.FormHelper;

namespace EsenAppFramework.BarkodApp.UI
{
    public partial class OrderFrm : BaseForm
    {
        List<Product_Order> products_order_list;
        Product_Order products_order;
        public OrderFrm()
        {
            InitializeComponent();
            products_order_list = new List<Product_Order>();
            products_order = new Product_Order();
            gbProductInfo.Hide();
            SetProperty();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            var findproduct = FactoryObject.Products.Where(x => x.BarkodNo == tbxBarkodNo.Text).FirstOrDefault();
            if (findproduct != null)
            {
                if (!gbProductInfo.Visible)
                { gbProductInfo.Show(); }
                lblBarcode.Text = findproduct.BarkodNo;
                lblPrice.Text = findproduct.UnitPrice.ToString();
                lblProductName.Text = findproduct.ProductName;

                var findProductCategory = FactoryObject.ProductsCategories.Where(x => x.ProductID == findproduct.ProductId).Select(x => x.CategoryID).ToList();
                if (findProductCategory.Count != 0)
                {
                    lbCategory.DataSource = CategoryHelper.ReturnLastUpdatedCategorybyCategoryID(findProductCategory);
                    lbCategory.DisplayMember = "CategoryName";
                }
                products_order = new Product_Order { Barcod = findproduct.BarkodNo, Price = findproduct.UnitPrice, ProductID = findproduct.ProductId, ProductName = findproduct.ProductName };
            }
            else
            {
                gbProductInfo.Hide();
                MessageBox.Show("Ürün Bulunamadı.");
            }
            BarcodeFocus();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (products_order != null)
            {
                var isExist = products_order_list.Where(x => x.ProductID == products_order.ProductID).FirstOrDefault();
                if (isExist == null)
                {
                    products_order.Piece = decimal.Parse(txbPiece.Text);
                    products_order.TotalPrice = decimal.Parse(lblPrice.Text) * products_order.Piece;
                    products_order_list.Add(products_order);
                }
                else
                {
                    isExist.Piece += decimal.Parse(txbPiece.Text);
                    isExist.TotalPrice = isExist.Price * isExist.Piece;
                }

                products_order = null;
                Clear();
                BarcodeFocus();
                RefreshListView();
                SetTotalPrice();
            }
            else
            {
                MessageBox.Show("Ürün Bulunamadı");
            }
            gbProductInfo.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lwOrder.SelectedItems != null)
            {
                if (lwOrder.SelectedItems.Count > 0)
                {
                    var selected = lwOrder.SelectedItems[0] as ListViewItem;
                    products_order_list.Remove(products_order_list.Where(x => x.Barcod == selected.Text).FirstOrDefault());
                    RefreshListView();
                }
            }

        }

        private void OrderFrm_Load(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            lblBarcode.Text = "";
            lblProductName.Text = "";
            lblPrice.Text = "";
            txbPiece.Text = "1";
        }

        private void BarcodeFocus()
        {
            tbxBarkodNo.Clear();
            tbxBarkodNo.Focus();

        }


        private void RefreshListView()
        {
            lwOrder.Items.Clear();
            var stringArr = new string[4];
            for (int i = 0; i < products_order_list.Count; i++)
            {
                stringArr[0] = products_order_list[i].Barcod;
                stringArr[1] = products_order_list[i].ProductName;
                stringArr[2] = products_order_list[i].Piece.ToString();
                stringArr[3] = products_order_list[i].TotalPrice.ToString();
                lwOrder.Items.Add(new ListViewItem(stringArr));
            }
            SetTotalPrice();
        }

        private decimal SetTotalPrice()
        {
            decimal totalPrice = 0;
            products_order_list.ForEach(x => totalPrice += x.TotalPrice);
            lbTotalPrice.Text = totalPrice.ToString();
            return totalPrice;
        }
        private void txbPiece_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '\b')
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gbProductInfo.Hide();
            lbTotalPrice.Text = "";
            products_order_list.Clear();
            lwOrder.Items.Clear();
        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            if (products_order_list.Count == 0)
            {
                MessageBox.Show("Siparişe ekli ürün bulunamadı.");
                return;
            }
            if (String.IsNullOrEmpty(tbOrderName.Text))
            {
                MessageBox.Show("Sipariş adını giriniz.");
                return;
            }

            DialogResult result = MessageBox.Show("Siparişi Onaylıyormusunuz ?", null, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var newOrder = new Order { CreatedDate = DateTime.Now, Name = tbOrderName.Text, OrderId = Guid.NewGuid().ToString(), TotalPrice = SetTotalPrice() };
                CRUDHelper.AddOrder(newOrder);
                products_order_list.ForEach(x => CRUDHelper.AddOrderDetails(new OrderDetails { OrderId = newOrder.OrderId, Peice = x.Piece, ProductId = x.ProductID, TotalPrice = x.TotalPrice, ProductName = x.ProductName }));
                gbProductInfo.Hide();
                lbTotalPrice.Text = "";
                products_order_list.Clear();
                lwOrder.Items.Clear();
                Clear();
            }
            else
            {

            }
        }
    }
}
