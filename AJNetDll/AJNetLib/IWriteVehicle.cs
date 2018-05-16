using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AJNetLib
{
    public interface IWriteVehicle
    {
        ReturnInfo WriteByJKId(WriteCondition writeCondition);
    }
}
