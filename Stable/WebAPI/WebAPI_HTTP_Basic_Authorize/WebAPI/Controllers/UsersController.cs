using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using WebAPI.UserCenter;

namespace WebAPI.Controllers
{
    [HTTPBasicAuthorize]
    public class UsersController : ApiController
    {
        /// <summary>
        /// User Data List
        /// </summary>
        private readonly List<Users> _userList = new List<Users>
        {
            new Users {UserID = 1, UserName = "Superman", UserEmail = "Superman@cnblogs.com"},
            new Users {UserID = 2, UserName = "Spiderman", UserEmail = "Spiderman@cnblogs.com"},
            new Users {UserID = 3, UserName = "Batman", UserEmail = "Batman@cnblogs.com"}
        };

        // GET api/Users
        public IEnumerable<Users> Get()
        {
            return _userList;
        }

        // GET api/Users/5
        public Users GetUserByID(int id)
        {
            var user = _userList.FirstOrDefault(users => users.UserID == id);
            if (user == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return user;
        }

        //GET api/Users/?username=xx
        public IEnumerable<Users> GetUserByName(string userName)
        {
            return _userList.Where(p => string.Equals(p.UserName, userName, StringComparison.OrdinalIgnoreCase));
        }

        //POST api/Users/Users Entity Json
        public Users Add([FromBody]Users users)
        {
            if (users == null)
            {
                throw new HttpRequestException();
            }
            _userList.Add(users);
            return users;
        }
    }
}