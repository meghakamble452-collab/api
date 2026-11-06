using Akamai.intern.hook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Akamai.key
{
    class KeysUtils
    {
        public static String fullEditTextsLogin = "510;508;509;513;503;511;516;504;";
        private static int[] loginEditTextIds = { 509, 510, 508, 509 };

        public static String fullEditTextsAvl = "514;509;506;"; //"514;";
        private static int[] avlEditTextIds = { 509, 506, 514 };


        public static List<KeyEvent> generateRandomKeyEvent(HookEvent hookEvent)
        {
            List<KeyEvent> keys = new List<KeyEvent>();

            switch (hookEvent)
            {
                case HookEvent.Webmtoken:
                case HookEvent.ValidateUser:
                    keys.Add(new KeyEvent(util.Random.nextInt(40, 80), loginEditTextIds[0]));

                    keys.Add(new KeyEvent(util.Random.nextInt(7000, 15000), loginEditTextIds[1]));
                    for (int i = 0; i < util.Random.nextInt(5, 10); i++)
                    {
                        keys.Add(new KeyEvent(util.Random.nextInt(400, 2000), loginEditTextIds[1]));
                    }

                    keys.Add(new KeyEvent(util.Random.nextInt(7000, 15000), loginEditTextIds[2]));
                    for (int i = 0; i < util.Random.nextInt(5, 10); i++)
                    {
                        keys.Add(new KeyEvent(util.Random.nextInt(400, 2000), loginEditTextIds[2]));
                    }

                    keys.Add(new KeyEvent(util.Random.nextInt(7000, 15000), loginEditTextIds[3]));
                    for (int i = 0; i < util.Random.nextInt(5, 8); i++)
                    {
                        keys.Add(new KeyEvent(util.Random.nextInt(400, 2000), loginEditTextIds[3]));
                    }
                    break;

                case HookEvent.AvlFarenquiry:

                    keys.Add(new KeyEvent(util.Random.nextInt(15000, 30000), avlEditTextIds[0]));
                    for (int i = 0; i < util.Random.nextInt(4, 6); i++)
                    {
                        keys.Add(new KeyEvent(util.Random.nextInt(300, 2000), avlEditTextIds[0]));
                    }

                    keys.Add(new KeyEvent(util.Random.nextInt(1000, 5000), avlEditTextIds[1]));
                    for (int i = 0; i < util.Random.nextInt(4, 6); i++)
                    {
                        keys.Add(new KeyEvent(util.Random.nextInt(200, 1000), avlEditTextIds[1]));
                    }

                    keys.Add(new KeyEvent(util.Random.nextInt(10000, 20000), avlEditTextIds[2]));
                    for (int i = 0; i < util.Random.nextInt(7, 10); i++)
                    {
                        keys.Add(new KeyEvent(util.Random.nextInt(400, 2000), avlEditTextIds[2]));
                    }
                    break;
            }


            return keys;
        }


        public static Tuple<Tuple<String, long>, long> getRandomKeyData(HookEvent hookEvent)
        {
            if (hookEvent == HookEvent.Universal) return new Tuple<Tuple<String, long>, long>(new Tuple<String, long>("", 0L), 0L);
            List<KeyEvent> keyEvents = generateRandomKeyEvent(hookEvent);
            StringBuilder b = new StringBuilder();
            long timeSum = 0L;
            foreach (KeyEvent event_ in keyEvents)

            {
                String str = event_.key + "," + event_.delay + "," + event_.id + ";";
                b.Append(str);
                timeSum = event_.delay + long.Parse(event_.key) + event_.id + timeSum;
            }

            return new Tuple<Tuple<String, long>, long>(new Tuple<String, long>(b.ToString(), timeSum), (long)keyEvents.Count);
        }


        public static String getEditTextsList(HookEvent hookEvent)
        {
            String result = null;
            switch (hookEvent)
            {
                case HookEvent.Webmtoken:
                case HookEvent.ValidateUser:    
                    result = fullEditTextsLogin;
                    break;
                case HookEvent.AvlFarenquiry:
                    result = fullEditTextsAvl;
                    break;
                case HookEvent.Universal:
                    result = "";
                    break;
            }


            return result;
        }

    }
}
