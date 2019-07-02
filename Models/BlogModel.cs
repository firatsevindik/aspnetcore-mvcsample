using System;

namespace SampleMVCProject.Models
{
	public class BlogModel
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime CreatedDate { get; set; }
		public string Abstract { get; set; }
		public string Content { get; set; }
		public int CategoryId { get; set; }
	}
}