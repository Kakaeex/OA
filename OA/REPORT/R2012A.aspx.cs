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
using System.Text;

namespace OA.REPORT
{
    public partial class R2012A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Master.QueryString.ContainsKey("from")
                & Master.QueryString.ContainsKey("to")
                & Master.QueryString.ContainsKey("status")
                & Master.QueryString.ContainsKey("kcoo"))
            {
                bind(Master.QueryString["from"]
                    , Master.QueryString["to"]
                    , Master.QueryString["status"], Master.QueryString["kcoo"]);
            }
        }
        protected void bind(string date_from, string date_to, string status, string kcoo)
        {
            TableRow tblrowTitle = new TableRow();

            TableCell headercell = new TableCell();
            headercell.Text = "审批结果";
            tblrowTitle.Cells.Add(headercell);

            headercell = new TableCell();
            headercell.Text = "费用单号";
            tblrowTitle.Cells.Add(headercell);

            headercell = new TableCell();
            headercell.Text = "行";
            tblrowTitle.Cells.Add(headercell);

            headercell = new TableCell();
            headercell.Text = "行备注";
            tblrowTitle.Cells.Add(headercell);

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

            DateTime d_from = ValueConvert.toDate(date_from);
            DateTime d_to = ValueConvert.toDate(date_to);
            var e_f0931 = (
                           from d in Master._DBHelper.C_F0931
                           join h in Master._DBHelper.C_F0930
                           on d.CDDOCO equals h.CHDOCO
                           where d.CDDCTO == h.CHDCTO & h.CHADDJ >= d_from & h.CHADDJ <= d_to &
                           h.CHKCOO == kcoo & h.CHNXTR == status
                           select new
                           {
                               CHNXTR = h.CHNXTR,
                               CHDOCO = h.CHDOCO,
                               CDDLNID = d.CDDLNID,
                               CDDSC1 = d.CDDSC1,
                               CDFAID = d.CDFAID,
                               longss = d.CDFMCU + "." + d.CDFOBJ + "." + d.CDFSUB,
                               CDDEL2 = d.CDDEL2,
                               CDUPRC = d.CDUPRC
                           }
                            ).OrderBy(p => p.CHDOCO).ThenBy(p => p.CDDLNID).ToList();

            if (e_f0931.Count <= 0) return;

            int last_doco = -1;

            KCOO.Text = kcoo;
            from.Text = date_from;
            to.Text = date_to;

            for (int i = 0; i < e_f0931.Count; i++)
            {
                var obj = e_f0931[i];
                TableRow tblrow = new TableRow();

                #region 数据行
                //审批状态
                TableCell Cell = new TableCell();
                Cell.BorderWidth = 0;
                Cell.Text = obj.CHNXTR;
                Cell.Width = Unit.Parse("30px");
                tblrow.Cells.Add(Cell);
                //费用单号
                Cell = new TableCell();
                Cell.BorderWidth = 0;
                Cell.Text = obj.CHDOCO.ToString();
                Cell.Width = Unit.Parse("30px");
                tblrow.Cells.Add(Cell);
                //费用单行号
                Cell = new TableCell();
                Cell.BorderWidth = 0;
                Cell.Text = obj.CDDLNID.ToString();
                Cell.Width = Unit.Parse("30px");
                tblrow.Cells.Add(Cell);

                Cell = new TableCell();
                Cell.BorderWidth = 0;
                Cell.Text = obj.CDDSC1;
                Cell.Width = Unit.Parse("150px");
                tblrow.Cells.Add(Cell);

                Cell = new TableCell();
                Cell.BorderWidth = 0;
                Cell.Text = obj.CDFAID;
                Cell.Width = Unit.Parse("100px");
                tblrow.Cells.Add(Cell);

                Cell = new TableCell();
                Cell.BorderWidth = 0;
                Cell.Text = obj.longss;
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

                #endregion

                if (last_doco != -1 & last_doco != obj.CHDOCO)
                {
                    #region 合计行
                    TableRow totalrow = new TableRow();

                    //审批状态
                    Cell = new TableCell();
                    Cell.ColumnSpan = 6;
                    Cell.BorderWidth = 0;
                    Cell.Text = userCell(last_doco, status);
                    Cell.Width = Unit.Parse("100px");
                    totalrow.Cells.Add(Cell);

                    Cell = new TableCell();
                    Cell.BorderWidth = 0;
                    Cell.Text = "合计：";
                    Cell.Width = Unit.Parse("150px");
                    totalrow.Cells.Add(Cell);

                    Cell = new TableCell();
                    Cell.BorderWidth = 0;
                    Cell.Text = e_f0931.GroupBy(p => p.CHDOCO).Select
                        (g => (new { doco = g.Key, total = g.Sum(p => p.CDUPRC) })).
                        Where(p => p.doco == last_doco).FirstOrDefault().total.ToString();
                    Cell.Width = Unit.Parse("80px");
                    totalrow.Cells.Add(Cell);

                    table.Rows.Add(totalrow);
                    table.Rows.Add(blankRow());
                    #endregion
                }
                table.Rows.Add(tblrow);
                if (i == e_f0931.Count - 1)
                {
                    #region 最后行合计
                    TableRow totalrow = new TableRow();

                    Cell = new TableCell();

                    Cell.ColumnSpan = 6;
                    Cell.BorderWidth = 0;
                    Cell.Text = userCell(last_doco, status);
                    Cell.Width = Unit.Parse("100px");
                    totalrow.Cells.Add(Cell);

                    Cell = new TableCell();
                    Cell.BorderWidth = 0;
                    Cell.Text = "合计：";
                    Cell.Width = Unit.Parse("150px");
                    totalrow.Cells.Add(Cell);

                    Cell = new TableCell();
                    Cell.BorderWidth = 0;
                    Cell.Text = e_f0931.GroupBy(p => p.CHDOCO).Select
                        (g => (new { doco = g.Key, total = g.Sum(p => p.CDUPRC) })).
                        Where(p => p.doco == last_doco).FirstOrDefault().total.ToString();
                    Cell.Width = Unit.Parse("80px");
                    totalrow.Cells.Add(Cell);

                    table.Rows.Add(totalrow);
                    table.Rows.Add(blankRow());
                    #endregion
                }
                last_doco = obj.CHDOCO;
            }
        }

        TableRow blankRow()
        {
            TableRow tblrow = new TableRow();
            #region 数据行
            //审批状态
            TableCell Cell = new TableCell();
            Cell.ColumnSpan = 7;
            Cell.BorderWidth = 0;
            Cell.Text = "---------------------------------------------------------------------------------------------------------------------------------------------------------------";
            Cell.Width = Unit.Parse("30px");
            tblrow.Cells.Add(Cell);
            return tblrow;
            #endregion

        }

        string userCell(int doco,string nxtr)
        {
            var e_list = Master._DBHelper.FindAll<C_F2012, int>(p => p.WFDOCO == doco , p => p.WFLNID);
            StringBuilder user = new StringBuilder();
            user.Append("审批人：");
            foreach (var obj in e_list)
            {
                int an8=ValueConvert.toInt(obj.WFUSER);
                user.Append(Master._DBHelper.Find<C_F0101>(p => p.ABAN8 == an8).ABALPH);
                user.Append("-");
                user.Append(obj.WFDATE.ToString("yy-MM-dd"));
                user.Append(";");
            }
            return user.ToString();
        }
    }
}