﻿using Dapper;
using Domain.Common;
using Domain.Infrastructure.Query;
using Domain.Infrastructure.Request;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Domain.Infrastructure
{
    public class ResponseProductRepository : IRepository<ResponseProductcs>
    {
        public bool Add(ResponseProductcs el)
        {
            return false;
        }

        public bool Delete(int ID)
        {
            return false;
        }

        public ResponseProductcs Get(int ID)
        {
            return null;
        }

        public IEnumerable<ResponseProductcs> GetAll()
        {
            IQuery query = new GetAllResponseProductsQuery();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    return connection.Query<ResponseProductcs>(query.Sql);
                }
            }catch(Exception e)
            {
                return null;
            }
        }

        public bool Update(ResponseProductcs el)
        {
            IRequest request = new ResponseProductsUpdateRequest();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Query<ResponseProductcs>(request.Sql, new { el.IDContract, el.Reason });
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private ResponseProductRepository() { }

        public static void Configure(string connectionString)
        {
            repository.connectionString = connectionString;
        }

        public static ResponseProductRepository GetInstace()
        {
            return repository;
        }

        private string connectionString;
        private static ResponseProductRepository repository = new ResponseProductRepository();
    }
}
