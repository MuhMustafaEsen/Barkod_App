using EsenAppFramework.BarkodApp.DataAccess.Concrete.ReadWrite;
using EsenAppFramework.BarkodApp.Entities.Concrete;
using EsenAppFramework.BarkodApp.UI.Exception;
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
    public partial class ProductAddUpdateFrm : BaseForm
    {
        
        public ProductAddUpdateFrm()
        {
            InitializeComponent();
            SetProperty();

        }

        private void btnProductAddUpdate_Click(object sender, EventArgs e)
        {
            var varmi = FactoryObject.Products.Where(x => x.BarkodNo == tbxBarkodNo.Text).FirstOrDefault();
            if(varmi == null)
            {
                HandleException.HandleExceptionYakala(() =>
                {
                    ProductEkle();
                });
            }
            else
            {
                MessageBox.Show("Bu barkod numarası ekli.");
            }
          
        }
        
        private void ProductAddUpdateFrm_Load(object sender, EventArgs e)
        {
           
            tbxBarkodNo.Focus();
            lbCategory.DataSource = CategoryHelper.ReturnLastUpdatedCategory();
            lbCategory.ValueMember = "CategoryId";
            lbCategory.DisplayMember = "CategoryName";

        }
        public void ProductEkle() 
        {
            string productId = Guid.NewGuid().ToString();
            string productName = tbxProductName.Text;
            string barkodNo = tbxBarkodNo.Text;
            decimal unitPrice = Convert.ToDecimal(tbxUnitPrice.Text);
            int quantity = Convert.ToInt32(tbxQuantity.Text);
            DateTime additionDate = DateTime.Now;

            CRUDHelper.AddProduct(new Product
            {
                ProductId = productId,
                ProductName = productName,
                BarkodNo = barkodNo,
                Quantity = quantity,
                UnitPrice = unitPrice,
                AdditionDate = additionDate

            });

            foreach (var item in lbCategory.SelectedItems)
            {
                CRUDHelper.AddProductCategory(new ProductsCategories
                {
                    ProductID = productId,
                    CategoryID = (item as Categories).CategoryId,
                });

            }
           
            MessageBox.Show("tamam");
        }

        private void tbxProductName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ','; ;
        }

        private void tbxUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ','; ;
        }
    }
}
