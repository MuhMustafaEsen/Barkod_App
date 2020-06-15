using EsenAppFramework.BarkodApp.DataAccess.Concrete.ReadWrite;
using EsenAppFramework.BarkodApp.Entities.Concrete;
using EsenAppFramework.BarkodApp.UI.Helper;
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
    public partial class ProductSearchFrm : BaseForm
    {
        public ProductSearchFrm()
        {


            InitializeComponent();
            SetProperty();


            FileHelper.LoadFile();
            FactoryObject.SetAllFile();
            gBInfo.Hide();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string barkodNo = tbxBarkodNo.Text;

            //foreach (var item in FactoryObject.Products.Where(a => a.BarkodNo == barkodNo))
            //{
            //    ListViewItem listViewItem = new ListViewItem(item.BarkodNo);
            //    listViewItem.SubItems.Add(item.ProductName);
            //    listViewItem.SubItems.Add(item.Quantity.ToString());
            //    listViewItem.SubItems.Add(item.UnitPrice.ToString());
            //    listViewItem.SubItems.Add(item.AdditionDate.ToString());
            //    lwProduct.Items.Add(listViewItem);
            //}
            Clear();
            var findproduct = FactoryObject.Products.Where(x => x.BarkodNo == tbxBarkodNo.Text).FirstOrDefault();
            if (findproduct != null)
            {
                if (!gBInfo.Visible)
                    gBInfo.Show();
                lblBarcod.Text = findproduct.BarkodNo;
                lblPrice.Text = findproduct.UnitPrice.ToString();
                lblProductName.Text = findproduct.ProductName;

                var findProductCategory = FactoryObject.ProductsCategories.Where(x => x.ProductID == findproduct.ProductId).Select(x => x.CategoryID).ToList();
                if (findProductCategory.Count != 0)
                {
                    var categoryList = FactoryObject.Categories.Where(x => findProductCategory.Contains(x.CategoryId)).ToList();
                    lbCategory.DataSource = categoryList;
                    lbCategory.DisplayMember = "CategoryName";
                }
            }
            else
            {
                gBInfo.Hide();
                MessageBox.Show("Ürün Bulunamadı.");
            }
            tbxBarkodNo.Clear();
            tbxBarkodNo.Focus();
        }

        private void Clear()
        {
            lbCategory.DataSource = null;
            lblBarcod.Text = "";
            lblPrice.Text = "";
            lblProductName.Text = "";
        }


        private void ProductSearchFrm_Load(object sender, EventArgs e)
        {
           
        }

        private void gbProductSearch_Enter(object sender, EventArgs e)
        {

        }
    }
}
