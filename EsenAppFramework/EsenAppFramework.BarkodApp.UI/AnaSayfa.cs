using EsenAppFramework.BarkodApp.DataAccess.Concrete.ReadWrite;
using EsenAppFramework.BarkodApp.Entities.Concrete;
using EsenAppFramework.BarkodApp.UI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EsenAppFramework.BarkodApp.UI.Helper.FormHelper;

namespace EsenAppFramework.BarkodApp.UI
{
    public partial class AnaSayfa : BaseForm
    {
        public AnaSayfa()
        {
            InitializeComponent();
            SetProperty();
            

            FileHelper.LoadFile();
            FactoryObject.SetAllFile();
            gBInfo.Hide();
        }
        Login login;
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (login == null || login.IsDisposed == true)
            {
                CloseForm();
                login = new Login(this);
                login.Parent = this.Parent;
                login.FormClosed += Login_FormClosed;
                this.Hide();
                login.Show();
            }
            else
            {
                login.Activate();
            }
        }
        private void CloseForm()
        {
            login = null;
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                this.MdiChildren[0].Dispose();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {


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
        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
