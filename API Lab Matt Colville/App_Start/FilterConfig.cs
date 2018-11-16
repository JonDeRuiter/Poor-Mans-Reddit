using System.Web;
using System.Web.Mvc;

namespace API_Lab_Matt_Colville
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
