using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZohoDeskDemo.Models
{
    public class FormDetails
    {
        public string subject { get; set; }
        public string email { get; set; }

        public FormDetails(string sausage1, string sausage2)
        {
            subject = sausage1;
            email = sausage2;
        }
    }
}