using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserAPI.Models
{
	public class User
	{
		[Required]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string Address { get; set; }

		public string Phone { get; set; }
	}
}
