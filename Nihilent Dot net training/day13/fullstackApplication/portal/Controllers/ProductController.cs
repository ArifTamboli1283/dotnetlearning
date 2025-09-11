using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portal.Models;
using Repositories;
using services;
using Entities;

namespace portal.Controllers;

public class ProductController : Controller
{
    public IActionResult GetAllProduct()
    {
        IProductRepository _productRepository = new ProductRepository();
        IProductService _productService = new ProsuctService(_productRepository);
        return View(_productService.GetAllProduct());
    }
    public IActionResult getProductById(int id)
    {
        IProductRepository _productRepository = new ProductRepository();
        IProductService _productService = new ProsuctService(_productRepository);
        return View(_productService.GetProductById(id));
    }
    public IActionResult DeleteProduct(Product product)
    {
        IProductRepository _productRepository = new ProductRepository();
        IProductService _productService = new ProsuctService(_productRepository);
        _productService.DeleteProduct(product);
        return View();
    }

    public IActionResult AddProduct(Product product)
    {
        IProductRepository _productRepository = new ProductRepository();
        IProductService _productService = new ProsuctService(_productRepository);
        _productService.AddProduct(product);
        return View();
    }
    public IActionResult UpdateProduct(Product product)
    {
        IProductRepository _productRepository = new ProductRepository();
        IProductService _productService = new ProsuctService(_productRepository);
        _productService.UpdateProduct(product);
        return View();
    } 
}