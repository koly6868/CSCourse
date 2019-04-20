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
                  "Product.color, Product.weight, Product.lenght, Product.width, Product.height, " +
	              "ListOfProducts.count, typeOfDelivery.ID, typeOfDelivery.price, typeOfDelivery.timeOfDelivery, " +
	              "typeOfDelivery.typeOfTransport, typeOfDelivery.maxWeight, TransportOfLogickalCompany.ID, " +
	              "TransportOfLogickalCompany.maxWeight, TransportOfLogickalCompany.priceOfOneCar " +
              "FROM[Purchase department].[dbo].[BuyContract] " +
                  "LEFT JOIN ListOfProducts ON ListOfProducts.ID_contract = BuyContract.ID " +
                  "LEFT JOIN Product ON Product.ID = ListOfProducts.ID_product " +
                  "LEFT JOIN Delivery ON Delivery.ID = BuyContract.ID_delivery " +
                  "LEFT JOIN typeOfDelivery ON typeOfDelivery.ID = Delivery.ID_typeDelivery " +
                  "LEFT JOIN TransportOfLogickalCompany ON TransportOfLogickalCompany.ID = Delivery.ID_additionalCars";
        }
        public string Sql { get; }
    }
}
