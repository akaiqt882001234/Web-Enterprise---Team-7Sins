using Microsoft.AspNetCore.Identity;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebEnterpriseProject.Enums;

namespace WebEnterpriseProject.Models;


	public class User : IdentityUser
		{
		    [Key]
    		public RoleStatus RoleId { get; set; } = RoleStatus.RoleId;
		    [Required]
		    [ForeignKey("Department")]
		    public int DepartmentId {get; set;}
    public Department Department { get; set; }
    public List<Post> Posts { get; set; }
    public string UserName { get; set; }
    public string UserEmail { get; set; }
    public string UserPassword { get; set; }
		}
