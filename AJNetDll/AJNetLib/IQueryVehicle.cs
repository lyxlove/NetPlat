using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AJNetLib
{
    public interface IQueryVehicle
    {
        ReturnInfo QueryByJKId(QueryCondition queryCondition);
    }
}
