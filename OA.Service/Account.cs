using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OA.Interface;
using OAContext;
using DBContextHelper;

namespace OA.Service
{
    public class Account : IAccount
    {
        public IDataRepository _DBHelper { get; set; }
        public IOrder _Order { get; set; }
        public Account()
        {

        }

        public Account(IDataRepository DBHelper, IOrder order)
        {
            _DBHelper = DBHelper;
            _Order = order;
        }


        public dynamic AccountLedgerAdd(C_F0911 _F0911)
        {
            _F0911.GLDOC = _Order.GetNextNumber(_F0911.GLDCT, "00068", "C_F0911");
            return _DBHelper.Insert(_F0911);
        }

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
