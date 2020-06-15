using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsenAppFramework.BarkodApp.UI.Exception
{
    public static class HandleException
    {
        public static void HandleExceptionYakala(Action action)
        {
			try
			{
				action.Invoke();
			}
			catch (System.Exception exception)
			{
				System.Windows.Forms.MessageBox.Show(exception.Message);
			}
        }
    }
}
