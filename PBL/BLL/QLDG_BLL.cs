using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL
{
    internal class QLDG_BLL
    {
        private static QLDG_BLL _Instance;

        public static QLDG_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLDG_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        private QLDG_BLL()
        {
        }
    }
}