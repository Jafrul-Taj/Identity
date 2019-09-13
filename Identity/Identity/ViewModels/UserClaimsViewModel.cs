using Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Identity.ViewModels
{
    public class UserClaimsViewModel
    {
        public UserClaimsViewModel()
        {
            claim = new List<UserClaim>();
        }
        public string UserId { get; set; }
        public List<UserClaim> claim { get; set; }

    }
}
