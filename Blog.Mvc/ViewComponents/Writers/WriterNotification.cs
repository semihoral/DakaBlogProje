using Microsoft.AspNetCore.Mvc;

namespace DakaBlog.Mvc.ViewComponents.Writers
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
