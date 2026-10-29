using MusicStoreAPI.Models;
using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;

namespace MusicStoreAPI.Repositories;


public interface IProductRepository
{
    public Product? Get(int id);
    public void Save(Product product);
}


public class ProductRepository
{
    private readonly string _path = "./products.csv";
    public Product? Get(int id)
    {
        var exists = File.Exists(_path);

        if (!exists)
        {
            return null;
        }

        using var reader = new StreamReader(_path);
        using var readerCsv = new CsvReader(reader, CultureInfo.InvariantCulture);

        var clients = readerCsv.GetRecords<Product>();

        return clients.FirstOrDefault(p => p.Id == id);
    }


}
