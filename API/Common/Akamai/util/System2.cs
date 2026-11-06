using System;
using System.Collections.Generic;
using System.Text;

namespace Akamai.util
{
    class System2
    {
        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public static long currentTimeMillis()
        {
            return AkamaiUser.isTest ? 1671194485028L : (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }
    }
}
