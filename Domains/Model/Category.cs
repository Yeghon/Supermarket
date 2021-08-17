using System.Collections.Generic;

namespace SuperMarket.Domains.Model
{
    public class Category
    {
        public int Id {get; set;}
        public string Name { get; set;}
        public IList<Product> Products {get; set;} = new List<Product>();


    }
}