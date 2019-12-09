using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_03_3248_0250
{
    public class Host
    {
        private string _HostName;
        public string HostName
        {
            get { return _HostName; }
            private set { _HostName = value; }
        }

        private List<HostingUnit> _Units;
        public List<HostingUnit> Units
        {
            get { return _Units; }
            private set { _Units = value; }
        }
    }
}
