using EsenAppFramework.BarkodApp.DataAccess.Concrete.ReadWrite;
using EsenAppFramework.BarkodApp.Entities.Concrete;
using EsenAppFramework.BarkodApp.UI.FluentValidation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EsenAppFramework.BarkodApp.UI.Helper
{
    public static class CRUDHelper
    {
        public static void AddProduct(Product product)
        {
            ProductValidator productValidator = new ProductValidator();
            var result = productValidator.Validate(product);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            else
            {
                ReadWriteData.WriteDataTest<Product>(product, "product");
            }
            FactoryObject.SetProduct();
            
        }
        public static void AddProductCategory(ProductsCategories productsCategories)
        {

            ReadWriteData.WriteDataTest<ProductsCategories>(productsCategories, "productCategory");
            FactoryObject.SetProductCategory();
        }
        public static void AddCategory(Categories categories)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            var result = categoryValidator.Validate(categories);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
            else
            {
                ReadWriteData.WriteDataTest<Categories>(categories, "category");
            }
            
            FactoryObject.SetCategory();
        }
        public static void AddOrder(Order order)
        {
          ReadWriteData.WriteDataTest<Order>(order, "order");
          FactoryObject.SetOrder();
        }
        public static void AddOrderDetails(OrderDetails orderDetail)
        {
            ReadWriteData.WriteDataTest<OrderDetails>(orderDetail, "orderdetails");
            FactoryObject.SetOrderDetails();
        }
        public static void AddManager(Manager manager)
        {
            ReadWriteData.WriteDataTest<Manager>(manager, "manager");
            FactoryObject.SetManager();
        }
        public static void AddException(System.Exception Exception)
        {
            ReadWriteData.WriteDataTest<System.Exception>(Exception, "exception");
        }

    }
    
}

