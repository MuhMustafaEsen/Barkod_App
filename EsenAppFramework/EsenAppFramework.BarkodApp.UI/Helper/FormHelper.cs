using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsenAppFramework.BarkodApp.UI.Helper
{
    public class FormHelper
    {

        public class BaseForm : Form
        {
            public void SetProperty()
            {
                this.BackColor = Color.GhostWhite;
                this.StartPosition = FormStartPosition.Manual;
                //this.Location = new Point(0, 0);
                this.StartPosition = FormStartPosition.CenterScreen;

                if (this.Controls.Count > 0)
                {
                    foreach (Control controller in this.Controls)
                    {
                        SetButtonProperty(controller);
                    }
                }
            }

            public void SetButtonProperty(Control control)
            {

                if (control is GroupBox)
                {
                    var gb = control as GroupBox;
                    foreach (Control cnt in gb.Controls)
                    {
                        SetButtonProperty(cnt);
                    }

                }
                else if (control is Button)
                {
                    var btn = control as Button;
                    btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
                }
            }


        }
    }


}

