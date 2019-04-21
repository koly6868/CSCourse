using System.Collections.Generic;
using Domain.Common;

namespace Domain.Infrastructure
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<KeyValuePair<Product,int>> GetByContractID(int ID);
    }
}