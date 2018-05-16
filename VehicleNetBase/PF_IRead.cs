using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gfVehicleLibraryPF;

namespace VehicleNetBase
{
    public interface PF_IRead
    {
        Vehicle_DR001_Login_Response Read_Verify(Vehicle_DR001_Login_Request Req);
        Vehicle_DR004_GetTime_Response Read_GetTime(Vehicle_DR004_GetTime_Request Req);
    }
}
