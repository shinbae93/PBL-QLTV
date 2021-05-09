using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL
{
    internal class QLPM_BLL
    {
        private static QLPM_BLL _Instance;

        public static QLPM_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLPM_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        private QLPM_BLL()
        {
        }
    }
}