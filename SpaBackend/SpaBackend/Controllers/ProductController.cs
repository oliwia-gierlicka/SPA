using Microsoft.AspNetCore.Mvc;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController:ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("all")]
    public ActionResult GetAll()
    {
        return Ok(_productService.GetProducts());
    }
    
    [HttpGet("details")]
    public ActionResult GetDetails()
    {
        return Ok(_productService.GetProductDetails());
    }
}