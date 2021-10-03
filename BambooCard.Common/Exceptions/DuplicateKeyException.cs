using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BambooCard.Common.Exceptions
{
    public class DuplicateKeyException:Exception
    {
        public DuplicateKeyException() : base() { }

        public DuplicateKeyException(string message) : base(message) { }

        public DuplicateKeyException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }
    }
}
