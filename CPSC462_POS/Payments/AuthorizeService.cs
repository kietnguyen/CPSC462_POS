using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class AuthorizeService
    {
        private string name;

        public AuthorizeService(string name)
        {
            this.name = name;
        }

        public bool authorize()
        {
            return true;
        }
    }
}
