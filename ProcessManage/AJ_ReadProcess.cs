using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleForNetWebServices;
using VehicleNetBase;
using gfVehicleLibraryAJ;
using System.Threading.Tasks;

namespace ProcessManage
{
    public class AJ_ReadProcess
    {
        public Vehicle_18J52_Result AJ_Read_18J52(Vehicle_18J52_Para para)
        {
            AJ_IRead aj_18J52 = new AJ_Read_WebServices();
            Vehicle_18J52_Result aj_18J52_Result = aj_18J52.Read_18J52(para);

            if (aj_18J52_Result.code == "1")
            {
                AdapterHelper adapter = new AdapterHelper();
                aj_18J52_Result.jylb = adapter.UpdateJYLB_Net_To_IY(aj_18J52_Result.jylb);
                aj_18J52_Result.syxz = adapter.UpdateSYXZ_Net_To_IY(aj_18J52_Result.syxz);
                aj_18J52_Result.qdzwz = adapter.UpdateQDZWZ_Net_To_IY(aj_18J52_Result.qdxs);
                aj_18J52_Result.qdxs = adapter.UpdateQDXS_Net_To_IY(aj_18J52_Result.qdxs, aj_18J52_Result.zzs.Value.ToString());
                aj_18J52_Result.qzdz = adapter.UpdateQZDZ_Net_To_IY(aj_18J52_Result.qzdz);
                aj_18J52_Result.sfqszxz = "1";
                aj_18J52_Result.zczw = adapter.UpdateZCZW_Net_To_IY(aj_18J52_Result.zczw);
            }
            
            return aj_18J52_Result;
        }

        public Vehicle_18C49_Result AJ_Read_18C49(Vehicle_18C49_Para para)
        {
            AJ_IRead aj_18C49 = new AJ_Read_WebServices();
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
            Vehicle_18C49_Result aj_18C49_Result = aj_18C49.Read_18C49(para);
            AdapterHelper adapter = new AdapterHelper();
            aj_18C49_Result.rlzl = adapter.UpdateRLZL_Net_To_IY(aj_18C49_Result.rlzl);
            aj_18C49_Result.syxz = adapter.UpdateSYXZ_Net_To_IY(aj_18C49_Result.syxz);
            return aj_18C49_Result;
        }

        public Vehicle_18C50_Result AJ_Read_18C50(Vehicle_18C50_Para para)
        {
            AJ_IRead aj_18C50 = new AJ_Read_WebServices();
            Vehicle_18C50_Result aj_18C50_Result = aj_18C50.Read_18C50(para);
            return aj_18C50_Result;
        }

        public Vehicle_18J80_Result AJ_Read_18J80(Vehicle_18J80_Para para)
        {
            Vehicle_18J80_Result aj_18J80_Result = new Vehicle_18J80_Result();
            AJ_IRead aj_18J80 = new AJ_Read_WebServices();
            AdapterHelper adapter = new AdapterHelper();
#if RZLD

            string[] strAryJYXM;
            if (para.jyxm.Contains(","))
            {
                strAryJYXM = para.jyxm.Split(',');
            }
            else
            {
                strAryJYXM = new string[1];
                strAryJYXM[0] = para.jyxm;
            }


            Vehicle_18X01_Para m_18X01_Para = null;
            Vehicle_18X02_Para m_18X02_Para = null;
            Vehicle_18X03_Para m_18X03_Para = null;

            if (strAryJYXM.Contains("F1"))
            {
                m_18X01_Para = new Vehicle_18X01_Para("18X01", para.jkxlh, para.xtlb);
                m_18X01_Para.cllx = para.cllx;
                m_18X01_Para.clsbdh = para.clsbdh;
                m_18X01_Para.hphm = para.hphm;
                m_18X01_Para.hpzl = para.hpzl;
                m_18X01_Para.jycs = para.jycs;
                m_18X01_Para.jyjgbh = para.jyjgbh;
                m_18X01_Para.jylsh = para.jylsh;
            }

            if (strAryJYXM.Contains("C1"))
            {
                m_18X02_Para = new Vehicle_18X02_Para("18X02", para.jkxlh, para.xtlb);
                m_18X02_Para.cllx = para.cllx;
                m_18X02_Para.clsbdh = para.clsbdh;
                m_18X02_Para.hphm = para.hphm;
                m_18X02_Para.hpzl = para.hpzl;
                m_18X02_Para.jycs = para.jycs;
                m_18X02_Para.jyjgbh = para.jyjgbh;
                m_18X02_Para.jylsh = para.jylsh;
            }

            if (strAryJYXM.Contains("DC"))
            {
                m_18X03_Para = new Vehicle_18X03_Para("18X03", para.jkxlh, para.xtlb);
                m_18X03_Para.cllx = para.cllx;
                m_18X03_Para.clsbdh = para.clsbdh;
                m_18X03_Para.hphm = para.hphm;
                m_18X03_Para.hpzl = para.hpzl;
                m_18X03_Para.jycs = para.jycs;
                m_18X03_Para.jyjgbh = para.jyjgbh;
                m_18X03_Para.jylsh = para.jylsh;
            }

            Func<object, ResultParent> action = (object obj) =>
            {
                ResultParent result = null;
                if (obj is Vehicle_18X01_Para && m_18X01_Para != null)
                {
                    result = aj_18J80.Read_18X01(m_18X01_Para);
                }
                else if (obj is Vehicle_18X02_Para && m_18X02_Para != null)
                {
                    //result = aj_18J80.Read_18X02(m_18X02_Para);
                }
                else if (obj is Vehicle_18X03_Para && m_18X03_Para != null)
                {
                    result = aj_18J80.Read_18X03(m_18X03_Para);
                }
                return result;
            };


            Task<ResultParent> tk_18X01 = Task.Factory.StartNew(action, m_18X01_Para);
            Task<ResultParent> tk_18X02 = Task.Factory.StartNew(action, m_18X02_Para);
            Task<ResultParent> tk_18X03 = Task.Factory.StartNew(action, m_18X03_Para);

            Task<ResultParent>[] tasks = new Task<ResultParent>[3] { tk_18X01, tk_18X02, tk_18X03 };
            Task.WaitAll(tasks);

            aj_18J80_Result.jkid = para.jkid;
            aj_18J80_Result.jkxlh = para.jkxlh;
            aj_18J80_Result.xtlb = para.xtlb;

            bool bIsSuc = true;
            for (int i = 0; i < 3; i++)
            {
                var vResult = tasks[i].Result;
                if (vResult != null)
                {
                    if (vResult is Vehicle_18X01_Result)
                    {
                        Vehicle_18X01_Result m_18X01_Result = (Vehicle_18X01_Result)vResult;
                        aj_18J80_Result.rgjybhgx = adapter.UpdateWJDP_Net_To_IY(m_18X01_Result.pre_GaWjfjx);
                        aj_18J80_Result.rgjybjcx = adapter.UpdateWJDP_Net_To_IY(m_18X01_Result.pre_GawjPbx);

                        aj_18J80_Result.wgjcczy = m_18X01_Result.ass_wjy;
                        if (m_18X01_Result.code != "1")
                        {
                            aj_18J80_Result.message = " 外检失败 ";
                            bIsSuc = false;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(m_18X01_Result.ass_wjy))
                            {
                                bIsSuc = false;
                                aj_18J80_Result.message = " 外检未检 ";
                            }
                            else
                            {
                                aj_18J80_Result.message = " 外检成功 ";
                            }
                        }
                    }
                    else if (vResult is Vehicle_18X02_Result)
                    {
                        Vehicle_18X02_Result m_18X02_Result = (Vehicle_18X02_Result)vResult;


                        aj_18J80_Result.dgjybhgx = adapter.UpdateWJDP_Net_To_IY(m_18X02_Result.pre_GaDjfjx);
                        aj_18J80_Result.dgjybjcx = adapter.UpdateWJDP_Net_To_IY(m_18X02_Result.pre_GaDjpbx);
                        aj_18J80_Result.dpbjczy = m_18X02_Result.ass_xfjcy;

                        if (m_18X02_Result.code != "1")
                        {
                            bIsSuc = false;
                            aj_18J80_Result.message += "  底盘部件失败 ";
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(m_18X02_Result.ass_xfjcy))
                            {
                                bIsSuc = false;
                                aj_18J80_Result.message += " 底盘部件未检 ";
                            }
                            else
                            {
                                aj_18J80_Result.message += "  底盘部件成功 ";
                            }
                        }
                    }
                    else if (vResult is Vehicle_18X03_Result)
                    {
                        Vehicle_18X03_Result m_18X03_Result = (Vehicle_18X03_Result)vResult;

                        aj_18J80_Result.dgjybhgx += adapter.UpdateWJDP_Net_To_IY(m_18X03_Result.pre_GaDpdtfjx);
                        aj_18J80_Result.dgjybjcx += adapter.UpdateWJDP_Net_To_IY(m_18X03_Result.pre_GaDpdtpbx);
                        aj_18J80_Result.dtdpczy = m_18X03_Result.diPDTJCY;

                        if (m_18X03_Result.code != "1")
                        {
                            bIsSuc = false;
                            aj_18J80_Result.message += "  动态底盘失败 ";
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(m_18X03_Result.diPDTJCY))
                            {
                                bIsSuc = false;
                                aj_18J80_Result.message += " 动态底盘未检 ";
                            }
                            else
                            {
                                aj_18J80_Result.message += "  动态底盘成功 ";
                            }
                        }
                    }
                }
            }

            aj_18J80_Result.code = bIsSuc ? "1" : "0";
#endif

            return aj_18J80_Result;
        }

        public Vehicle_18W06_Result AJ_Read_18W06(Vehicle_18W06_Para para)
        {
            Vehicle_18W06_Result _18W06_RESULT = new Vehicle_18W06_Result();
            AJ_IRead aj_18W06 = new AJ_Read_WebServices();
            _18W06_RESULT = aj_18W06.Read_18W06(para);
            return _18W06_RESULT;
        }
    }
}
