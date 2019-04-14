using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Query
{
    public interface IQuery
    {
        string Sql { get; }
    }
}
