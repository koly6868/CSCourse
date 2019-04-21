using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Request
{
    class ResponseProductsUpdateRequest : IRequest
    {
        public ResponseProductsUpdateRequest()
        {
            Sql = "exec ReturnProducts @IDContract, @Reason";
        }

        public string Sql { get; }
    }
}
