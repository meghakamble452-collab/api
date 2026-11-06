using System;
using System.Collections.Generic;
using System.Text;

namespace Akamai.util
{
    class Random
    {
        public static System.Random RandomSystem = new System.Random();

        public static int nextInt(int min, int max)
        {
            return AkamaiUser.isTest ? min : RandomSystem.Next(min, max);
        }

        public static int nextInt(int max)
        {
            return AkamaiUser.isTest ? max / 2 : RandomSystem.Next( max);
        }

        public static double nextDouble()
        {
            return AkamaiUser.isTest ? 0.5 : RandomSystem.NextDouble();
        }

        public static  ulong nextUnLong()
        {
            byte[] buf = new byte[8];
            RandomSystem.NextBytes(buf);
            return AkamaiUser.isTest ? 0x7fffffff : BitConverter.ToUInt64(buf, 0);
        }


        public static void nextBytes(byte[] bytes)
        {
            if (AkamaiUser.isTest)
            {
                //Array.Fill(bytes, (byte)0x55);
            }
            else
                RandomSystem.NextBytes(bytes);
        }

    }
}
