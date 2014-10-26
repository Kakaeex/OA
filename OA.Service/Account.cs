using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OA.Interface;
using OAContext;
using DBContextHelper;
using OA.Common;

namespace OA.Service
{
    public class Account : IAccount
    {
        public IDataRepository _DBHelper { get; set; }
        public IOrder _Order { get; set; }
        public IMessage _Message { get; set; }
        public Account()
        {

        }

        public Account(IDataRepository DBHelper, IOrder order, IMessage message)
        {
            _DBHelper = DBHelper;
            _Order = order;
            _Message = message;
        }

        public dynamic AccountLedgerAdd(C_F0911 _F0911)
        {
            _F0911.GLDOC = _Order.GetNextNumber(_F0911.GLDCT, "00068", "C_F0911");
            return _DBHelper.Insert(_F0911);
        }
        /// <summary>
        /// 调整总账余额
        /// </summary>
        /// <param name="C_F0902"></param>
        /// <returns></returns>
        public dynamic AccountMasterAdjust(C_F0902 C_F0902)
        {
            return _DBHelper.AddorUpdate<C_F0902>(C_F0902);
        }
        public dynamic EDI_Z_ODS_F0902(int doco, string status, string user, string pid)
        {
            var _F0902Z1 = _DBHelper.FindAll<Z_ODS_F0902, int>(p => p.DOCO == doco & p.STATUS == status, p => p.DOCO);
            foreach (Z_ODS_F0902 _f0902z1 in _F0902Z1)
            {
                C_F0902 _f0902 = _DBHelper.Find<C_F0902>(p => p.GBCO == _f0902z1.OU_ID & p.GBMCU == _f0902z1.BU_ID
                    & p.GBAID == _f0902z1.ACCOUNT_OBJ & p.GBSUB == _f0902z1.ACCOUNT_SUB & p.GBCTRY == _f0902z1.FY
                    & p.GBFY == _f0902z1.YEAR & p.GBLT == _f0902z1.LT);

                if (_f0902 == null)
                {
                    _f0902 = new C_F0902(1);
                    _f0902.GBCO = _f0902z1.OU_ID;
                    _f0902.GBMCU = _f0902z1.BU_ID;
                    _f0902.GBAID = _f0902z1.ACCOUNT_OBJ;
                    _f0902.GBCTRY = (int)_f0902z1.FY;
                    _f0902.GBFY = (int)_f0902z1.YEAR;
                    _f0902.GBLT = _f0902z1.LT;
                    _f0902.GBUSER = user;
                    _f0902.GBPID = pid;
                }
                C_F0911 F0911 = new C_F0911(1);
                decimal? BUDGET_DATA = 0;
                switch (_f0902z1.PERIOD)
                {
                    case "QBEGIN":
                        if (_f0902z1.BUDGET_DATA == _f0902.GBQ00) break;
                        BUDGET_DATA = _f0902.GBQ00;
                        _f0902.GBQ00 = _f0902z1.BUDGET_DATA;
                        AccountMasterAdjust(InitF0902(_f0902));

                        F0911.GLKCO = _f0902z1.OU_ID;
                        F0911.GLDCT = "JN";
                        F0911.GLDGJ = DateTime.Now;
                        F0911.GLLIND = 0;
                        F0911.GLICU = _f0902z1.DOCO;
                        F0911.GLCO = _f0902z1.OU_ID;
                        F0911.GLMCU = _f0902z1.BU_ID;
                        F0911.GLAID = _f0902z1.ACCOUNT_OBJ;
                        F0911.GLLT = _f0902z1.LT;
                        F0911.GLAA = _f0902z1.BUDGET_DATA - BUDGET_DATA;
                        F0911.GLCTRY = _f0902z1.FY;
                        F0911.GLFY = _f0902z1.YEAR;

                        AccountLedgerAdd(F0911);
                        break;
                    case "Q1":
                        if (_f0902z1.BUDGET_DATA == _f0902.GBQ01) break;
                        BUDGET_DATA = _f0902.GBQ01;
                         _f0902.GBQ01=_f0902z1.BUDGET_DATA ;
                        AccountMasterAdjust(_f0902);

                        F0911.GLKCO = _f0902.GBCO;
                        F0911.GLDCT = "JE";
                        F0911.GLDGJ = _f0902.GBDATE;
                        F0911.GLLIND = 0;
                        F0911.GLICU = _f0902z1.DOCO;
                        F0911.GLCO = _f0902.GBCO;
                        F0911.GLMCU = _f0902z1.BU_ID;
                        F0911.GLAID = _f0902.GBAID;
                        F0911.GLLT = _f0902.GBLT;
                        F0911.GLAA = _f0902z1.BUDGET_DATA - BUDGET_DATA;
                        F0911.GLCTRY = _f0902.GBCTRY;
                        F0911.GLFY = _f0902.GBFY;

                        AccountLedgerAdd(F0911);
                        break;
                    case "Q2":
                        if (_f0902z1.BUDGET_DATA == _f0902.GBQ02) break;
                        BUDGET_DATA = _f0902.GBQ02;
                        _f0902.GBQ02 = _f0902z1.BUDGET_DATA;
                        AccountMasterAdjust(_f0902);

                        F0911.GLKCO = _f0902.GBCO;
                        F0911.GLDCT = "JE";
                        F0911.GLDGJ = _f0902.GBDATE;
                        F0911.GLLIND = 0;
                        F0911.GLICU = _f0902z1.DOCO;
                        F0911.GLCO = _f0902.GBCO;
                        F0911.GLMCU = _f0902z1.BU_ID;
                        F0911.GLAID = _f0902.GBAID;
                        F0911.GLLT = _f0902.GBLT;
                        F0911.GLAA = _f0902z1.BUDGET_DATA - BUDGET_DATA;
                        F0911.GLCTRY = _f0902.GBCTRY;
                        F0911.GLFY = _f0902.GBFY;

                        AccountLedgerAdd(F0911);
                        break;
                    case "Q3":
                        if (_f0902z1.BUDGET_DATA == _f0902.GBQ03) break;
                        BUDGET_DATA = _f0902.GBQ03;
                        _f0902.GBQ03 = _f0902z1.BUDGET_DATA;
                        AccountMasterAdjust(_f0902);

                        F0911.GLKCO = _f0902.GBCO;
                        F0911.GLDCT = "JE";
                        F0911.GLDGJ = _f0902.GBDATE;
                        F0911.GLLIND = 0;
                        F0911.GLICU = _f0902z1.DOCO;
                        F0911.GLCO = _f0902.GBCO;
                        F0911.GLMCU = _f0902z1.BU_ID;
                        F0911.GLAID = _f0902.GBAID;
                        F0911.GLLT = _f0902.GBLT;
                        F0911.GLAA = _f0902z1.BUDGET_DATA - BUDGET_DATA;
                        F0911.GLCTRY = _f0902.GBCTRY;
                        F0911.GLFY = _f0902.GBFY;

                        AccountLedgerAdd(F0911);
                        break;
                    case "Q4":
                        if (_f0902z1.BUDGET_DATA == _f0902.GBQ04) break;
                        BUDGET_DATA = _f0902.GBQ04;
                        _f0902.GBQ04 = _f0902z1.BUDGET_DATA;
                        AccountMasterAdjust(_f0902);

                        F0911.GLKCO = _f0902.GBCO;
                        F0911.GLDCT = "JE";
                        F0911.GLDGJ = _f0902.GBDATE;
                        F0911.GLLIND = 0;
                        F0911.GLICU = _f0902z1.DOCO;
                        F0911.GLCO = _f0902.GBCO;
                        F0911.GLMCU = _f0902z1.BU_ID;
                        F0911.GLAID = _f0902.GBAID;
                        F0911.GLLT = _f0902.GBLT;
                        F0911.GLAA = _f0902z1.BUDGET_DATA - BUDGET_DATA;
                        F0911.GLCTRY = _f0902.GBCTRY;
                        F0911.GLFY = _f0902.GBFY;

                        AccountLedgerAdd(F0911);
                        break;
                    case "QEND":
                        if (_f0902z1.BUDGET_DATA == _f0902.GBQ05) break;
                        BUDGET_DATA = _f0902.GBQ05;
                        _f0902.GBQ05 = _f0902z1.BUDGET_DATA;
                        AccountMasterAdjust(_f0902);

                        F0911.GLKCO = _f0902.GBCO;
                        F0911.GLDCT = "JN";
                        F0911.GLDGJ = _f0902.GBDATE;
                        F0911.GLLIND = 0;
                        F0911.GLICU = _f0902z1.DOCO;
                        F0911.GLCO = _f0902.GBCO;
                        F0911.GLMCU = _f0902z1.BU_ID;
                        F0911.GLAID = _f0902.GBAID;
                        F0911.GLLT = _f0902.GBLT;
                        F0911.GLAA = _f0902z1.BUDGET_DATA - BUDGET_DATA;
                        F0911.GLCTRY = _f0902.GBCTRY;
                        F0911.GLFY = _f0902.GBFY;

                        AccountLedgerAdd(F0911);
                        break;
                }
                _f0902z1.STATUS = "Y";
                _DBHelper.Update<Z_ODS_F0902>(_f0902z1);
            }
            return 0;
        }

        /// <summary>
        /// newAdded,modified,delete 总账信用额度检查
        /// </summary>
        /// <param name="F0921"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public dynamic AccountLimitedCheck(C_F0921 F0921, string mode)
        {
            if (F0921.FDUPRC < 0) return _Message.GetMessage("WARM", "0003").MSDSC1;
            var F0902 = _DBHelper.Find<C_F0902>(p => p.GBCO == F0921.FDKCOO & p.GBMCU == F0921.FDMCU & p.GBAID == F0921.FDAID
                 & p.GBFY == F0921.FDYAER & p.GBLT == "BA");
            var old_F0921 = _DBHelper.FindByKey<C_F0921>(F0921.FDDOCO, F0921.FDDCTO, F0921.FDLNID);
            switch (mode)
            {
                case "newAdded":
                    decimal? apply = GetAccountTotal(F0902) - F0921.FDUPRC;
                    if (apply < 0) return _Message.GetMessage("WARM", "001").MSDSC1;
                    break;
                case "modified":
                    decimal? values = 0;
                    if (F0921.FDUPRC < old_F0921.FDUPRC)
                    {
                        values = F0921.FDUPRC - old_F0921.FDAPYN - old_F0921.FDAWTD;
                        if (values < 0) return _Message.GetMessage("WARM", "002").MSDSC1;
                    }
                    else if (F0921.FDUPRC > old_F0921.FDUPRC)
                    {
                        values = GetAccountTotal(F0902) - GetCostTotal(F0921);
                        if (values < 0) return _Message.GetMessage("WARM", "001").MSDSC1;
                    }
                    break;
                case "delete":
                    return null;
            }
            return "";
        }

        /// <summary>
        /// 费用项目信用额度检查
        /// </summary>
        /// <param name="F0931"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public dynamic CostProjectLimitedCheck(C_F0931 F0931, string mode)
        {
            ///F0921-F0902
            if (F0931.CDUPRC <= 0) return _Message.GetMessage("WARM", "0003").MSDSC1;
            var F0902 = _DBHelper.Find<C_F0902>(p => p.GBCO == F0931.CDKCOO & p.GBMCU == F0931.CDMMCU & p.GBAID == F0931.CDMAID
                 & p.GBFY == F0931.CDPRP2 & p.GBLT == "BA");
            int e_srp1=ValueConvert.toInt(F0931.CDSRP1);
            var F0921 = _DBHelper.Find<C_F0921>(p => p.FDDOCO == e_srp1 & p.FDLNID == F0931.CDPRP1);
            switch (mode)
            {
                case "newAdded":
                    //检查金额
                    if (((GetAccountTotal(F0902) - F0931.CDUPRC) < 0) || 
                        ((GetCostTotal(F0921) - F0931.CDUPRC) < 0))
                        return _Message.GetMessage("WARM", "001").MSDSC1;
                    //检查字段
                    var e_f0901 = _DBHelper.Find<C_F0901>(p => p.GMMCU == F0931.CDFMCU & p.GMOBJ == F0931.CDFOBJ & p.GMSUB == F0931.CDFSUB);
                    if (e_f0901 == null) return _Message.GetMessage("WARM", "004").MSDSC1;
                    if (F0931.CDUPRC <= 0) return _Message.GetMessage("WARM", "0003").MSDSC1;
                    break;
                case "modified":
                    return "";
                case "delete":
                    return null;
            }
            return "";
        }

        /// <summary>
        /// 调整项目占用数
        /// </summary>
        /// <param name="F0931"></param>
        /// <returns></returns>
        public dynamic CostProjectEditApply(C_F0931 F0931)
        {
            int e_srp1 = ValueConvert.toInt(F0931.CDSRP1);
            var F0921 = _DBHelper.Find<C_F0921>(p => p.FDDOCO == e_srp1 & p.FDLNID == F0931.CDPRP1);

            F0921.FDAPYN += F0931.CDUPRC;
            _DBHelper.Update<C_F0921>(F0921);
            return "";
        }
        /// <summary>
        /// 释放项目占用数
        /// </summary>
        /// <param name="cddoco">费用单号</param>
        /// <param name="cddcto">费用单类型</param>
        /// <returns></returns>
        public string ReleaseCostProjectApply(int cddoco, string cddcto,string mode)
        {
            if (mode == "Cancel")
            {
                var e_list_F0931 = _DBHelper.FindAll<C_F0931, int>(
                                p => p.CDDOCO == cddoco & p.CDDCTO == cddcto, p => p.CDDLNID);
                foreach (var ev_dd in e_list_F0931)
                {
                    ev_dd.CDUPRC = ev_dd.CDUPRC * -1;
                    CostProjectEditApply(ev_dd);
                }
            }
            else if (mode == "AccountActual")
            {
                var e_list_F0931 = _DBHelper.FindAll<C_F0931, int>(
                           p => p.CDDOCO == cddoco & p.CDDCTO == cddcto, p => p.CDDLNID);
                foreach (var ev_dd in e_list_F0931)
                {
                    CostProjectEditActual(ev_dd);
                }
            }
            return "";
        }

        /// <summary>
        /// 调整总账余额占用数
        /// </summary>
        /// <param name="F0921"></param>
        /// <returns></returns>
        public dynamic AccountMastertEditApply(C_F0921 F0921)
        {
            C_F0902 obj = _DBHelper.Find<C_F0902>(p => p.GBAID == F0921.FDAID & p.GBMCU == F0921.FDMCU & p.GBFY == F0921.FDYAER);
            C_F0921 e_F0921 = _DBHelper.FindByKey<C_F0921>(F0921.FDDOCO, F0921.FDDCTO, F0921.FDLNID);
            obj.GBAWTD += (GetCostTotal(F0921) - GetCostTotal(e_F0921));

            _DBHelper.AddorUpdate(InitF0902(obj));
            return null;
        }

        /// <summary>
        /// 调整项目发生数
        /// </summary>
        /// <param name="F0931"></param>
        /// <returns></returns>
        public dynamic CostProjectEditActual(C_F0931 F0931)
        {
            C_F0902 obj = _DBHelper.Find<C_F0902>(
                p => p.GBAID == F0931.CDMAID & p.GBMCU == F0931.CDMMCU & p.GBFY == F0931.CDPRP2);
            obj.GBAWTD -= F0931.CDUPRC;
            obj.GBBORG += F0931.CDUPRC;
            _DBHelper.Update<C_F0902>(obj);

            int e_srp1 = ValueConvert.toInt(F0931.CDSRP1);
            var F0921 = _DBHelper.Find<C_F0921>(p => p.FDDOCO == e_srp1 & p.FDLNID == F0931.CDPRP1);
            F0921.FDAPYN -= F0931.CDUPRC;
            F0921.FDAWTD += F0931.CDUPRC;
            _DBHelper.Update<C_F0921>(F0921);
            return "";
        }

        decimal? GetAccountTotal(C_F0902 F0902)
        {
            return (F0902.GBQ00 + F0902.GBQ01 + F0902.GBQ02 + F0902.GBQ03 + F0902.GBQ04 + F0902.GBQ05 - F0902.GBAWTD - F0902.GBBORG);
        }
        decimal? GetCostTotal(C_F0921 F0921)
        {
            return (F0921.FDUPRC - F0921.FDAPYN - F0921.FDAWTD);
        }
        C_F0902 InitF0902(C_F0902 _f0902)
        {
            C_F0902 obj = new C_F0902(1);
            obj.GBCO = _f0902.GBCO;
            obj.GBMCU = _f0902.GBMCU;
            obj.GBAID = _f0902.GBAID;
            obj.GBCTRY = _f0902.GBCTRY;
            obj.GBFY = _f0902.GBFY;
            obj.GBLT = _f0902.GBLT;
            obj.GBOBJ = _f0902.GBOBJ;
            obj.GBSUB = _f0902.GBSUB;
            obj.GBAPYC = _f0902.GBAPYC;
            obj.GBAN01 = _f0902.GBAN01;
            obj.GBAN02 = _f0902.GBAN02;
            obj.GBAN03 = _f0902.GBAN03;
            obj.GBAN04 = _f0902.GBAN04;
            obj.GBAN05 = _f0902.GBAN05;
            obj.GBAN06 = _f0902.GBAN06;
            obj.GBAN07 = _f0902.GBAN07;
            obj.GBAN08 = _f0902.GBAN08;
            obj.GBAN09 = _f0902.GBAN09;
            obj.GBAN10 = _f0902.GBAN10;
            obj.GBAN11 = _f0902.GBAN11;
            obj.GBAN12 = _f0902.GBAN12;
            obj.GBAN13 = _f0902.GBAN13;
            obj.GBAN14 = _f0902.GBAN14;
            obj.GBQ00 = _f0902.GBQ00;
            obj.GBQ01 = _f0902.GBQ01;
            obj.GBQ02 = _f0902.GBQ02;
            obj.GBQ03 = _f0902.GBQ03;
            obj.GBQ04 = _f0902.GBQ04;
            obj.GBQ05 = _f0902.GBQ05;
            obj.GBAPYN = _f0902.GBAPYN;
            obj.GBAWTD = _f0902.GBAWTD;
            obj.GBBORG = _f0902.GBBORG;
            obj.GBPOU = _f0902.GBPOU;
            obj.GBPC = _f0902.GBPC;
            obj.GBTKER = _f0902.GBTKER;
            obj.GBBREQ = _f0902.GBBREQ;
            obj.GBBAPR = _f0902.GBBAPR;
            obj.GBUSER = _f0902.GBUSER;
            obj.GBPID = _f0902.GBPID;
            obj.GBDATE = DateTime.Now;
            obj.GBTIME = DateTime.Now.TimeOfDay;

            return obj;
        }

    }
}
