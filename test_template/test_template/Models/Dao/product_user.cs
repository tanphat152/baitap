using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test_template.Models.EF;

namespace test_template.Models.Dao
{
    public class product_user
    {
        public List<Producer> set_data()
        {
            List<Product> temp = new List<Product>();
            Product pr = new Product();
            pr.Name = "Vợt cầu lông Yonex Duora 10";
            pr.IMG = "~/Access/images/products/small/forza-mega-speed-99-nano.jpg";
            pr.Price = 350000;
            temp.Add(pr);
            return temp;
        }
    }
}