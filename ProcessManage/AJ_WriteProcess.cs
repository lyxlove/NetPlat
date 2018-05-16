using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleForNetWebServices;
using VehicleNetBase;
using gfVehicleLibraryAJ;
using System.Reflection;
using System.IO;

namespace ProcessManage
{
    public class AJ_WriteProcess
    {
        public Vehicle_18C51_Result AJ_Write_18C51(Vehicle_18C51_Para para)
        {
            AJ_IWrite aj_18C51 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            

            AdapterHelper adapter = new AdapterHelper();
            para.syxz = adapter.UpdateSYXZ_IY_To_Net(para.syxz);
            para.jylb = adapter.UpdateJYLB_IY_To_Net(para.jylb);
            para.qdxs = adapter.UpdateQDZWZ_IY_To_Net(para.qdxs);
            para.qzdz = adapter.UpdateQZDZ_IY_To_Net(para.qzdz);
            para.zczw = adapter.UpdateZCZW_IY_To_Net(para.zczw);
            para.rlzl = adapter.UpdateRLZL_IY_To_Net(para.rlzl);
            Vehicle_18C51_Result aj_18C51_Result = aj_18C51.Write_18C51(para);
            return aj_18C51_Result;
        }

        public Vehicle_18C66_Result AJ_Write_18C66(Vehicle_18C66_Para para)
        {
            AJ_IWrite aj_18C66 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            else
            {
             
            }

            AdapterHelper adapter = new AdapterHelper();
            para.syxz = adapter.UpdateSYXZ_IY_To_Net(para.syxz);
            para.jylb = adapter.UpdateJYLB_IY_To_Net(para.jylb);
            para.qdxs = adapter.UpdateQDZWZ_IY_To_Net(para.qdxs);
            para.qzdz = adapter.UpdateQZDZ_IY_To_Net(para.qzdz);
            para.zczw = adapter.UpdateZCZW_IY_To_Net(para.zczw);

            Vehicle_18C66_Result aj_18C66_Result = aj_18C66.Write_18C66(para);
            return aj_18C66_Result;
        }

        public Vehicle_18C55_Result AJ_Write_18C55(Vehicle_18C55_Para para)
        {
            AJ_IWrite aj_18C55 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }

            Vehicle_18C55_Result aj_18C55_Result = aj_18C55.Write_18C55(para);
            return aj_18C55_Result;
        } 

        public Vehicle_18J11_Result AJ_Write_18J11(Vehicle_18J11_Para para)
        {
            Vehicle_18J11_Result aj_18J11_Result = new Vehicle_18J11_Result();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
#if RZLD
            aj_18J11_Result.code = "0";
            aj_18J11_Result.jkid = para.jkid;
            aj_18J11_Result.jkxlh = para.jkxlh;
            aj_18J11_Result.keystr = "";
            aj_18J11_Result.message = "不支持本接口";
            aj_18J11_Result.xtlb = para.xtlb;
#elif BJXY
            AJ_IWrite aj_18J11 = new AJ_Write_WebServices();
            aj_18J11_Result = aj_18J11.Write_18J11(para);
#endif

            return aj_18J11_Result;
        }

        public Vehicle_18J12_Result AJ_Write_18J12(Vehicle_18J12_Para para)
        {
            Vehicle_18J12_Result aj_18J12_Result = new Vehicle_18J12_Result();
#if RZLD
            aj_18J12_Result.code = "0";
            aj_18J12_Result.jkid = para.jkid;
            aj_18J12_Result.jkxlh = para.jkxlh;
            aj_18J12_Result.keystr = "";
            aj_18J12_Result.message = "不支持本接口";
            aj_18J12_Result.xtlb = para.xtlb;
#elif BJXY
            AJ_IWrite aj_18J12 = new AJ_Write_WebServices();
            aj_18J12_Result = aj_18J12.Write_18J12(para);
#endif
            return aj_18J12_Result;
        }

        public Vehicle_18C82_Result AJ_Write_18C82(Vehicle_18C82_Para para)
        {
            AJ_IWrite aj_18C82 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            Vehicle_18C82_Result aj_18C82_Result = aj_18C82.Write_18C82(para);
            return aj_18C82_Result;
        }

        public Vehicle_18C59_Result AJ_Write_18C59(Vehicle_18C59_Para para)
        {
            AJ_IWrite aj_18C59 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            Vehicle_18C59_Result aj_18C59_Result = aj_18C59.Write_18C59(para);
            return aj_18C59_Result;
        }

        public Vehicle_18C58_Result AJ_Write_18C58(Vehicle_18C58_Para para)
        {
            AJ_IWrite aj_18C58 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            AdapterHelper adapter = new AdapterHelper();
            Vehicle_18C58_Result aj_18C58_Result = aj_18C58.Write_18C58(para);

#if RZLD
            if (aj_18C58_Result.code == "1")
            {
                Vehicle_18X05_Para m_18X05_Para = new Vehicle_18X05_Para("18X05", para.jkxlh, para.xtlb);
                m_18X05_Para.clsbdh = para.clsbdh;
                m_18X05_Para.hphm = para.hphm;
                m_18X05_Para.hpzl = para.hpzl;
                m_18X05_Para.jcxdh = para.jcxdh;
                m_18X05_Para.jssj = para.jssj;
                m_18X05_Para.jycs = para.jycs;
                m_18X05_Para.jyjgbh = para.jyjgbh;
                m_18X05_Para.jylsh = para.jylsh;
                m_18X05_Para.jyxm = para.jyxm;
                m_18X05_Para.kssj = para.kssj;
                m_18X05_Para.lxzl = adapter.GetLXLXByJYXM(para.jyxm);

                Vehicle_18X05_Result aj_18X05_Result = new Vehicle_18X05_Result();
                if (para.jyxm == "Z1")
                {//整备质量，录像发两个
                    m_18X05_Para.lxzl = "0362"; //前
                    Vehicle_18X05_Result aj_18X05_Result_F = aj_18C58.Write_18X05(m_18X05_Para);

                    m_18X05_Para.lxzl = "0363"; //后
                    Vehicle_18X05_Result aj_18X05_Result_B = aj_18C58.Write_18X05(m_18X05_Para);

                    if (aj_18X05_Result_F.code == "1" && aj_18X05_Result_B.code == "1")
                    {
                        aj_18X05_Result.code = "1";
                        aj_18X05_Result.message = "前：" + aj_18X05_Result_F.message + " 后：" + aj_18X05_Result_B.message;
                    }
                    else
                    {
                        aj_18X05_Result.code = "0";
                        aj_18X05_Result.message = "前：" + aj_18X05_Result_F.message + " 后：" + aj_18X05_Result_B.message;
                    }
                }
                else if (para.jyxm == "M1")
                {//外廓尺寸，录像发两个
                    m_18X05_Para.lxzl = "0360"; //前
                    Vehicle_18X05_Result aj_18X05_Result_F = aj_18C58.Write_18X05(m_18X05_Para);

                    m_18X05_Para.lxzl = "0361"; //后
                    Vehicle_18X05_Result aj_18X05_Result_B = aj_18C58.Write_18X05(m_18X05_Para);

                    if (aj_18X05_Result_F.code == "1" && aj_18X05_Result_B.code == "1")
                    {
                        aj_18X05_Result.code = "1";
                        aj_18X05_Result.message = "前：" + aj_18X05_Result_F.message + " 后：" + aj_18X05_Result_B.message;
                    }
                    else
                    {
                        aj_18X05_Result.code = "0";
                        aj_18X05_Result.message = "前：" + aj_18X05_Result_F.message + " 后：" + aj_18X05_Result_B.message;
                    }
                }
                else
                {//其他项目
                    aj_18X05_Result = aj_18C58.Write_18X05(m_18X05_Para);
                }

                aj_18C58_Result.code = aj_18X05_Result.code;
                aj_18C58_Result.message = aj_18X05_Result.message;
            }
#endif
            return aj_18C58_Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18C80_Result AJ_Write_18C80(Vehicle_18C80_Para para)
        {
            AJ_IWrite aj_18C80 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            Vehicle_18C80_Result aj_18C80_Result = aj_18C80.Write_18C80(para);
            return aj_18C80_Result;
        }

        /// <summary>
        /// 仪器设备检验项目检验结果详细信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18C81_Result AJ_Write_18C81(Vehicle_18C81_Para para)
        {
            AJ_IWrite aj_18C81 = new AJ_Write_WebServices();
#if RZLD
                if (!string.IsNullOrEmpty(para.hphm))
            {
            if (para.hphm.Contains("挂"))
            {
                para.hphm = para.hphm.Replace("挂", "");
            }
            if (para.hphm.Contains("学"))
            {
                para.hphm = para.hphm.Replace("学", "");
            }
            if (para.hphm.Contains("警"))
            {
                para.hphm = para.hphm.Replace("警", "");
            }
            }

#endif
#if RZLD
            //string strPath = AppDomain.CurrentDomain.BaseDirectory + "bin/RecordLog.dll";
            //if (File.Exists(strPath))
            //{
            //    Assembly assembly = Assembly.LoadFile(AppDomain.CurrentDomain.BaseDirectory + "bin/RecordLog.dll");

            //    if (assembly != null)
            //    {
            //        //获取类型，参数（名称空间+类）   
            //        Type type = assembly.GetType("RecordLog.RecordLog");

            //        Vehicle_18C81_ZWD_Para m_ZWD = new Vehicle_18C81_ZWD_Para();
            //        Vehicle_18C81_YWD_Para m_YWD = new Vehicle_18C81_YWD_Para();
            //        ConvertInfo.ModelReflection m_Reflection = new ConvertInfo.ModelReflection();

            //        if (para.jyxm == "H1")
            //        {
            //            m_ZWD = (Vehicle_18C81_ZWD_Para)para;
            //        }

            //        if(para.jyxm == "H4")
            //        {
            //            m_YWD =(Vehicle_18C81_YWD_Para)para;
            //        }
  
            //        //object instance = assembly.CreateInstance("RecordLog.RecordLog"); 
            //        //Type[] params_type = new Type[1];
            //        //Dictionary<string, string> dicType = new Dictionary<string, string>();
            //        //string strFullName = dicType.GetType().FullName;
            //        //params_type[0] = Type.GetType(strFullName);   
            //        //Object[] params_obj = new Object[1];
            //        //if (para.jyxm == "H1")
            //        //{
            //        //    params_obj[0] = m_Reflection.ModelToDictionary(m_ZWD);
            //        //}
            //        //if (para.jyxm == "H4")
            //        //{
            //        //    params_obj[0] = m_Reflection.ModelToDictionary(m_YWD);
            //        //} 
            //        //object value = type.GetMethod("LogInfo", params_type).Invoke(instance, params_obj);

            //        RecordLog.RecordLog lgg = new RecordLog.RecordLog();
            //        Dictionary<string,string> diccc = lgg.LogInfo(m_Reflection.ModelToDictionary(m_ZWD));
            //    }
            //}        
#endif

            Vehicle_18C81_Result aj_18C81_Result = aj_18C81.Write_18C81(para);
            return aj_18C81_Result;
        }

        /// <summary>
        /// 星盾平台判断照相
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18J31_Result AJ_Write_18J31(Vehicle_18J31_Para para)
        {
            Vehicle_18J31_Result aj_18J31_Result = new Vehicle_18J31_Result();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            AJ_IWrite aj_18J31 = new AJ_Write_WebServices();
#if RZLD
            //将18J31转换成新凌志这边的18X04,获取结果后，在转成18J31回传给18J31
            Vehicle_18X04_Para m_18X04_Para = new Vehicle_18X04_Para("18X04", para.jkxlh, para.xtlb);
            m_18X04_Para.clsbdh = para.clsbdh;
            m_18X04_Para.hphm = para.hphm;
            m_18X04_Para.hpzl = para.hpzl;
            m_18X04_Para.jcxdh = para.jcxdh;
            m_18X04_Para.jycs = para.jycs;
            m_18X04_Para.jyjgbh = para.jyjgbh;
            m_18X04_Para.jylsh = para.jylsh;
            m_18X04_Para.jyxm = para.jyxm;
            m_18X04_Para.pzcfsj = para.kssj;
            m_18X04_Para.zpzl = para.zpzl;

            Vehicle_18X04_Result aj_18X04_Result = aj_18J31.Write_18X04(m_18X04_Para);

            aj_18J31_Result.code = aj_18X04_Result.code;
            aj_18J31_Result.jkid = "18J31";
            aj_18J31_Result.jkxlh = aj_18X04_Result.jkxlh;
            aj_18J31_Result.keystr = aj_18X04_Result.keystr;
            aj_18J31_Result.message = aj_18X04_Result.message;
            aj_18J31_Result.rownum = aj_18X04_Result.rownum;
            aj_18J31_Result.xtlb = aj_18X04_Result.xtlb;
#elif BJXY
            aj_18J31_Result = aj_18J31.Write_18J31(para);
#endif
            return aj_18J31_Result;
        }

        /// <summary>
        /// 机动车判定结果信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18C62_Result AJ_Write_18C62(Vehicle_18C62_Para para)
        {
            AJ_IWrite aj_18C62 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            Vehicle_18C62_Result aj_18C62_Result = aj_18C62.Write_18C62(para);
            return aj_18C62_Result;
        }

        /// <summary>
        /// 机动车复检登录
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18C65_Result AJ_Write_18C65(Vehicle_18C65_Para para)
        {
            AJ_IWrite aj_18C65 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            AdapterHelper adapter = new AdapterHelper();
            para.syxz = adapter.UpdateSYXZ_IY_To_Net(para.syxz);

            Vehicle_18C65_Result aj_18C65_Result = aj_18C65.Write_18C65(para);
            return aj_18C65_Result;
        }

        /// <summary>
        /// 机动车检验过程开始
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18C52_Result AJ_Write_18C52(Vehicle_18C52_Para para)
        {
            AJ_IWrite aj_18C52 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            Vehicle_18C52_Result aj_18C52_Result = aj_18C52.Write_18C52(para);
            return aj_18C52_Result;
        }

        /// <summary>
        /// 机动车检验业务退办
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18C72_Result AJ_Write_18C72(Vehicle_18C72_Para para)
        {
            AJ_IWrite aj_18C72 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            Vehicle_18C72_Result aj_18C72_Result = aj_18C72.Write_18C72(para);
            return aj_18C72_Result;
        }

        /// <summary>
        /// 路试检验信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18C54_Result AJ_Write_18C54(Vehicle_18C54_Para para)
        {
            AJ_IWrite aj_18C54 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            Vehicle_18C54_Result aj_18C54_Result = aj_18C54.Write_18C54(para);
            return aj_18C54_Result;
        }

        /// <summary>
        /// 机动车检验照片和资料照片信息
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18C63_Result AJ_Write_18C63(Vehicle_18C63_Para para)
        {
            AJ_IWrite aj_18C63 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            Vehicle_18C63_Result aj_18C63_Result = aj_18C63.Write_18C63(para);
            return aj_18C63_Result;
        }

        /// <summary>
        /// 18X05
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        public Vehicle_18X05_Result AJ_Write_18X05(Vehicle_18X05_Para para)
        {
            AJ_IWrite aj_18X05 = new AJ_Write_WebServices();
            if (!string.IsNullOrEmpty(para.hphm))
            {
                if (para.hphm.Contains("挂"))
                {
                    para.hphm = para.hphm.Replace("挂", "");
                }
                if (para.hphm.Contains("学"))
                {
                    para.hphm = para.hphm.Replace("学", "");
                }
                if (para.hphm.Contains("警"))
                {
                    para.hphm = para.hphm.Replace("警", "");
                }
            }
            Vehicle_18X05_Result aj_18X05_Result = aj_18X05.Write_18X05(para);
            return aj_18X05_Result;
        }

        public Vehicle_18W05_Result AJ_Write_18W05(Vehicle_18W05_Para para)
        {
            AJ_IWrite aj_18W05 = new AJ_Write_WebServices();
            Vehicle_18W05_Result result = aj_18W05.Write_18W05(para);
            return result;
        }

    }
}
