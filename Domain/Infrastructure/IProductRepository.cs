using System.Collections.Generic;
using Domain.Common;

namespace Domain.Infrastructure
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetByContractID(int ID);
    }
}