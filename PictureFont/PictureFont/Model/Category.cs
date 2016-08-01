using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureFont.Model
{
    public class Category
    {
        public int Id { get; set; }
        //主题的分类名
        public string CategoryName { get; set; }
        //图像的显示
        public string Image { get; set; }

    }
    public class CategoryManager
    {
        public static void GetCategory(string category, ObservableCollection<Category> categorys)
        {
            var AllCategory = GetCategorys();
            var FilteredCategory = AllCategory.Where(p => p.CategoryName == category).ToList();
            categorys.Clear();
            FilteredCategory.ForEach(p => categorys.Add(p));
        }
        public static List<Category> GetCategorys()
        {
            var item = new List<Category>();
            item.Add(new Category() { Id = 1, CategoryName = "Home", Image = "Image/wallhaven-105688.png" });
            item.Add(new Category() { Id = 2, CategoryName = "Home", Image = "Image/wallhaven-206407.png" });
            item.Add(new Category() { Id = 3, CategoryName = "Home", Image = "Image/wallhaven-206454.jpg" });
            item.Add(new Category() { Id = 4, CategoryName = "Home", Image = "Image/wallhaven-206566.jpg" });
            item.Add(new Category() { Id = 5, CategoryName = "Home", Image = "Image/wallhaven-280851.png" });
            item.Add(new Category() { Id = 6, CategoryName = "Home", Image = "Image/wallhaven-79948.png" });
            return item;
        }
    }
}
