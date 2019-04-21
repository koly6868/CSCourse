using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class ResponseProductcs
    {

        public int IDContract { get; }
        public bool IsOk { get; private set; }
        public string Reason { get; private set; }
        private int IDDelivery;

        public ResponseProductcs(int ID, int ID_delivery, bool isOk, string reason)
        {
            IDContract = ID;
            IDDelivery = ID_delivery;
            IsOk = isOk;
            Reason = reason;
        }

        public string Description =>
            string.Format("{0, 20} {1, 10} {2, 10}",
                IDContract,
                IsOk,
                Reason == null? "-" : Reason);

        public void ReturnProduct(string reason)
        {
            Reason = reason;
            IsOk = false;
        }
    }
}
