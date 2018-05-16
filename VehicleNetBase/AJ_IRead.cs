using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gfVehicleLibraryAJ;

namespace VehicleNetBase
{
    public interface AJ_IRead
    {
        Vehicle_18J52_Result Read_18J52(Vehicle_18J52_Para para);

        Vehicle_18C49_Result Read_18C49(Vehicle_18C49_Para para);

        Vehicle_18C50_Result Read_18C50(Vehicle_18C50_Para para);

        Vehicle_18J80_Result Read_18J80(Vehicle_18J80_Para para);

        Vehicle_18X01_Result Read_18X01(Vehicle_18X01_Para para);

        Vehicle_18X02_Result Read_18X02(Vehicle_18X02_Para para);

        Vehicle_18X03_Result Read_18X03(Vehicle_18X03_Para para);

        Vehicle_18W06_Result Read_18W06(Vehicle_18W06_Para para);
    }
}
