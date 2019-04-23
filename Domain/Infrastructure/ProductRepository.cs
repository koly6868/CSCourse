using Dapper;
using Domain.Common;
using Domain.Infrastructure.Query;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Domain.Infrastructure
{
    public class ProductRepository : IRepository<Product>, IProductRepository
    {
        private ProductRepository() { }

        public static void Configure(string connectionString)
        {
            repository.connectionString = connectionString;
        }

        public static ProductRepository GetInstance()
        {
            return repository;
        }

        public Product Get(int ID)
        {
            IQuery query = new GetProductsQuery();
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Product>(query.Sql, new { ID }).First();
            }
        }

        public IEnumerable<KeyValuePair<Product,int>> GetByContractID(int ID)
        {
            IQuery query = new GetProductsByContract();
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Product,int, KeyValuePair<Product,int>>(
                    query.Sql,
                    (product,count) =>
                    {
                        return new KeyValuePair<Product, int>(product, count);
                    }, 
                    new { ID },
                    splitOn : "count"
                );
            }
        }

        public IEnumerable<Product> GetAll()
        {
            IQuery query = new GetAllProductsQuery();
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Product>(query.Sql);
            }
        }

        public bool Add(Product el)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product el)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int ID)
        {
            throw new NotImplementedException();
        }

        private string connectionString;
        private static ProductRepository repository = new ProductRepository();
    }
}
