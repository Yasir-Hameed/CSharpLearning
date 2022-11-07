using OOP.Abstraction;
using OOP.Abstraction.EnCapsulation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ProductMain
    {
        static void Main()
        {
            IProductService productService = new ProductService();
            //ProductModel productObj  = productService.CreateProductObject();

            //productService.ProductAdd(productObj);

            List<ProductModel> productObjts = productService.MultipleObjectsAdd();
           
            productService.AddNewList(productObjts);

            productService.Display();
        }

    }
}
