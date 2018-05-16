using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gfVehicleLibraryPF;
using VehicleForNetSocket;
using VehicleNetBase;

namespace ProcessManage
{
    public class PF_ReadProcess
    {
        public Vehicle_DR001_Login_Response PF_Read_Verify(Vehicle_DR001_Login_Request req)
        {
            PF_IRead pf_Verify = new PF_Read_Socket();
            Vehicle_DR001_Login_Response pf_Verify_Resp = pf_Verify.Read_Verify(req);
            return pf_Verify_Resp;
        }

        public Vehicle_DR004_GetTime_Response PF_Read_GetTime(Vehicle_DR004_GetTime_Request req)
        {
            PF_IRead pf_GetTime = new PF_Read_Socket();
            Vehicle_DR004_GetTime_Response pf_GetTime_Resp = pf_GetTime.Read_GetTime(req);
            return pf_GetTime_Resp;

        }
    }
}
