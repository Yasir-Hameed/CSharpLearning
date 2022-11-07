using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction.EnCapsulation
{
    public class ProductService : IProductService
    {
        List<ProductModel> MasterProducts = new List<ProductModel>();

        public ProductModel CreateProductObject()
        {
            ProductModel prodObj = new ProductModel();

            Console.WriteLine("Enter Product Name");
            prodObj.Name = Console.ReadLine();

            Console.WriteLine("Enter Product Price");
            prodObj.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Product Id");
            prodObj.Id = int.Parse(Console.ReadLine());

            prodObj.CreatedDate = DateTime.Now;

            return prodObj;
        }

        public void ProductAdd(ProductModel productItem)
        {
            MasterProducts.Add(productItem);
        }

        public void Display()
        {
            foreach (var item in MasterProducts)
            {
                Console.WriteLine($"{item.Name}, {item.Id},{item.Price},{item.CreatedDate}");
            }
        }
        public List<ProductModel> MultipleObjectsAdd()
        {
            int NumberOfObjects = 0;
            Console.WriteLine("Enter No.of Objects");
            NumberOfObjects = int.Parse(Console.ReadLine());

            List<ProductModel> NewProductList = new List<ProductModel>();

            for (int i = 0; i < NumberOfObjects; i++)
            {
                ProductModel productMod = new ProductModel();

                Console.WriteLine("Enter Name");
                productMod.Name = (Console.ReadLine());
                Console.WriteLine("Enter Price");
                productMod.Price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Id");
                productMod.Id = int.Parse(Console.ReadLine());
                productMod.CreatedDate = DateTime.Now;

                NewProductList.Add(productMod);

            }
            return NewProductList;


        }


        public void AddNewList(List<ProductModel> NewProductList)
        {
            MasterProducts.AddRange(NewProductList);
        }

    }

}

