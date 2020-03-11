using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MessageException
    {
        static string _message = "";
        public static string message { set => _message = value; get => _message; }
    }
}
