using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofacWebMvcFive.Utilities
{
    public interface IUserProvider
    {
        string UserName { get; }
    }

    public class UserProvider : IUserProvider
    {
        public string UserName => string.IsNullOrEmpty(HttpContext.Current?.User?.Identity?.Name) ? "Ibraheem" : HttpContext.Current?.User?.Identity?.Name;
    }
}