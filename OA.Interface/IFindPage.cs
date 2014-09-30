using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FineUI;

namespace OA.Interface
{
    public interface IFindPage
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
        /// 删除选中的行数据
        /// </summary>
        void DeleteSelectedRows();

        /// <summary>
        /// 获取新增地址
        /// </summary>
        /// <returns></returns>
        string GetNewUrl();

        /// <summary>
        /// 获取编辑地址
        /// </summary>
        /// <returns></returns>
        string GetEditUrl();
    }
}
