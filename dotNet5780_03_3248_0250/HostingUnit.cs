using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_03_3248_0250
{
    public class HostingUnit
    {
        // Propeties
        private string _UnitName;
        public string UnitName
        {
            get { return _UnitName; }
            private set { _UnitName = value; }
        }

        private int _Rooms;
        public int Rooms
        {
            get { return _Rooms; }
            private set { _Rooms = value; }
        }

        private bool _IsSwimmimgPool;
        public bool IsSwimmimgPool
        {
            get { return _IsSwimmimgPool; }
            private set { _IsSwimmimgPool = value; }
        }

        private List<DateTime> _AllOrders;
        public List<DateTime> AllOrders
        {
            get { return _AllOrders; }
            private set { _AllOrders = value; }
        }

        private List<string> _Uris;
        public List<string> Uris
        {
            get { return _Uris; }
            private set { _Uris = value; }
        }
    }
}
