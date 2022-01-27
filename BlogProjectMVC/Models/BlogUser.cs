using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BlogProjectMVC.Models
{
	public class BlogUser : IdentityUser
	{
		[Required]
		[Display(Name = "First Name")]
		[StringLength(50, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
		public string FirstName { get; set; }
		[Required]
		[Display(Name = "Last Name")]
		[StringLength(50, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
		public string LastName { get; set; }

		public byte[] ImageData { get; set; }
		public string ImageType { get; set; }

		[StringLength(200, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
		public string FacebookUrl { get; set; }
		[StringLength(200, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
		public string TwitterUrl { get; set; }

		[NotMapped]
		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}

		public virtual ICollection<Blog> Blogs { get; set; } = new HashSet<Blog>();
		public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();
	}
}
