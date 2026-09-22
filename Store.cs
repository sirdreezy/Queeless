using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queeless
{
    internal class Store
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        private string campusName;

        public string CampusName
        {
            get { return campusName; }
            set { campusName = value; }
        }

        public Store(string campusName, string name)
        {
            this.name = name;
            this.campusName = campusName;
        }
    }
}
