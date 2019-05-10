using AutoMapper;
using MinhHieuShop.Model.Models;
using MinhHieuShop.Service;
using MinhHieuShop.Web.Models;
using System.Web.Mvc;

namespace MinhHieuShop.Web.Controllers
{
    public class PageController : Controller
    {
        IPageService _pageService;
        public PageController(IPageService pageService)
        {
            this._pageService = pageService;
        }
        // GET: Page
        public ActionResult Index(string alias)
        {
            var page = _pageService.GetByAlias(alias);
            var model = Mapper.Map<Page,PageViewModel>(page);
            return View(model);
        }
    }
}