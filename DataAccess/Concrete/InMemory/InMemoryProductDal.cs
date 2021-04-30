using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{CategoryId=1,ProductId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{CategoryId=1,ProductId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{CategoryId=1,ProductId=1,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{CategoryId=1,ProductId=1,ProductName="Klavye",UnitPrice=150,UnitsInStock=25},
                new Product{CategoryId=1,ProductId=1,ProductName="Fare",UnitPrice=85,UnitsInStock=1}



        };
        }
        public void Add(Product product)
        {
            _products.Add(product);

        }
        // LİNQ Language İntegrated Query
        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
            //    foreach (var p in _products)
            //    {
            //        if (product.ProductName == p.ProductName)
            //        {
            //            productToDelete = p;
            //        }
            //    }
            //    productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            //    _products.Remove(productToDelete);
            //}


        }

        public Product Get(Expression<Func<Product, bool>> fiilter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> fiilter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
