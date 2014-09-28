using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBContextHelper
{
    public interface IPagedList
    {
        int CurrentPageIndex { get; set; }
        int PageSize { get; set; }
        int TotalItemCount { get; set; }
    }
}
