using System;
using System.Collections.Generic;
using System.Text;

namespace Akamai.util
{
    class SystemClock
    {
        private long startMachine = System2.currentTimeMillis() - util.Random.nextInt(1000 * 60 * 5, 1000 * 60 * 3000);
        public long uptimeMillis()
        {
            return System2.currentTimeMillis() - startMachine;
        }
    }
}
