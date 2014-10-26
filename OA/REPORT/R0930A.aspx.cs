using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using FineUI;
using Newtonsoft.Json;
using OAContext;
using DBContextHelper;
using OA.Interface;
using OA.Common;
using System.Data;
using System.Web.UI.WebControls;


namespace OA.REPORT
{
    public partial class R0930A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Master.QueryString.ContainsKey("doco") & Master.QueryString.ContainsKey("dcto"))
            {
                bind(ValueConvert.toInt(Master.QueryString["doco"]), Master.QueryString["dcto"]);
            }
        }
        protected void bind(int doco, string dcto)
        {
            TableRow tblrowTitle = new TableRow();

            TableCell headercell = new TableCell();
            headercell.Text = "行";
            tblrowTitle.Cells.Add(headercell);

            headercell = new TableCell();
            headercell.Text = "行备注";
            tblrowTitle.Cells.Add(headercell);

            //headercell = new TableCell();
            //headercell.Text = "管理科目";
            //tblrowTitle.Cells.Add(headercell);

            //headercell = new TableCell();
            //headercell.Text = "管理科目描述";
            //tblrowTitle.Cells.Add(headercell);

            headercell = new TableCell();
            headercell.Text = "科目ID";
            tblrowTitle.Cells.Add(headercell);

            headercell = new TableCell();
            headercell.Text = "科目";
            tblrowTitle.Cells.Add(headercell);

            headercell = new TableCell();
            headercell.Text = "科目描述";
            tblrowTitle.Cells.Add(headercell);

            headercell = new TableCell();
            headercell.Text = "金额";
            tblrowTitle.Cells.Add(headercell);

            table.Rows.Add(tblrowTitle);

            C_F0930 e_f0930 = Master._DBHelper.Find<C_F0930>(p => p.CHDOCO == doco & p.CHDCTO == dcto);

            List<C_F0931> e_f0931 = Master._DBHelper.FindAll<C_F0931, int>(p => p.CDDOCO == doco & p.CDDCTO == dcto, p => p.CDDLNID);
            if (e_f0931.Count <= 0) return;
            CHMCU.Text = e_f0930.CHMCU;
            CHDSC2.Text = e_f0930.CHDSC2;
            CHKCOO.Text = e_f0930.CHKCOO;
            CHKCOO.Label = Master._DBHelper.Find<C_F0010>(p => p.CCCO == CHKCOO.Text).CCNAME;
            CHDCTO.Text =  Master._UDC.GetUDC(CHDCTO.ID, e_f0930.CHDCTO).DRDEL1;
            CHDOCO.Text = e_f0930.CHDOCO.ToString();
            AN8.Text = e_f0930.CHTORG;
            CHSRP2.Text = e_f0930.CHSRP2;
            CHVR01.Text = e_f0930.CHVR01;
            CHVR02.Text = e_f0930.CHVR02;
            CHDSC1.Text = e_f0930.CHDSC1;
            int an8 = ValueConvert.toInt(e_f0930.CHUSER);
            CHUSER.Text = e_f0930.CHUSER + " " + Master._DBHelper.Find<C_F0101>(p => p.ABAN8 == an8).ABALPH;
            CHDATE.Text = e_f0930.CHDATE.ToString("yyyy-MM-dd");
            foreach (C_F0931 obj in e_f0931)
            {
                TableRow tblrow = new TableRow();

                TableCell Cell = new TableCell();
                Cell.BorderWidth = 0; 
                Cell.Text = obj.CDDLNID.ToString();
                Cell.Width = Unit.Parse("30px");
                tblrow.Cells.Add(Cell);

                Cell = new TableCell();
                Cell.BorderWidth = 0;
                Cell.Text = obj.CDDSC1;
                Cell.Width = Unit.Parse("150px");
                tblrow.Cells.Add(Cell);

                //Cell = new TableCell();
                //Cell.BorderWidth = 0; 
                //Cell.Text = obj.CDMAID;
                //Cell.Width = Unit.Parse("80px");
                //tblrow.Cells.Add(Cell);

                //Cell = new TableCell();
                //Cell.BorderWidth = 0; 
                //Cell.Text = obj.CDDEL1;
                //Cell.Width = Unit.Parse("100px");
                //tblrow.Cells.Add(Cell);

                Cell = new TableCell();
                Cell.BorderWidth = 0; 
                Cell.Text = obj.CDFAID;
                Cell.Width = Unit.Parse("100px");
                tblrow.Cells.Add(Cell);

                Cell = new TableCell();
                Cell.BorderWidth = 0; 
                Cell.Text = obj.CDFMCU + "." + obj.CDFOBJ + "." + obj.CDFSUB;
                Cell.Width = Unit.Parse("120px");
                tblrow.Cells.Add(Cell);

                Cell = new TableCell();
                Cell.BorderWidth = 0; 
                Cell.Text = obj.CDDEL2;
                Cell.Width = Unit.Parse("150px");
                tblrow.Cells.Add(Cell);

                Cell = new TableCell();
                Cell.BorderWidth = 0; 
                Cell.Text = obj.CDUPRC.ToString();
                Cell.Width = Unit.Parse("80px");
                tblrow.Cells.Add(Cell);

                
                table.Rows.Add(tblrow);
            }
            TableRow totalrow = new TableRow();

            TableCell total = new TableCell();
            total.BorderWidth = 0;
            total.Text = "";
            total.Width = Unit.Parse("80px");
            totalrow.Cells.Add(total);

            total = new TableCell();
            total.BorderWidth = 0;
            total.Text = "";
            total.Width = Unit.Parse("80px");
            totalrow.Cells.Add(total);

            total = new TableCell();
            total.BorderWidth = 0;
            total.Text = "";
            total.Width = Unit.Parse("80px");
            totalrow.Cells.Add(total);

            total = new TableCell();
            total.BorderWidth = 0;
            total.Text = "";
            total.Width = Unit.Parse("80px");
            totalrow.Cells.Add(total);

            total = new TableCell();
            total.BorderWidth = 0;
            total.Text = "合计:";
            total.Width = Unit.Parse("80px");
            totalrow.Cells.Add(total);

            total = new TableCell();
            total.BorderWidth = 0;
            total.Text = e_f0931.Sum(p => p.CDUPRC).ToString();
            total.Width = Unit.Parse("80px");
            totalrow.Cells.Add(total);

            table.Rows.Add(totalrow);
        }
    }
}