using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3
{
    public static class Globals
    {
        public static ApplicationDbContext GetDatabase()
        {
            return HttpContext.Current.GetOwinContext().Get<ApplicationDbContext>();
        }
        public static String ToCamelCase(string input)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }
    }
}