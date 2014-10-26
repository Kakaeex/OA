using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FineUI;
using DBContextHelper;


namespace OA.Interface
{
    public interface IWindowsEditPage
    {
        /// <summary>
        /// 主工具栏
        /// </summary>
        Toolbar Toolbar { get; }

        /// <summary>
        /// 主信息栏
        /// </summary>
        Label Label { get; }

        /// <summary>
        /// 输入面板
        /// </summary>
        Form Forms { get; }

        /// <summary>
        /// 重新绑定其它数据
        /// </summary>
        void Bind();

        /// <summary>
        /// 删除选中的行
        /// </summary>
        void DeleteRow();

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        void Save();

        /// <summary>
        /// 打印页面
        /// </summary>
        /// <returns></returns>
        void Print();

        /// <summary>
        /// 获取刷新地址
        /// </summary>
        /// <returns></returns>
        string GetFromMode();

        dynamic OnValidate<T>(string type, T obj) where T : ModelBase;
    }
}
