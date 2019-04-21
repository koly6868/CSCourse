using System;
using System.Collections.Generic;
using Domain.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Infrastructure.Query;
using System.Data.SqlClient;
using Dapper;
using Domain.Infrastructure.Request;

namespace Domain.Infrastructure
{
    public class ContractRepository : IRepository<Contract>
    {
        private ContractRepository() { }

        public static void Configure(string connectionString)
        {
            repository.connectionString = connectionString;
        }

        public static ContractRepository GetInstance()
        {
            return repository;
        }

        public Contract Get(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contract> GetAll()
        {
            IQuery query = new GetAllContractsQuery();
            List<Contract> contracts = new List<Contract>();
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Query<Contract, Product,int, Transport, ForeignTransport, Contract>(query.Sql,
                    (contract, product,countP, transport, fTransport) =>
                    {
                        int index;
                        if (!contracts.Contains(contract))
                        {
                            contracts.Add(contract);
                            index = contracts.Count - 1;
                            contracts[index].SetAdditionalTransport(fTransport);
                            contracts[index].SetTransport(transport);
                        }
                        else
                        {
                            index = contracts.IndexOf(contract);
                        }
                        contracts[index].AddProduct(product, countP);

                        return contract;
                    },
                    splitOn: "ID,count,ID,ID");
            }

            return contracts;
        }

        public bool Add(Contract el)
        {
            IRequest request = new CreateContractRequest(el);
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {

                        connection.Execute(request.Sql, transaction : transaction);
                        transaction.Commit();

                    }
                }
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public bool Update(Contract el)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int ID)
        {
            throw new NotImplementedException();
        }

        private static ContractRepository repository = new ContractRepository();
        private  string connectionString;
    }
}
