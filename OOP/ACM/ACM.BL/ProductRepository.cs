using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {   //Create product class instance
            //pass in the id
            Product product = new Product(productId);

            //retreives defined customer

            //test code
           if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted size set of 4 bright yellow mini sunflowers";
                product.CurrentPrice = 15.96M;
            }
            object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            product.CurrentPrice = 15.96M;
            return product;
        }

        //save customer
        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if(product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call an insert stored procedure
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
