using EsenAppFramework.BarkodApp.DataAccess.Concrete.ReadWrite;
using EsenAppFramework.BarkodApp.Entities.Concrete;
using EsenAppFramework.BarkodApp.UI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EsenAppFramework.BarkodApp.UI.Helper.FormHelper;

namespace EsenAppFramework.BarkodApp.UI
{
    public partial class CategoryDeleteFrm : BaseForm
    {
        public CategoryDeleteFrm()
        {
           
            InitializeComponent();
            SetProperty();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            var response = FactoryObject.Categories;
            if (SeciliKategoriAltindaUrunVarMi(lbCategory.SelectedItem.ToString()))
            {
                MessageBox.Show("Bu kategoriyi silemezsiniz");
                return;
            }
            else
            {
                response.Remove(response.Where(x => x.CategoryName == lbCategory.SelectedItem.ToString()).FirstOrDefault());
                ReadWriteData.DeleteData<Categories>("category",response);
            }
            
            lbCategory.Items.Clear();
           
            KategoriGetir();
        }

        private void CategoryDeleteFrm_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }
        private void KategoriGetir()
        {
            lbCategory.Items.Clear();
            FactoryObject.SetCategory();
            foreach (var item in FactoryObject.Categories)
            {
                lbCategory.Items.Add(item.CategoryName);
            }

        }
        public bool SeciliKategoriAltindaUrunVarMi(string categoryName)
        {
            return FactoryObject.ProductsCategories.Where(x => x.CategoryID == FactoryObject.Categories.Where(y => y.CategoryName == categoryName).FirstOrDefault().CategoryId).Count() > 0 ? true : false;
        }
    }      
    
}
