using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Domain.Identity
{
    public class ApplicationUser:IdentityUser
    {
        [Display(Name = "Full name")]
        public string FullName { get; set; }
    }
}
