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
    public partial class Login : BaseForm
    {
        Form Mainform;
        public Login(Form _Mainform)
        {
            InitializeComponent();
            Mainform = _Mainform;
            SetProperty();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FactoryObject.SetManager();
            string kullaniciAdi = tbxKullaniciAdi.Text;
            string password = tbxPassword.Text;
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(password))
            {

                foreach (var item in FactoryObject.Managers)
                {
                    if (kullaniciAdi == item.UserName && password == item.Password)
                    {
                        FactoryObject.SetAllFile();
                        MainPage mainPage = new MainPage(this);
                        
                        this.Hide();
                        mainPage.Show();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bos geçmeyiniz");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
           

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Mainform.Close();
        }
    }
}
