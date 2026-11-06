using Akamai.intern;
using Akamai.intern.hook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akamai.life
{
    class ActivityUtils
    {
        private static String LOGIN_ACTIVITY_SEQUENCES = "3,{0};2,{1};3,{2};";   //"3,%s;2,%s;3,%s;2,%s;3,%s;2,%s;3,%s;";

        private static String AVL_ACTIVITY_SEQUENCES = "2,{0};3,{1};2,{2};3,{3};2,{4};3,{5};2,{6};3,{7};2,{8};3,{9};";

        public static String getRandomActivityData(HookEvent hookEvent, AkamaiUser akamaiUser)
        {
            String result = null;
            switch (hookEvent)
            {
                case HookEvent.Webmtoken:
                case HookEvent.ValidateUser:
                    {
                        long timePeriodFull = util.System2.currentTimeMillis() - akamaiUser.getTimeBeginSession();
                        result = String.Format(LOGIN_ACTIVITY_SEQUENCES,
                                akamaiUser.getTimeBeginSession() + util.Random.nextInt(100, 400),
                                akamaiUser.getTimeBeginSession() + 4 * timePeriodFull / 6,
                                akamaiUser.getTimeBeginSession() + 5 * timePeriodFull / 6


                        );
                    }
                    break;
                case HookEvent.AvlFarenquiry:
                    {
                        long timePeriodFull = util.System2.currentTimeMillis() - akamaiUser.getTimeBeginSession();
                        long time1 = akamaiUser.getTimeBeginSession() + 5 * timePeriodFull / 20;
                        result = String.Format(AVL_ACTIVITY_SEQUENCES,
                                akamaiUser.getTimeBeginSession() + 5 * timePeriodFull / 20,
                                akamaiUser.getTimeBeginSession() + 6 * timePeriodFull / 20,
                                akamaiUser.getTimeBeginSession() + 8 * timePeriodFull / 20,
                                akamaiUser.getTimeBeginSession() + 9 * timePeriodFull / 20,
                                akamaiUser.getTimeBeginSession() + 10 * timePeriodFull / 20,
                                akamaiUser.getTimeBeginSession() + 11 * timePeriodFull / 20,
                                akamaiUser.getTimeBeginSession() + 14 * timePeriodFull / 20,
                                akamaiUser.getTimeBeginSession() + 17 * timePeriodFull / 20,
                                akamaiUser.getTimeBeginSession() + 18 * timePeriodFull / 20,
                                akamaiUser.getTimeBeginSession() + 19 * timePeriodFull / 20
                        );
                    }
                    break;
                case HookEvent.Universal:
                    result = "";
                    break;
            }

            return result;
        }
    }
}
