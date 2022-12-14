using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasTCC.FrameworkDAO.Attributes
{
    public class TableNameAttribute : Attribute
    {
        public string Name { get; set; }

        public TableNameAttribute(string name)
        {
            Name = name;
        }
    }
}
