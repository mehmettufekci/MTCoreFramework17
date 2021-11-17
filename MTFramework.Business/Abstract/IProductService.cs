using MTFramework.Core.Utilities.Results;
using MTFramework.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTFramework.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
