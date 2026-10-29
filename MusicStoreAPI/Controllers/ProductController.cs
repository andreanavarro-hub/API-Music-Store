using Microsoft.AspNetCore.Mvc;
using MusicStoreAPI.Services;

namespace MusicStoreAPI.Controllers;

[ApiController]
[Route("/products")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet()]
    public ProductResponseDto Get(int id)
    {
        var productFind = _productService.Get(id);

        return new ProductResponseDto
        {
            Id = productFind.Id,
            NameCD = productFind.Name,
            Artist = productFind.Artist,
            Price = productFind.Price,
            Stock = productFind.Stock
        };
    }

}