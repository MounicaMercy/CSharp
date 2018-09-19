using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12092018.CustomException
{
    public class CustomExceptions:Exception
    {
        public override string Message => base.Message;
        public CustomExceptions(string m) : base(m)
        {
        }
    }
}
