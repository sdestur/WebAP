using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAPI1.Ex1;
using WebAPI1.Models;

namespace WebAPI1.Controllers
{
    [Route("api/conroller")]
    public class UsersController:ControllerBase
    {
        private List<User> _users = Fake.GetUsers(200);

        [HttpGet]
        public List<User> GetAll()
        {
            return _users;
        }

        [HttpGet("{id}")]        
        public User Get(int id)
        {

            var user = _users.FirstOrDefault(x => x.Id == id);
                return user;
        }

        [HttpPost]
        public User Post([FromBody] User user)
        {
            _users.Add(user);
            return user;
        }

        [HttpPut]
        public User Put([FromBody] User user)
        {
            var editUser= _users.FirstOrDefault(x => x.Id == user.Id);
            editUser.FirstName = user.FirstName;
            editUser.LastName = user.LastName;
            editUser.Adress = user.Adress;
            _users.Add(user);
            return user;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var deleteUser = _users.FirstOrDefault(x => x.Id == id);
            _users.Remove(deleteUser);
        }
    }
}
