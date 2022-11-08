using OOP.Abstraction.EnCapsulation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction
{
    interface IProductService
    {
        public void ProductAdd(ProductModel productItem);

        public ProductModel CreateProductObject();

        public void Display();

        public List<ProductModel> MultipleObjectsAdd();

        void AddNewList(List<ProductModel> NewProductList);
        void DisplayByName(string Name);
    }
}
