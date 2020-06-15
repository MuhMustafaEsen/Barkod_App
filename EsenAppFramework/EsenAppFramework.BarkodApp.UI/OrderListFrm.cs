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
    public partial class OrderListFrm : BaseForm
    {
        public OrderListFrm()
        {
            InitializeComponent();
            SetProperty();
        }

        private void OrderListFrm_Load(object sender, EventArgs e)
        {
            dgwOrderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwOrderList.DataSource = FactoryObject.Orders;
            lblTotalPrice.AutoSize = true;
        }

        private void dgwOrderList_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void dgwOrderList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            var selectedData = dgwOrderList.CurrentRow.DataBoundItem as Order;
            if(selectedData != null)
            {
                gbOrderDetailsInfo.Text = selectedData.Name;
                var getOrderDetails = FactoryObject.OrderDetails.Where(x => x.OrderId == selectedData.OrderId).ToList();

                lvOrderDetails.Items.Clear();
                var stringArr = new string[4];
                for (int i = 0; i < getOrderDetails.Count; i++)
                {
                    var productInfo = FactoryObject.Products.Where(x => x.ProductId == getOrderDetails[i].ProductId).FirstOrDefault();
                    stringArr[0] = getOrderDetails[i].ProductName;
                    stringArr[1] = getOrderDetails[i].Peice.ToString();
                    stringArr[2] = productInfo.UnitPrice.ToString();
                    stringArr[3] = getOrderDetails[i].TotalPrice.ToString();
                    lvOrderDetails.Items.Add(new ListViewItem(stringArr));
                }
            }
            lblTotalPrice.Text = selectedData.TotalPrice.ToString();
        }
    }
}
