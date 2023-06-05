using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductAPI.DAL;
using ProductAPI.Models;
using ProductAPI.Services.Interfaces.ProductService;
using ProductAPI.Utilities.Exceptions;
using ProductAPI.Utilities.ResponseMessages;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public void Add(Product entity)
        {
            _productService.Add(entity);
        }

        public void Delete(Product entity)
        {
            _productService.Delete(entity);
        }

        public async Task<ResponseMessage> GetAll()
        {
            return new ResponseMessage()
            {
                Data = await _productService.GetAll(),
                Message = "Entities found",
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }

        public Product GetById(int id)
        {
          return _productService.GetById(id);
        }

        public Product Update(Product entity)
        {
           return _productService.Update(entity);
        }
    }
}
