using System;
using System.Collections.Generic;
using System.Text;

namespace Akamai.key
{
    class KeyEvent
    {
        public String key = "2"; // always "2"
        public long delay;
        public int id;

        public KeyEvent(long delay, int id)
        {
            this.delay = delay;
            this.id = id;
        }
    }
}
