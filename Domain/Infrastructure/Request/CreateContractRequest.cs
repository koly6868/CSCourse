using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Infrastructure.Request
{
    class CreateContractRequest : IRequest
    {
        public CreateContractRequest(Contract contract)
        {
            Sql = "exec CreateBlankOfContract @ID, @IDCompany, @Date, @IDTransport, @IDAdditionalTransport "+
                "INSERT INTO ListOfProducts(ID_contract,ID_product,count) "+
                "VALUES "+ string.Join(", ",GenerateProductsList())
                ;
        }

        public object GetParams()
        {
            return new { contract.ID,
                        IDCompany = contract.Company.ID,
                        contract.Date,
                        IDTransport = contract.Transport.ID,
                        IDAdditionalTransport = contract.AdditionalTransport.ID
            };
        }

        private string[] GenerateProductsList()
        {
            return contract.Products.Select(pr =>
                $"{contract.ID},{pr.Key.ID},{pr.Value}")
                .ToArray();
        }


        public string Sql { get; }
        private Contract contract;
    }
}
