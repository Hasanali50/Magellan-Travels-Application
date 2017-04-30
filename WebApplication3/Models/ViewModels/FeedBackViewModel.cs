using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.ViewModels
{
    public class FeedBackViewModel
    {
        public string FeedBackName { get; set; }
        [EmailAddress]
        public string FeedBackEmail { get; set; }
        public string FeedBackDesc { get; set; }
    }
}
