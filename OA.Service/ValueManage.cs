using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OA.Interface;
using FineUI;

namespace OA.Service
{
    public class ValueManage : IValueManage
    {
        public int toInt(object obj)
        {
            switch (obj.GetType().ToString())
            {
                case "TriggerBox": return Convert.ToInt32((obj as FineUI.TriggerBox).Text);
                case "TextBox": return Convert.ToInt32((obj as FineUI.TextBox).Text);
                default: return Convert.ToInt32(obj);
            }

        }
    }
}
