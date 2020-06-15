using EsenAppFramework.BarkodApp.DataAccess.Concrete.ReadWrite;
using EsenAppFramework.BarkodApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsenAppFramework.BarkodApp.UI.Helper
{
    public static class FactoryObject
    {
        public static List<Product> Products = new List<Product>();
        public static List<Categories> Categories = new List<Categories>();
        public static List<ProductsCategories> ProductsCategories = new List<ProductsCategories>();
        public static List<Manager> Managers = new List<Manager>();
        public static List<Order> Orders = new List<Order>();
        public static List<OrderDetails> OrderDetails = new List<OrderDetails>();
        public static void SetProduct()
        {
            Products = ReadWriteData.ReadData<List<Product>>("product");
        }
        public static void SetCategory()
        {
            Categories = ReadWriteData.ReadData<List<Categories>>("category");
        }
        public static void SetProductCategory()
        {
            ProductsCategories = ReadWriteData.ReadData<List<ProductsCategories>>("productCategory");
        }
        public static void SetManager()
        {
            Managers = ReadWriteData.ReadData<List<Manager>>("manager");
        }
        public static void SetOrder()
        {
            Orders = ReadWriteData.ReadData<List<Order>>("Order");
        }
        public static void SetOrderDetails()
        {
            OrderDetails = ReadWriteData.ReadData<List<OrderDetails>>("orderdetails");
        }
        public static void SetAllFile()
        {
            SetManager();
            SetProductCategory();
            SetProduct();
            SetCategory();
            SetOrder();
            SetOrderDetails();
        }

        public static void UpdateList(string fileName)
        {
            switch (fileName)
            {
                case "product":
                    SetProduct();
                    break;
                case "category":
                    SetCategory();
                    break;
                case "productCategory":
                    SetProductCategory();
                    break;
                case "manager":
                    SetManager();
                    break;
                default:
                    break;
            }
        }
    }
}
