using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public class Register
    {
        private int registerId { get; set; }
        private SalesLineItem sale { set; get; }
        private int storeId { set; get; }

        public Register(int registerId)
        {
            this.registerId = registerId;
        }

        public int getRegisterId()
        {
            return registerId;
        }
    }
}
