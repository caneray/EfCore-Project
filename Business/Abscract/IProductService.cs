using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abscract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id); //kategori idsine göre ürünü getir.
        List<Product> GetByUnitPrice(decimal min, decimal max); //şu fiyat aralığındaki ürünleri getir.
    }
}
