using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SampleMVCProject.Models;

namespace SampleMVCProject.Controllers
{
	public class BaseController : Controller
	{
		public List<BlogModel> Blogs { get; set; }
		public List<CategoryModel> Categories { get; set; }

		public BaseController()
		{
			Blogs = new List<BlogModel>();
			Categories = new List<CategoryModel>();

			Blogs.Add(new BlogModel
			{
				Id = 1,
				Title = "Test",
				Abstract = "Test Abstract",
				CreatedDate = new System.DateTime(2019, 05, 01),
				Content = "Test Content",
				CategoryId = 1
			});

			Blogs.Add(new BlogModel
			{
				Id = 2,
				Title = "Test 2",
				Abstract = "Test 2 Abstract",
				CreatedDate = new System.DateTime(2019, 05, 03),
				Content = "Test 2 Content",
				CategoryId = 2
			});

			Categories.Add(new CategoryModel
			{
				Id = 1,
				Name = "C#"
			});

			Categories.Add(new CategoryModel
			{
				Id = 2,
				Name = "Java"
			});
		}
	}
}