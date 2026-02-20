using Microsoft.AspNetCore.Mvc;
using UserDirectory.Api.Models;
using UserDirectory.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace UserDirectory.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{

    private readonly UserDirectoryContext _context;

     public UsersController(UserDirectoryContext context)
        {
            _context = context;
        }
        


    // GET: api/users
    [HttpGet]
    
     public  ActionResult GetAll()
    {
        if (_context.Users == null)
          {
              return NotFound();
          }
        return Ok(_context.Users.ToList());
    }

    // GET: api/users/1
    [HttpGet("{id}")]
    
        public async Task<ActionResult<User>> GetById(int id)
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }
        

    // POST: api/users
    [HttpPost]
  
    public IActionResult CreateUser([FromBody] User user)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        user.Id = _context.Users.Any() ? _context.Users.Max(u => u.Id) + 1 : 1;
       _context.Users.Add(user);
        _context.SaveChanges();



        return Ok(new { message = "Successfully Created" });
    }



    // PUT: api/users/1
    [HttpPut("{id}")]
    public IActionResult Update(int id, User updatedUser)
    {
        var existing = UserStore.Users.FirstOrDefault(u => u.Id == id);

        if (existing == null)
            return NotFound();

        _context.Entry(existing).CurrentValues.SetValues(updatedUser);
        _context.SaveChanges();
        return Ok("Successfully updated");
    }

    // DELETE: api/users/1
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var user = _context.Users.Find(id);

        if (user == null)
            return NotFound();

        _context.Users.Remove(user);
        _context.SaveChanges();

        return Ok();
    }
}