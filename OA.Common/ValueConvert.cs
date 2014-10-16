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
                string xxx = obj.GetType().FullName;
                switch (obj.GetType().FullName)
                {
                    case "FineUI.TriggerBox": return Convert.ToInt32((obj as FineUI.TriggerBox).Text);
                    case "FineUI.TextBox": return Convert.ToInt32((obj as FineUI.TextBox).Text);
                    case "System.String": return Convert.ToInt32((obj as System.String));
                    case "FineUI.DatePicker": return Convert.ToInt32((obj as FineUI.DatePicker).Text);
                    case "FineUI.HiddenField": return Convert.ToInt32((obj as FineUI.HiddenField).Text);
                    default: return Convert.ToInt32(obj);
                }
            }
            catch
            {
                return 0;
            }
        }

        public static Decimal toDecimal(object obj)
        {
            try
            {
                string xxx = obj.GetType().FullName;
                switch (obj.GetType().FullName)
                {
                    case "FineUI.TriggerBox": return Convert.ToDecimal((obj as FineUI.TriggerBox).Text);
                    case "FineUI.TextBox": return Convert.ToDecimal((obj as FineUI.TextBox).Text);
                    case "System.String": return Convert.ToDecimal((obj as System.String));
                    default: return Convert.ToDecimal(obj);
                }
            }
            catch
            {
                return 0;
            }
        }

        public static DateTime toDate(object obj)
        {
            try
            {
                string xxx = obj.GetType().FullName;
                switch (obj.GetType().FullName)
                {
                    case "FineUI.TriggerBox": return Convert.ToDateTime((obj as FineUI.TriggerBox).Text);
                    case "FineUI.TextBox": return Convert.ToDateTime((obj as FineUI.TextBox).Text);
                    case "System.String": return Convert.ToDateTime((obj as System.String));
                    case "FineUI.DatePicker": return Convert.ToDateTime((obj as FineUI.DatePicker).Text);
                    default: return Convert.ToDateTime(obj);
                }
            }
            catch
            {
                return Convert.ToDateTime("1900-01-01");
            }
        }
    }
}
