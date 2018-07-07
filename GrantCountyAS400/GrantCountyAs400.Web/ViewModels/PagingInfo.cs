using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantCountyAs400.Web.ViewModels
{
    public class PagingInfo
    {
        public int PageIndex { get { return PageNumber - 1; } }

        public int PageNumber { get; set; }

        public int Total { get; set; }
    }
}
