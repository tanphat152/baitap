using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_template.common
{
    [Serializable]
    public class AccountLogin
    {
        public int AccountId { set; get; }
        public string AccountName { set; get; }
    }
}