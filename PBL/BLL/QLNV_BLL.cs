using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL.BLL
{
    internal class QLNV_BLL
    {
        private static QLNV_BLL _Instance;

        public static QLNV_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new QLNV_BLL();
                }
                return _Instance;
            }
            private set { }
        }

        private QLNV_BLL()
        {
        }
    }
}