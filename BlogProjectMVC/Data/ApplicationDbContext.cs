using System;
using System.Collections.Generic;
using System.Text;
using BlogProjectMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlogProjectMVC.Data
{
	public class ApplicationDbContext : IdentityDbContext<BlogUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	}
}
