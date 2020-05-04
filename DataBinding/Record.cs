using System;
using System.Collections.Generic;
using System.Text;

namespace DataBinding
{
    public class Record
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Uri WebSite { get; set; }
        public bool IsBillionaire { get; set; }
        public Gender Gender { get; set; }
    }
    
}
