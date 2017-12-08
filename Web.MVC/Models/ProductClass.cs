using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EnF;

namespace baohiem.Models
{
    public class ProductClass
    {
        public Category category { get; set; }

        public List<ProductGroupClass> lstproductGroupClass { get; set; }

    }

    public class ProductGroupClass
    {
        public ProductGroup productGroup { get; set; }

        public List<Product> lstProduct { get; set; }

    }
}