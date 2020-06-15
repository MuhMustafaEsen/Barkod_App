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
    public partial class CategorySearchFrm : BaseForm
    {
        
        public CategorySearchFrm()
        {
            InitializeComponent();
            SetProperty();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var cat = new CategoriesAddUpdateFrm((cbxCategory.SelectedItem as Categories).CategoryId);
            cat.MdiParent = this.MdiParent;
            cat.Show();
        }

        private void CategorySearchFrm_Load(object sender, EventArgs e)
        {
            foreach (var item in CategoryHelper.ReturnLastUpdatedCategory())
            {
                cbxCategory.Items.Add(item);

            }
        }

        private void gbCategorySearch_Enter(object sender, EventArgs e)
        {

        }
    }
}
