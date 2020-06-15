using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsenAppFramework.BarkodApp.UI.Helper
{
    public static class FileHelper
    {
        private static void CreateDirectory()
        {
            if (!Directory.Exists(@"C:\TestFile"))
               Directory.CreateDirectory(@"C:\TestFile");
        }

        private static void CreateFile()
        {
            if (!File.Exists(@"C:\TestFile\product.txt"))
            {
                File.Create(@"C:\TestFile\product.txt").Close();
            }
            if (!File.Exists(@"C:\TestFile\category.txt"))
            {
                File.Create(@"C:\TestFile\category.txt").Close();
            }
            if (!File.Exists(@"C:\TestFile\productCategory.txt"))
            {
                File.Create(@"C:\TestFile\productCategory.txt").Close();
            }
            if (!File.Exists(@"C:\TestFile\order.txt"))
            {
                File.Create(@"C:\TestFile\order.txt").Close();
            }
            if (!File.Exists(@"C:\TestFile\orderdetails.txt"))
            {
                File.Create(@"C:\TestFile\orderdetails.txt").Close();
            }
            if (!File.Exists(@"C:\TestFile\exception.txt"))
            {
                File.Create(@"C:\TestFile\exception.txt").Close();
            }
            if (!File.Exists(@"C:\TestFile\manager.txt"))
            {
                File.Create(@"C:\TestFile\manager.txt").Close();
                CRUDHelper.AddManager(new Entities.Concrete.Manager { Password = "1", UserName = "m" });
            }
        }

        public static void LoadFile()
        {
            CreateDirectory();
            CreateFile();
            
        }
    }
}
