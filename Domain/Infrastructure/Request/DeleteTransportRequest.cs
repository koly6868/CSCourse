using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Request
{
    public class DeleteTransportRequest : IRequest
    {
        public DeleteTransportRequest()
        {
            Sql = "DELETE FROM typeOfDelivery WHERE typeOfDelivery.ID = @ID";
        }

        public string Sql { get; }
    }
}
