using EsenAppFramework.BarkodApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsenAppFramework.BarkodApp.UI.Helper
{
    public static class CategoryHelper
    {
        public static List<Categories> ReturnLastUpdatedCategory()
        {
            var returnCategory = new List<Categories>();
            foreach (var item in FactoryObject.Categories.OrderByDescending(x => x.CreatedDate).ToList())
            {
                if (returnCategory.Where(x => x.CategoryId == item.CategoryId).FirstOrDefault() == null)
                {
                    returnCategory.Add(item);

                }
            }
            return returnCategory;
        }

        public static List<Categories> ReturnLastUpdatedCategorybyCategoryID(List<string> _CategoryList)
        {
            var returnCategory = new List<Categories>();
            foreach (var item in FactoryObject.Categories.Where(x=>_CategoryList.Contains(x.CategoryId)).OrderByDescending(x => x.CreatedDate).ToList())
            {
                if (returnCategory.Where(x => x.CategoryId == item.CategoryId).FirstOrDefault() == null)
                {
                    returnCategory.Add(item);

                }
            }
            return returnCategory;
        }
    }
}
