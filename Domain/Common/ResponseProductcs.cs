using Domain.Extensions;
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
            StringExtensions.Align(
                new string[]
            {
                IDContract.ToString(),
                IsOk ? "Ok" : "return",
                Reason == null? "-" : Reason
            }, new int[]
            {
                10,
                8,
                40
            });

                
            

        public void ReturnProduct(string reason)
        {
            Reason = reason;
            IsOk = false;
        }
    }
}
