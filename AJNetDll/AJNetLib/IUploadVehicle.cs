using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AJNetLib
{
    public interface IUploadVehicle
    {
        ReturnInfo UploadByJKId(UploadCondition uploadCondition);
    }
}
