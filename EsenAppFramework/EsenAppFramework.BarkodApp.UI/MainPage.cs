using EsenAppFramework.BarkodApp.DataAccess.Concrete.ReadWrite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsenAppFramework.BarkodApp.UI
{
    public partial class MainPage : Form
    {
        Form Loginform;
        public MainPage(Form _Loginform)
        {
            InitializeComponent();
            Loginform = _Loginform;
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        UserAddFrm userAddFrm;
        private void kullaniciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userAddFrm == null || userAddFrm.IsDisposed == true)
            {
                CloseForm();
                userAddFrm = new UserAddFrm(); 
                
                userAddFrm.MdiParent = this;
                userAddFrm.FormClosed += UserAdd_FormClosed;
                FormBoyutlandir(userAddFrm.Width,userAddFrm.Height); 


                userAddFrm.WindowState = FormWindowState.Maximized;

                userAddFrm.Show();
            }
            else
            {
                userAddFrm.Activate();
            }
        }
        public void FormBoyutlandir(int width,int height)
        {
            this.Width = width+ 25 ;
            this.Height = height + 65;
            
        }
        private void UserAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            userAddFrm = null;
        }
        ProductAddUpdateFrm productAddUpdateFrm;
        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (productAddUpdateFrm == null || productAddUpdateFrm.IsDisposed == true)
            {
                CloseForm();
                productAddUpdateFrm = new ProductAddUpdateFrm();
                productAddUpdateFrm.MdiParent = this;
                var t = this.MdiChildren;
                productAddUpdateFrm.FormClosed += ProductAddUpdate_FormClosed;
                FormBoyutlandir(productAddUpdateFrm.Width, productAddUpdateFrm.Height);
                productAddUpdateFrm.WindowState = FormWindowState.Maximized;
                productAddUpdateFrm.Show();
            }
            else
            {
                productAddUpdateFrm.Activate();
            }

        }

        private void ProductAddUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            productAddUpdateFrm = null;
        }
        CategoriesAddUpdateFrm categoriesAddUpdateFrm;
        private void katagoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (categoriesAddUpdateFrm == null || categoriesAddUpdateFrm.IsDisposed == true)
            {
                CloseForm();
                categoriesAddUpdateFrm = new CategoriesAddUpdateFrm();
                FormBoyutlandir(categoriesAddUpdateFrm.Width, categoriesAddUpdateFrm.Height);
                categoriesAddUpdateFrm.MdiParent = this;
                categoriesAddUpdateFrm.FormClosed += CategoriesAddUpdateFrm_FormClosed;
                categoriesAddUpdateFrm.WindowState = FormWindowState.Maximized;
                categoriesAddUpdateFrm.Show();
            }
            else
            {
                categoriesAddUpdateFrm.Activate();
            }
        }

        private void CategoriesAddUpdateFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            categoriesAddUpdateFrm = null;
        }
        private void MainPage_Load(object sender, EventArgs e)
        {

            UrunAraFormGetir();
        }
        ProductSearchFrm productSearchFrm;

        void UrunAraFormGetir() 
        {
            if (productSearchFrm == null || productSearchFrm.IsDisposed == true)
            {
                CloseForm();
                productSearchFrm = new ProductSearchFrm();
                FormBoyutlandir(productSearchFrm.Width, productSearchFrm.Height);
                productSearchFrm.MdiParent = this;
                productSearchFrm.FormClosed += ProductSearchFrm_FormClosed;
                productSearchFrm.WindowState = FormWindowState.Maximized;
                productSearchFrm.Show();
            }
            else
            {
                productSearchFrm.Activate();
            }
        }
        private void urunAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunAraFormGetir();
        }

        private void ProductSearchFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            productSearchFrm = null;
        }

        void CloseForm()
        {
            if (this.MdiChildren.Length > 0)
                this.MdiChildren[0].Dispose();
        }
        ProductDeleteFrm productDeleteFrm;
        private void urunSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productDeleteFrm == null || productDeleteFrm.IsDisposed == true)
            {
                CloseForm();
                productDeleteFrm = new ProductDeleteFrm();
                FormBoyutlandir(productDeleteFrm.Width, productDeleteFrm.Height);
                productDeleteFrm.MdiParent = this;
                productDeleteFrm.FormClosed += ProductDeleteFrm_FormClosed;
                productDeleteFrm.WindowState = FormWindowState.Maximized;
                productDeleteFrm.Show();
            }
            else
            {
                productDeleteFrm.Activate();
            }
        }

        private void ProductDeleteFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            productDeleteFrm = null;
        }

        private void katogoriGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (categoriesAddUpdateFrm == null || categoriesAddUpdateFrm.IsDisposed == true)
            {
                CloseForm();
                categoriesAddUpdateFrm = new CategoriesAddUpdateFrm();
                FormBoyutlandir(categoriesAddUpdateFrm.Width, categoriesAddUpdateFrm.Height);
                categoriesAddUpdateFrm.MdiParent = this;
                categoriesAddUpdateFrm.FormClosed += CategoriesAddUpdateFrm_FormClosed;
                categoriesAddUpdateFrm.WindowState = FormWindowState.Maximized;
                categoriesAddUpdateFrm.Show();
            }
            else
            {
                categoriesAddUpdateFrm.Activate();
            }
        }
        CategorySearchFrm CategorySearchFrm;
        private void katagoriAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CategorySearchFrm == null || CategorySearchFrm.IsDisposed == true)
            {
                CloseForm();
                CategorySearchFrm = new CategorySearchFrm();
                FormBoyutlandir(CategorySearchFrm.Width, CategorySearchFrm.Height);
                CategorySearchFrm.MdiParent = this;
                CategorySearchFrm.FormClosed += CategorySearchFrm_FormClosed;
                CategorySearchFrm.WindowState = FormWindowState.Maximized;
                CategorySearchFrm.Show();
            }
            else
            {
                CategorySearchFrm.Activate();
            }
        }

        private void CategorySearchFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CategorySearchFrm = null;
        }
        
        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Loginform.Close();
        }
        OrderFrm orderFrm;
        private void siparisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orderFrm == null || orderFrm.IsDisposed == true)
            {
                CloseForm();
                orderFrm = new OrderFrm();
                FormBoyutlandir(orderFrm.Width, orderFrm.Height);
                orderFrm.MdiParent = this;
                orderFrm.FormClosed += OrderFrm_FormClosed; 
                orderFrm.WindowState = FormWindowState.Maximized;
                orderFrm.Show();
            }
            else
            {
                orderFrm.Activate();
            }
        }

        private void OrderFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            orderFrm = null;
        }
        CategoryDeleteFrm categoryDeleteFrm;
        private void katagoriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (categoryDeleteFrm == null || categoryDeleteFrm.IsDisposed == true)
            {
                CloseForm();
                categoryDeleteFrm = new CategoryDeleteFrm();
                FormBoyutlandir(categoryDeleteFrm.Width, categoryDeleteFrm.Height);
                categoryDeleteFrm.MdiParent = this;
                categoryDeleteFrm.FormClosed += CategoryDeleteFrm_FormClosed;
                categoryDeleteFrm.WindowState = FormWindowState.Maximized;
                categoryDeleteFrm.Show();
            }
            else
            {
                categoryDeleteFrm.Activate();
            }
        }

        private void CategoryDeleteFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            categoryDeleteFrm = null;
        }
        
        private void urunGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        OrderListFrm orderListFrm;
        private void siparisListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orderListFrm == null || orderListFrm.IsDisposed == true)
            {
                CloseForm();
                orderListFrm = new OrderListFrm();
                FormBoyutlandir(orderListFrm.Width, orderListFrm.Height);
                orderListFrm.MdiParent = this;
                orderListFrm.FormClosed += OrderListFrm_FormClosed; ;
                orderListFrm.WindowState = FormWindowState.Maximized;
                orderListFrm.Show();
            }
            else
            {
                orderListFrm.Activate();
            }
        }

        private void OrderListFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            orderListFrm = null;
        }
    }
}
