using asp_net_core_proje_kampi.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core_proje_kampi.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
				new UserComment
				{
					ID=1,
					UserName="semih"
				},
				new UserComment {
					ID=2,
					UserName="lokman"
				},
				new UserComment
				{
					ID=3,
					UserName="orhan"
				}
			};
			return View(commentvalues);
		}
	}
}
