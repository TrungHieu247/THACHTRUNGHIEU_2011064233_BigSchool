using System.Web;
using System.Web.Mvc;

namespace ThachTrungHieu_2011064233
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
