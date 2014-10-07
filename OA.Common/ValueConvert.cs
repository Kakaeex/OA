using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FineUI;

namespace OA.Common
{
    public class ValueConvert
    {
        public static int toInt(object obj)
        {
            try
            {

                switch (obj.GetType().ToString())
                {
                    case "TriggerBox": return Convert.ToInt32((obj as FineUI.TriggerBox).Text);
                    case "TextBox": return Convert.ToInt32((obj as FineUI.TextBox).Text);
                    default: return Convert.ToInt32(obj);
                }
            }
            catch
            {
                return 0;
            }
        }
    }
}
