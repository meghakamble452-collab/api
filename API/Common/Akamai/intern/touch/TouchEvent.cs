using System;
using System.Collections.Generic;
using System.Text;

namespace Akamai.intern.touch
{
    class TouchEvent
    {

        public int type;
        public int delay;
        public int pointerCount = 1; //always only one finger(pointer) has been used
        public int touchType = 1; //always  TOOL_TYPE_FINGER

        public TouchEvent(int type, int delay)
        {
            this.type = type;
            this.delay = delay;
        }

     
        public String toString()
        {
            return "TouchEvent{" +
                   "type=" + type +
                   ", delay=" + delay +
                   ", pointerCount=" + pointerCount +
                   ", touchType=" + touchType +
                   '}';
        }
    }
}
