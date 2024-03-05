using DakaBlog.Mvc.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.ViewComponents.Writers
{
    public class WriterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
