using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using gfVehicleLibraryAJ;

namespace ProcessManage
{
    public class AdapterHelper
    {
        /// <summary>
        /// 转化使用性质
        /// </summary>
        /// <param name="strSYXZ"></param>
        /// <returns></returns>
        public string UpdateSYXZ_IY_To_Net(string strSYXZ)
        {
            string strRet = "";
            switch (strSYXZ)
            {
                case "F01":
                    strRet = "A";
                    break;
                case "F02":
                    strRet = "H";
                    break;
                case "F03":
                    strRet = "I";
                    break;
                case "F04":
                    strRet = "J";
                    break;
                case "F05":
                    strRet = "K";
                    break;
                case "F06":
                    strRet = "L";
                    break;
                case "F08":
                    strRet = "O";
                    break;
                case "F09":
                    strRet = "P";
                    break;
                case "F010":
                    strRet = "S";
                    break;
                case "F011":
                    strRet = "Q";
                    break;
                case "Y12":
                    strRet = "B";
                    break;
                case "Y13":
                    strRet = "C";
                    break;
                case "Y14":
                    strRet = "D";
                    break;
                case "Y15":
                    strRet = "E";
                    break;
                case "Y16":
                    strRet = "G";
                    break;
                case "Y17":
                    strRet = "N";
                    break;
                case "Y18":
                    strRet = "F";
                    break;
                case "Y19":
                    strRet = "R";
                    break;
            }

            return strRet;
        }

        /// <summary>
        /// 转化使用性质
        /// </summary>
        /// <param name="strSYXZ"></param>
        /// <returns></returns>
        public string UpdateSYXZ_Net_To_IY(string strSYXZ)
        {
            string strRet = "";
            switch (strSYXZ)
            {
                case "A":
                    strRet = "F01";
                    break;
                case "H":
                    strRet = "F02";
                    break;
                case "I":
                    strRet = "F03";
                    break;
                case "J":
                    strRet = "F04";
                    break;
                case "K":
                    strRet = "F05";
                    break;
                case "L":
                    strRet = "F06";
                    break;
                case "O":
                    strRet = "F08";
                    break;
                case "P":
                    strRet = "F09";
                    break;
                case "S":
                    strRet = "F010";
                    break;
                case "Q":
                    strRet = "F011";
                    break;
                case "B":
                    strRet = "Y12";
                    break;
                case "C":
                    strRet = "Y13";
                    break;
                case "D":
                    strRet = "Y14";
                    break;
                case "E":
                    strRet = "Y15";
                    break;
                case "G":
                    strRet = "Y16";
                    break;
                case "N":
                    strRet = "Y17";
                    break;
                case "F":
                    strRet = "Y18";
                    break;
                case "R":
                    strRet = "Y19";
                    break;
            }

            return strRet;
        }

        /// <summary>
        /// 转换驱动形式
        /// </summary>
        /// <param name="strQDXS"></param>
        /// <param name="strZZS"></param>
        /// <returns></returns>
        public string UpdateQDXS_Net_To_IY(string strQDXS, string strZZS)
        {
            string strRet = "";
            if (Convert.ToInt32(strZZS) == strQDXS.Length)
            {
                //全驱
                strRet = "203";
            }
            else
            {
                if (strQDXS.Contains("1"))
                {//前驱
                    strRet = "201";
                }
                else
                {//后驱
                    strRet = "202";
                }
            }

            return strRet;
        }

        /// <summary>
        /// 转换驱动轴位
        /// </summary>
        /// <param name="strQDZWZ"></param>
        /// <returns></returns>
        public string UpdateQDZWZ_IY_To_Net(string strQDZWZ)
        {
            string strRet = "";
            if (string.IsNullOrEmpty(strQDZWZ) == false)
            {
                string[] strAry = strQDZWZ.Split(',');
                foreach (var v in strAry)
                {
                    strRet += v;
                }
            }

            return strRet;
        }

        /// <summary>
        /// 转换驱动轴位
        /// </summary>
        /// <param name="strQDZWZ"></param>
        /// <returns></returns>
        public string UpdateQDZWZ_Net_To_IY(string strQDZWZ)
        {
            string strRet = "";
            if (string.IsNullOrEmpty(strQDZWZ) == false)
            {
                for (int i = 0; i < strQDZWZ.Length; i++)
                {
                    strRet += strQDZWZ.Substring(i, 1) + ",";
                }
            }

            return strRet;
        }

        /// <summary>
        /// 转换驻车轴位置
        /// </summary>
        /// <param name="strZCZWZ"></param>
        /// <returns></returns>
        public string UpdateZCZW_IY_To_Net(string strZCZWZ)
        {
            string strRet = "";
            if (string.IsNullOrEmpty(strZCZWZ) == false)
            {
                string[] strAry = strZCZWZ.Split(',');
                foreach (var v in strAry)
                {
                    strRet += v;
                }
            }

            return strRet;
        }

        /// <summary>
        /// 转换驻车轴位置
        /// </summary>
        /// <param name="strZCZWZ"></param>
        /// <returns></returns>
        public string UpdateZCZW_Net_To_IY(string strZCZWZ)
        {
            string strRet = "";
            if (string.IsNullOrEmpty(strZCZWZ) == false)
            {
                for (int i = 0; i < strZCZWZ.Length; i++)
                {
                    strRet += strZCZWZ.Substring(i, i + 1) + ",";
                }
            }

            return strRet;
        }

        /// <summary>
        /// 转换前照灯制
        /// </summary>
        /// <param name="strQZDZ"></param>
        /// <returns></returns>
        public string UpdateQZDZ_IY_To_Net(string strQZDZ)
        {
            string strRet = "";
            switch (strQZDZ)
            { 
                case "1":
                    strRet = "05";
                    break;
                case "2":
                    strRet = "03";
                    break;
                case "4":
                    strRet = "01";
                    break;
            }
            return strRet;
        }

        /// <summary>
        /// 转换前照灯制
        /// </summary>
        /// <param name="strQZDZ"></param>
        /// <returns></returns>
        public string UpdateQZDZ_Net_To_IY(string strQZDZ)
        {
            string strRet = "";
            switch (strQZDZ)
            {
                case "05":
                    strRet = "1";
                    break;
                case "03":
                case "04":
                    strRet = "2";
                    break;
                case "01":
                case "02":
                    strRet = "4";
                    break;
            }
            return strRet;
        }

        /// <summary>
        /// 转换检验类别
        /// </summary>
        /// <param name="strJYLB"></param>
        /// <returns></returns>
        public string UpdateJYLB_Net_To_IY(string strJYLB)
        {
            string strRet = "";
            switch (strJYLB)
            {
                case "00"://注册机动车检验
                    strRet = "02";
                    break;
                case "01"://在用机动车检验
                    strRet = "01";
                    break;
                case "02"://临时检验
                    strRet = "03";
                    break;
                case "03"://特殊检验
                    strRet = "04";
                    break;
                case "04"://在用车检验（非定检）
                    strRet = "05";
                    break;
            }

            return strRet;
        }

        /// <summary>
        /// 转换检验类别
        /// </summary>
        /// <param name="strJYLB"></param>
        /// <returns></returns>
        public string UpdateJYLB_IY_To_Net(string strJYLB)
        {
            string strRet = "";
            switch (strJYLB)
            {
                case "02"://注册机动车检验
                    strRet = "00";
                    break;
                case "01"://在用机动车检验
                    strRet = "01";
                    break;
                case "03"://临时检验
                    strRet = "02";
                    break;
                case "04"://特殊检验
                    strRet = "03";
                    break;
                case "05"://在用车检验（非定检）
                    strRet = "04";
                    break;
            }

            return strRet;
        }

        /// <summary>
        /// 转换外检，底盘，动态底盘
        /// </summary>
        /// <param name="strJYLB"></param>
        /// <returns></returns>
        public string UpdateWJDP_Net_To_IY(string strWJDP)
        {
            string strRet = "";
            List<string> lstRet = new List<string>();
            if (!string.IsNullOrEmpty(strWJDP))
            {
                if (strWJDP == "无")
                {
                    strRet = "-";
                }
                else
                {
                    if (strWJDP.Contains(","))
                    {
                        string[] strAry = strWJDP.Split(',');
                        foreach (var v in strAry)
                        {
                            if (string.IsNullOrEmpty(v) == false)
                            {
                                lstRet.Add(v);
                            }
                        }
                    }
                    else
                    {
                        lstRet.Add(strWJDP);
                    }
                }
            }

            if (lstRet.Count > 0)
            {
                foreach (var v in lstRet)
                {
                    strRet += v + "-1,";
                }
            }

            return strRet;
        }

        /// <summary>
        /// 根据检验项目得到录像类型
        /// </summary>
        /// <param name="strJYXM"></param>
        /// <returns></returns>
        public string GetLXLXByJYXM(string strJYXM)
        {
            string strRet = "";
            switch (strJYXM)
            {
                case "S1":
                    strRet = "0347";
                    break;
                case "H1":
                    strRet = "0321";
                    break;
                case "H4":
                    strRet = "0352";
                    break;
                case "B1":
                    strRet = "0322";
                    break;
                case "B2":
                    strRet = "0348";
                    break;
                case "B3":
                    strRet = "0349";
                    break;
                case "B4":
                    strRet = "0350";
                    break;
                case "B5":
                    strRet = "0354";
                    break;
                case "B6":
                    strRet = "0355";
                    break;
                case "B0":
                    strRet = "0351";
                    break;
                case "A1":
                    strRet = "0353";
                    break;
                case "C1":
                    strRet = "0323";
                    break;
                case "M1":
                    strRet = "0360";
                    break;
                case "Z1":
                    strRet = "0362";
                    break;
                case "L1":
                    strRet = "0356";
                    break;
                case "L2":
                    strRet = "0357";
                    break;
                case "L3":
                    strRet = "0358";
                    break;
                case "L4":
                    strRet = "0359";
                    break;
            }
            return strRet;
        }
        
        /// <summary>
        /// 将联网平台的燃料种类转成IYASAKA的RLLB
        /// </summary>
        /// <param name="strRLZL"></param>
        /// <returns></returns>
        public string UpdateRLZL_Net_To_IY(string strRLZL)
        {
            string strRet = "";
            switch (strRLZL)
            {
                case "A": //汽油
                    strRet = "A";
                    break;
                case "B": //柴油
                    strRet = "B";
                    break;
                case "C": //电
                    strRet = "C";
                    break;
                case "D": //混合油
                    strRet = "P";
                    break;
                case "E": //天然气   
                    strRet = "E";
                    break;
                case "F": //液化石油气
                    strRet = "F";
                    break;
                case "L": //甲醇
                    strRet = "L";
                    break;
                case "M": //乙醇
                    strRet = "M";
                    break;
                case "N": //太阳能
                    strRet = "N";
                    break;
                case "O": //混合动力
                    strRet = "R";
                    break;
                case "P": //氢
                    strRet = "S";
                    break;
                case "Q": //混合动力
                    strRet = "Q";
                    break;
                case "Y": //无
                    strRet = "Y";
                    break;
            }

            return strRet;
        }

        /// <summary>
        /// 将IYASAKA的RLLB转成联网平台的燃料种类
        /// </summary>
        /// <param name="strRLZL"></param>
        /// <returns></returns>
        public string UpdateRLZL_IY_To_Net(string strRLZL)
        {
            string strRet = "";
            switch (strRLZL)
            {
                case "A": //汽油
                    strRet = "A";
                    break;
                case "B": //柴油
                    strRet = "B";
                    break;
                case "C": //电
                    strRet = "C";
                    break;
                case "P": //混合油
                    strRet = "D";
                    break;
                case "E": //天然气   
                    strRet = "E";
                    break;
                case "F": //液化石油气
                    strRet = "F";
                    break;
                case "L": //甲醇
                    strRet = "L";
                    break;
                case "M": //乙醇
                    strRet = "M";
                    break;
                case "N": //太阳能
                    strRet = "N";
                    break;
                case "R": //混合动力
                    strRet = "O";
                    break;
                case "S": //氢
                    strRet = "P";
                    break;
                case "Q": //混合动力
                    strRet = "Q";
                    break;
                case "Y": //无
                    strRet = "Y";
                    break;
            }

            return strRet;
        }
    }
}
