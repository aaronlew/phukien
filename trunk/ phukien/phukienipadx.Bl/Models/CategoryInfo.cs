using System.Collections.Generic;

namespace phukienipadx.Bl.Models
{
    public class CategoryInfo
    {
        public CategoryInfo(int parentId, int categoryId, string name, string url)
        {
            ParentId = parentId;
            CategoryId = categoryId;
            Name = name;
            Url = "/nhom-hang/" + url;
        }

        public CategoryInfo(int parentId, int level, int categoryId, string name, string url)
        {
            ParentId = parentId;
            CategoryId = categoryId;
            Name = name;
            Url = "/nhom-hang/" + url;
            Level = level;
        }

        public bool Active { get; set; }
        public int ParentId { get; private set; }
        public int CategoryId { get; private set; }
        public int Level { get; private set; }
        public string Name { get; private set; }
        public string Url { get; private set; }

        public IList<CategoryInfo> Categories { get; set; }
        public IList<ProductInfo> Products { get; set; }
    }
}