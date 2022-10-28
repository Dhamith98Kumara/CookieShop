using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieShop.Models
{
    public class CookieViewModel
    {
        public string Username { get; set; }
        public int CookieCount { get; set; }
        public string Place { get; set; }
        public string Flavour { get; set; }
        public string RedeemCode { get; set; }
    }
}
