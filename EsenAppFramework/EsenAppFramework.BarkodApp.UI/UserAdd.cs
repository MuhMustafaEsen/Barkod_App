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
    public partial class UserAddFrm : BaseForm
    {
        public UserAddFrm()
        {

            InitializeComponent();
            SetProperty();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userName = tbxUserName.Text;
            string password = tbxPassword.Text;

            CRUDHelper.AddManager(new Manager
            {
                UserName = userName,
                Password = password,
            });
            
            MessageBox.Show("Tamam");
        }
    }
}
