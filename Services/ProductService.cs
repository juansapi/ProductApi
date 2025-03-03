using ProductApi.Models;

namespace ProductApi.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new();
        private int _nextId = 1;

        public List<Product> GetAll() => _products;

        public Product GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public Product Create(ProductDto productDto)
        {
            var product = new Product
            {
                Id = _nextId++,
                Name = productDto.Name,
                Price = productDto.Price,
                Quantity = productDto.Quantity
            };

            _products.Add(product);
            return product;
        }

        public bool Update(int id, ProductDto updatedProductDto)
        {
            var product = GetById(id);
            if (product == null) return false;

            product.Name = updatedProductDto.Name;
            product.Price = updatedProductDto.Price;
            product.Quantity = updatedProductDto.Quantity;
            return true;
        }

        public bool Delete(int id)
        {
            var product = GetById(id);
            if (product == null) return false;

            _products.Remove(product);
            return true;
        }
    }
}
