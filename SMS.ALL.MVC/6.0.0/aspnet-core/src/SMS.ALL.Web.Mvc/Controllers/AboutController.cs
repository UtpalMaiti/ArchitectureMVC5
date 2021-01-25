using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SMS.ALL.Controllers;

namespace SMS.ALL.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ALLControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
