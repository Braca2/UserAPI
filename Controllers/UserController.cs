using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Models;
using UserAPI.Interfaces;
using UserAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class UserController : ControllerBase
	{
		private readonly IUserService userService;

		public UserController(IUserService userService)
		{
			this.userService = userService;
		}

		// GET: api/user
		[HttpGet]
		public async Task<IEnumerable<User>> Get()
		{
			return await userService.Get();
		}

		// GET api/user/5
		[HttpGet("{id}")]
		public async Task<ActionResult<User>> Get(int id)
		{
			return await userService.Get(id);
		}

		// POST api/user
		[HttpPost]
		public async Task<ActionResult<User>> Insert([FromBody] User user)
		{
			if (ModelState.IsValid)
			{
				await userService.Insert(user);
				return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
			}

			return BadRequest(ModelState);
		}

		// PUT api/user/5
		[HttpPut("{id}")]
		public async Task<ActionResult<User>> Update(int id, [FromBody] User user)
		{
			if (user.Id != id)
				return BadRequest();

			await userService.Update(user);
			return NoContent();
		}

		// DELETE api/user/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			var user = userService.Get(id).Result;

			if (user == null)
			{
				return NotFound();
			}

			await userService.Delete(user);
			return NoContent();
		}
	}
}
