using MusicStoreAPI.Models;
using MusicStoreAPI.Repositories;

namespace MusicStoreAPI.Services;

public interface IProductService
{
    public Product Get(int id);
}

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Product Get(int id)
    {
        return _clientRepository.Get(id);
    }


}
