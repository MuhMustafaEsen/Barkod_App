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
    public partial class CategoriesAddUpdateFrm : BaseForm
    {
        string tempcategoryID;
        public CategoriesAddUpdateFrm(string _categoryID = null)
        {
         
            tempcategoryID = _categoryID;
            InitializeComponent();
            SetProperty();
            if (tempcategoryID != null)
            {
                ReadWriteData readWriteData = new ReadWriteData();
                var selectedCategory = FactoryObject.Categories.Where(x => x.CategoryId == _categoryID).OrderByDescending(x => x.CreatedDate).FirstOrDefault();
                tbxCategoryName.Text = selectedCategory.CategoryName;
                tbxDescription.Text = selectedCategory.Description;
            }
        }

        private void btnCategoriesAddUpdate_Click(object sender, EventArgs e)
        {
            if (FactoryObject.Categories.Where(x => x.CategoryName == tbxCategoryName.Text).FirstOrDefault() == null)
            {


                HandleException.HandleExceptionYakala(() =>
                {
                    CategoryEkle();
                });

            }
            else
            {
                MessageBox.Show("Bu kategori ekli!");
            }

        }
        public void CategoryEkle()
        {
            string categoryId = tempcategoryID == null ? Guid.NewGuid().ToString() : tempcategoryID;
            string categoryName = tbxCategoryName.Text;
            string description = tbxDescription.Text;

            CRUDHelper.AddCategory(new Categories
            {
                CategoryId = categoryId,
                CategoryName = categoryName,
                Description = description,
                CreatedDate = DateTime.Now
            });
            MessageBox.Show("Kayit oldu");
        }

        private void CategoriesAddUpdateFrm_Load(object sender, EventArgs e)
        {

        }

        private void gbxCategoryAddUpdate_Enter(object sender, EventArgs e)
        {

        }
    }
}
