using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Order
{
    internal class Fighter_Exception : ArgumentOutOfRangeException
    {
        public Fighter_Exception(string message)
        {
            _message = message;
        }
        private readonly string _message;
        public override string Message => _message;
    }
}
