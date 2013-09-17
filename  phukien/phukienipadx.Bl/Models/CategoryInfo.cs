using System.Collections.Generic;

namespace phukienipadx.Bl.Models
{
    public class CategoryInfo
    {
        public CategoryInfo(int parentId, int categoryId, string name)
        {
            this.ParentId = parentId;
            this.CategoryId = categoryId;
            this.Name = name;
            this.Url = ("/Default.aspx?CategoryID=" + CategoryId).ParseSimpleUrl(Name);
        }

        public bool Active { get; set; }
        public int ParentId { get; private set; }
        public int CategoryId { get; private set; }
        public string Name { get; private set; }
        public string Url { get; private set; }

        public IList<CategoryInfo> Categories { get; set; }
        public IList<ProductInfo> Products { get; set; }
    }
}
