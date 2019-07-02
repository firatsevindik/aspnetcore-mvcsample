using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SampleMVCProject.Models;

namespace SampleMVCProject.Controllers
{
	public class HomeController : BaseController
	{
		public AppSettings Settings { get; set; }
		public HomeController(IOptions<AppSettings> settings)
		{
			Settings = settings.Value;
		}

		public IActionResult Index()
		{
			var blogs = Blogs;
			ViewData["Categories"] = Categories;

			Response.Cookies.Append("SessionId", Guid.NewGuid().ToString(), new CookieOptions
			{
				Expires = DateTime.Now.AddYears(1)
			});

			var cookie = Request.Cookies["SessionId"];
			ViewData["SessionId"] = cookie;

			return View(blogs);
		}

		public IActionResult Detail(int id)
		{
			var blog = Blogs.FirstOrDefault(a => a.Id == id);

			if (blog == null)
			{
				return NotFound();
			}

			return View(blog);
		}
	}
}
