using Domain.Common;
using System.Collections.Generic;

namespace Domain.Infrastructure
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<KeyValuePair<Product,int>> GetByContractID(int ID);
    }
}