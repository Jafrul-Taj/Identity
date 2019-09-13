using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }

        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [Required]
        public string City { get; set; }

        public List<string> Claims { get; set; }

        public List<string> Roles { get; set; }
    }
}
