using System;

namespace Draft_Diamond_BD.Products
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Count {get; set; }
        public decimal Price { get; set; }
        public int Rest {get; set; }
        public Product () {}
        /// <summary>
        /// Метод для выведения информации о товаре
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"id - {Id}; Name - {Name}; Count - {Count}; Price - {Price}; Rest- {Rest}";
        }

    }
}
