using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FineUI;
using DBContextHelper;

namespace OA.Interface
{
    public interface IEditPage
    {
        /// <summary>
        /// 主工具栏
        /// </summary>
        Toolbar Toolbar { get; }

        /// <summary>
        /// 主表格实例
        /// </summary>
        Grid Grid { get; }

        /// <summary>
        /// 主信息栏
        /// </summary>
        Label Label { get; }

        /// <summary>
        /// 重新绑定表格
        /// </summary>
        void BindGrid();

        /// <summary>
        /// 重新绑定其它数据
        /// </summary>
        void Bind();

        /// <summary>
        /// 删除选中的行
        /// </summary>
        void DeleteRow();

        dynamic GetGridRowData(Dictionary<string, object> rowDict = null, object[] values = null, int deletedRows = 0);

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        void Save();


        /// <summary>
        /// 获取编辑地址
        /// </summary>
        /// <returns></returns>
        string GetFromMode();
    }
}
