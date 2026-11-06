using System;
using System.Collections.Generic;
using System.Text;

namespace Akamai.intern.touch
{
    class TouchUtils
    {
        private static int COUNT_TOUCH_EVENTS = 50;

        public static List<TouchEvent> generateRandomTouchEvents()
        {
            int size = util.Random.nextInt(35, 100);
            COUNT_TOUCH_EVENTS = size;
            List<TouchEvent> list = new List<TouchEvent>(size);
            //new ArrayList<>(50);
            bool isLastClick = false;
            //while (list.size() != 50)
            while (list.Count != size)
            {

                int events_in_next_downUp = isLastClick ? COUNT_TOUCH_EVENTS - list.Count : util.Random.nextInt(4, 7);
                events_in_next_downUp = list.Count + events_in_next_downUp <= (COUNT_TOUCH_EVENTS - 4) ? events_in_next_downUp : COUNT_TOUCH_EVENTS - list.Count;

                for (int j = 0; j < events_in_next_downUp; j++)
                {
                    if (j == 0)
                    {
                        list.Add(new TouchEvent(2, util.Random.nextInt(3000, 20000)));
                    }
                    else if (j == events_in_next_downUp - 1)
                    {
                        list.Add(new TouchEvent(3, util.Random.nextInt(10, 50)));
                    }
                    else list.Add(new TouchEvent(1, util.Random.nextInt(10, 30)));
                }

                //if (list.size() > 43)
                if (list.Count > size - 7)
                {
                    isLastClick = true;
                }
            }

            return list;
        }

        public static Tuple<Tuple<String, long>, long> getRandomTouchData()
        {
            List<TouchEvent> list = generateRandomTouchEvents();
            StringBuilder b = new StringBuilder();
            long timeSum = 0L;
            foreach (TouchEvent event_ in list)
            {
                String str = event_.type + "," + event_.delay + ",0,0," + event_.pointerCount + ",1," + event_.touchType + ",-1;";
                b.Append(str);
                timeSum = event_.delay + event_.type + timeSum;
            }

            return new Tuple<Tuple<String, long>, long>( new Tuple<String, long>(b.ToString(), timeSum), (long) list.Count);
        }

}
}
