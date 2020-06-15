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
    public partial class ProductDeleteFrm : BaseForm
    {
        
        public ProductDeleteFrm()
        {
            InitializeComponent();
            SetProperty();
        }
        private void UrunGetir()
        {

            FactoryObject.SetProduct();
            foreach (var item in FactoryObject.Products)
            {
                lbProduct.Items.Add(item.ProductName);
            }

        }
        private void ProductDeleteFrm_Load(object sender, EventArgs e)
        {
            UrunGetir();
            
        }
        int index;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var response = FactoryObject.Products;
            if (IsThereProductsInTheOrderTable(lbProduct.SelectedItem.ToString()))
            {
                MessageBox.Show("Bu kategoriyi silemezsiniz");
                return;
            }
            else
            {
                response.Remove(response.Where(x => x.ProductName == lbProduct.SelectedItem.ToString()).FirstOrDefault());
                ReadWriteData.DeleteData<Product>("product", response);
            }
            
            lbProduct.Items.Clear();         
            UrunGetir();
        }

        private void lbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = lbProduct.SelectedIndex;
            
        }
        public bool IsThereProductsInTheOrderTable(string productName) 
        
        {
            return FactoryObject.OrderDetails.Where(x => x.ProductId == FactoryObject.Products.Where(y => y.ProductName == productName).FirstOrDefault().ProductId).Count() > 0 ? true : false;

        }
    }
}
