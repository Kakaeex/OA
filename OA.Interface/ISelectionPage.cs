using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FineUI;

namespace OA.Interface
{
    public interface ISelectionPage
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

        string[] GetValues();
    }
}
