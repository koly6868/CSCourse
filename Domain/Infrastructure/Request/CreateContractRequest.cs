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
            Sql = $"exec CreateBlankOfContract {contract.ID}, " +
                $"{contract.Company.ID.ToString()}, " +
                $"'{TransfromDate(contract.Date)}', " +
                $"{(contract.Transport == null ? "null" : contract.Transport.ID.ToString())}, " +
                $"{(contract.AdditionalTransport == null ? "null" : contract.AdditionalTransport.ID.ToString())} "+
                "INSERT INTO Price(ID_contract,ID_product,price) " +
                "VALUES " + string.Join(", ", GeneratePrices(contract)) + " "+
                "INSERT INTO ListOfProducts(ID_contract,ID_product,count) "+
                "VALUES "+ string.Join(", ",GenerateProductsList(contract));
        }

        private string[] GenerateProductsList(Contract contract)
        {
            if (contract.Products != null)
            {
                return contract.Products.Select(pr =>
                    $"({contract.ID},{pr.Key.ID},{pr.Value})")
                    .ToArray();
            }
            else
            {
                return new string[0];
            }
        }

        private string[] GeneratePrices(Contract contract)
        {
            if (contract.Products != null)
            {
                return contract.Products.Select(pr =>
                    $"({contract.ID},{pr.Key.ID},{pr.Key.Price})")
                    .ToArray();
            }
            else
            {
                return new string[0];
            }
        }

        private string TransfromDate(DateTime date)
        {
            return $"{date.Year}.{date.Month}.{date.Day}";
        }


        public string Sql { get; }
    }
}
