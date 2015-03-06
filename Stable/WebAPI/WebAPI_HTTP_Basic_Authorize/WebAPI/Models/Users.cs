using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace WebAPI.Models
{
    public class Users
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }
    }
}
