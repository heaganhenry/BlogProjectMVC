using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BlogProjectMVC.Enums;
using Microsoft.AspNetCore.Identity;

namespace BlogProjectMVC.Models
{
	public class Comment
	{
		public int Id { get; set; }
		public int PostId { get; set; }
		public string AuthorId { get; set; }
		public string ModeratorId { get; set; }

		[Required]
		[Display(Name = "Comment")]
		[StringLength(500, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
		public string Body { get; set; }

		public DateTime Created { get; set; }
		public DateTime? Updated { get; set; }
		public DateTime? Moderated { get; set; }
		public DateTime? Deleted { get; set; }

		[Display(Name = "Moderated Comment")]
		[StringLength(500, ErrorMessage = "The {0} must be at least {2} and no more than {1} characters long.", MinimumLength = 2)]
		public string ModeratedBody { get; set; }
		public ModerationType ModerationType { get; set; }

		// Navigation properties
		public virtual Post Post { get; set; }
		public virtual IdentityUser Author { get; set; }
		public virtual IdentityUser Moderator { get; set; }
	}
}
