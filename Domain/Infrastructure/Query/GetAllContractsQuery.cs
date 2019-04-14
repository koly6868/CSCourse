using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Query
{
    public class GetAllContractsQuery : IQuery
    {
        public GetAllContractsQuery()
        {
            Sql = "SELECT BuyContract.ID, " +
	              "BuyContract.fullPrice, BuyContract.date, Product.ID, Product.typeOfProduct, " +
	              "Product.weight, Product.lenght, Product.width, Product.height, Product.color, " +
	              "ListOfProducts.count, typeOfDelivery.ID, typeOfDelivery.price, typeOfDelivery.timeOfDelivery, " +
	              "typeOfDelivery.typeOfTransport, typeOfDelivery.maxWeight, TransportOfLogickalCompany.ID, " +
	              "TransportOfLogickalCompany.maxWeight, TransportOfLogickalCompany.priceOfOneCar " +
              "FROM[Purchase department].[dbo].[BuyContract] " +
                  "JOIN ListOfProducts ON ListOfProducts.ID_contract = BuyContract.ID " +
                  "JOIN Product ON Product.ID = ListOfProducts.ID_product " +
                  "JOIN Delivery ON Delivery.ID = BuyContract.ID_delivery " +
                  "JOIN typeOfDelivery ON typeOfDelivery.ID = Delivery.ID_typeDelivery " +
                  "JOIN TransportOfLogickalCompany ON TransportOfLogickalCompany.ID = Delivery.ID_additionalCars";
        }
        public string Sql { get; }
    }
}
