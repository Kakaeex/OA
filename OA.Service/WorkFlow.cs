using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OA.Interface;
using OAContext;
using FineUI;
using DBContextHelper;
using OA.Common;

namespace OA.Service
{
    public class WorkFlow : IWorkflow
    {
        public IDataRepository _DBHelper { get; set; }
        public IOrder _Order { get; set; }
        public IMessage _Message { get; set; }
        public IAccount _Account { get; set; }
        public WorkFlow()
        { }

        public WorkFlow(IDataRepository DBHelper, IOrder Order, IMessage Message, IAccount Account)
        {
            _DBHelper = DBHelper;
            _Order = Order;
            _Message = Message;
            _Account = Account;
        }
        public string CreateCostWorkflow(int doco)
        {
            return "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="doco">工作流单号</param>
        /// <param name="dcto">工作流类型</param>
        /// <param name="an8">审批人</param>
        /// <param name="argeement">审批意见</param>
        /// <param name="status">审批状态</param>
        /// <returns></returns>
        public string ProccessCostWorkflow(int doco, string dcto, string an8, string argeement, string status, string user_id)
        {
            string message = "";
            //var e_F2012_list = _DBHelper.FindAll<C_F2012, int>(p => p.WFDOCO == doco & p.WFDCTO == dcto, p => p.WFLNID);
            C_F0930 e_F0930 = _DBHelper.Find<C_F0930>(p => p.CHDOCO == doco & p.CHDCTO == dcto);
            e_F0930.CHADDJ = DateTime.Now;
            C_F2012 e_F2012;
            if (ValueConvert.toInt(e_F0930.CHNXTR) >= 200)
            {
                e_F2012 = _DBHelper.Find<C_F2012>(p => p.WFDOCO == doco & p.WFDCTO == dcto & p.WFSRP1 == "W");
                int e_step = GetNextStep(e_F2012.WFFDOC, e_F2012.WFPRP1);
                string e_nxtr = GetNextWorkflowNxtr(e_F2012.WFFDOC, e_F2012.WFPRP1, e_F0930.CHNXTR);
                #region 取消工作流
                if (status == "N")
                {
                    CancelCostWorkflow(doco, dcto, user_id);
                    //释放项目占用数
                    _Account.ReleaseCostProjectApply(e_F0930.CHDOCO, e_F0930.CHDCTO,"Cancel");
                    return message;
                }
                #endregion

                if (e_step == e_F2012.WFPRP1)
                {
                    #region 结束工作流
                    e_F2012.WFVR02 = argeement;//审批人意见
                    e_F2012.WFSRP1 = status;//审批状态，W待审批，Y通过，N否决
                    e_F2012.WFUSER = user_id;
                    _DBHelper.Update<C_F2012>(e_F2012);//审批人

                    //释放项目占用数，增加总账和项目发生数
                    _Account.ReleaseCostProjectApply(e_F0930.CHDOCO, e_F0930.CHDCTO, "AccountActual");

                    //结束费用单
                    e_F0930.CHNXTR = "999";
                    e_F0930.CHADDJ = DateTime.Now;
                    _DBHelper.Update<C_F0930>(e_F0930);
                    #endregion
                }
                else if (e_step > e_F2012.WFPRP1)
                {
                    #region 工作流流转
                    //e_F2012.WFVR01 = an8;//下一审批人
                    e_F2012.WFVR02 = argeement;//审批人意见
                    e_F2012.WFSRP1 = status;//审批状态，W待审批，Y通过，N否决
                    e_F2012.WFUSER = user_id;
                    _DBHelper.Update<C_F2012>(e_F2012);

                    int e_lind = e_F2012.WFLNID;
                    C_F2001 e_F2001_1 = _DBHelper.Find<C_F2001>(p => p.WDDOCO == e_F0930.CHDOC & p.WDLIND == e_step);

                    e_F2012 = new C_F2012(1);
                    e_F2012.WFDOCO = doco;//工作流单号，与费用单号相同
                    e_F2012.WFDCTO = dcto;//工作流类型，与费用单类型相同
                    e_F2012.WFLNID = e_lind + 1;
                    e_F2012.WFCDOC = e_F0930.CHDOCO;//费用单号
                    e_F2012.WFCDCT = e_F0930.CHDCTO;//费用单类型
                    e_F2012.WFDEL1 = e_F0930.CHDSC1;//费用单描述
                    e_F2012.WFDEL2 = "";
                    e_F2012.WFFDOC = e_F2001_1.WDDOCO;//工作流程单号
                    e_F2012.WFFDCT = e_F2001_1.WDDCTO;//工作流程类型
                    e_F2012.WFDSC1 = e_F2001_1.WDDSC1;//工作流程描述
                    e_F2012.WFPRP1 = e_F2001_1.WDLIND;//工作流程步骤
                    e_F2012.WFDSC2 = e_F2001_1.WDDSC2;//工作流程步骤描述
                    e_F2012.WFVR01 = an8;//审批人
                    e_F2012.WFVR02 = "";//审批人意见
                    e_F2012.WFSRP1 = "W";//审批状态，W待审批，Y通过，N否决
                    e_F2012.WFSRP2 = "";//费用雇员
                    e_F2012.WFSRP3 = "";//制单人
                    e_F2012.WFSRP4 = e_F2001_1.WDDCT;//流转类型
                    e_F2012.WFSRP5 = "";
                    e_F2012.WFPRP2 = 0;
                    e_F2012.WFPRP3 = 0;
                    e_F2012.WFPRP4 = 0;
                    e_F2012.WFPRP5 = 0;
                    e_F2012.WFUSER = user_id;
                    e_F2012.WFPID = "IWorkflow";
                    e_F2012.WFDATE = DateTime.Now;
                    e_F2012.WFTIME = DateTime.Now.TimeOfDay;

                    _DBHelper.Insert<C_F2012>(e_F2012);
                    #endregion
                    if (e_F0930.CHNXTR != e_nxtr)
                    {
                        e_F0930.CHNXTR = e_nxtr;
                        _DBHelper.Update<C_F0930>(e_F0930);
                    }
                }
            }
            else if (e_F0930.CHNXTR == "100")
            {
                #region 新增工作流
                var e_F2001 = _DBHelper.FindAll<C_F2001, int>(p => p.WDDOCO == e_F0930.CHDOC, p => p.WDLIND).First();
                e_F2012 = new C_F2012(1);
                e_F2012.WFDOCO = doco;//工作流单号，与费用单号相同
                e_F2012.WFDCTO = dcto;//工作流类型，与费用单类型相同
                e_F2012.WFLNID = 1;
                e_F2012.WFCDOC = e_F0930.CHDOCO;//费用单号
                e_F2012.WFCDCT = e_F0930.CHDCTO;//费用单类型
                e_F2012.WFDEL1 = e_F0930.CHDSC1;//费用单描述
                e_F2012.WFDEL2 = "";
                e_F2012.WFFDOC = e_F2001.WDDOCO;//工作流程单号
                e_F2012.WFFDCT = e_F2001.WDDCTO;//工作流程类型
                e_F2012.WFDSC1 = e_F2001.WDDSC1;//工作流程描述
                e_F2012.WFPRP1 = e_F2001.WDLIND;//工作流程步骤
                e_F2012.WFDSC2 = e_F2001.WDDSC2;//工作流程步骤描述
                e_F2012.WFVR01 = an8;//审批人
                e_F2012.WFVR02 = argeement;//审批人意见
                e_F2012.WFSRP1 = "W";//审批状态，W待审批，Y通过，N否决
                e_F2012.WFSRP2 = "";//费用雇员
                e_F2012.WFSRP3 = "";//制单人
                e_F2012.WFSRP4 = e_F2001.WDDCT;//流转类型
                e_F2012.WFSRP5 = "";
                e_F2012.WFPRP2 = 0;
                e_F2012.WFPRP3 = 0;
                e_F2012.WFPRP4 = 0;
                e_F2012.WFPRP5 = 0;
                e_F2012.WFUSER = user_id;
                e_F2012.WFPID = "IWorkflow";
                e_F2012.WFDATE = DateTime.Now;
                e_F2012.WFTIME = DateTime.Now.TimeOfDay;
                _DBHelper.Insert<C_F2012>(e_F2012);

                e_F0930.CHNXTR = "200";
                e_F0930.CHADDJ = DateTime.Now;
                _DBHelper.Update<C_F0930>(e_F0930);
                #endregion

            }
            else if (e_F0930.CHNXTR == "999")
            {

            }
            return message;
        }
        public int GetNextStep(int doco, int step)
        {
            var e_F2001 = _DBHelper.FindAll<C_F2001, int>(p => p.WDDOCO == doco & p.WDLIND > step, p => p.WDLIND).FirstOrDefault();
            return e_F2001 == null ? step : e_F2001.WDLIND;
        }

        public string GetNextWorkflowNxtr(int doco, int step, string lttr)
        {
            var e_F2001 = _DBHelper.FindAll<C_F2001, int>(p => p.WDDOCO == doco & p.WDLIND > step, p => p.WDLIND).FirstOrDefault();
            return e_F2001 == null ? lttr : e_F2001.WDSRP2;
        }

        public C_F2012 GetWorkflow(int doco, string dcto)
        {
            C_F2012 e_f2012 = _DBHelper.Find<C_F2012>(p => p.WFDOCO == doco & p.WFDCTO == dcto & p.WFSRP1 == "W");
            return e_f2012;
        }

        public int GetWorkflowOrderNumber(string kcoo, string dcto)
        {
            return _Order.GetNextNumber(dcto, kcoo, "审批流");
        }

        /// <summary>
        /// 取消费用工作流
        /// </summary>
        /// <param name="doco"></param>
        /// <param name="dcto"></param>
        /// <param name="user_id"></param>
        /// <returns></returns>
        string CancelCostWorkflow(int doco, string dcto, string user_id)
        {
            C_F0930 e_F0930 = _DBHelper.Find<C_F0930>(p => p.CHDOCO == doco);
            e_F0930.CHNXTR = "980";
            e_F0930.CHCNDJ = DateTime.Now;
            _DBHelper.Update<C_F0930>(e_F0930);

            CancelWorkflow(doco, dcto, user_id);
            return "";
        }

        /// <summary>
        /// 取消工作流
        /// </summary>
        /// <param name="doco"></param>
        /// <param name="dcto"></param>
        /// <param name="user_id"></param>
        /// <returns></returns>
        string CancelWorkflow(int doco, string dcto, string user_id)
        {
            C_F2012 e_F2012 = _DBHelper.Find<C_F2012>(p => p.WFDOCO == doco & p.WFDCTO == dcto & p.WFSRP1 == "W");
            e_F2012.WFSRP1 = "N";
            e_F2012.WFUSER = user_id;
            _DBHelper.Update<C_F2012>(e_F2012);
            return "";
        }

    }
}
