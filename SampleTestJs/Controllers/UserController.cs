using Microsoft.AspNetCore.Mvc;
using SampleTestJs.Repository;
using System.Collections.Generic;
using System.Linq;

namespace SampleTestJs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IEnumerable<UserModel> GetAll()
        {
            return _userRepository.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<UserModel> GetById(int id)
        {
            var user = _userRepository.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpPost]
        public ActionResult<UserModel> Add(UserModel user)
        {
            _userRepository.Add(user);
            return CreatedAtAction(nameof(GetById), new { id = _userRepository.GetAll().Count() - 1 }, user);
        }

        [HttpPut("{id}")]
        public ActionResult<UserModel> Update(int id, UserModel user)
        {
            if (id >= _userRepository.GetAll().Count())
            {
                return NotFound();
            }
            _userRepository.Update(id, user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<UserModel> Delete(int id)
        {
            if (id >= _userRepository.GetAll().Count())
            {
                return NotFound();
            }
            _userRepository.Delete(id);
            return NoContent();
        }
    }
}
