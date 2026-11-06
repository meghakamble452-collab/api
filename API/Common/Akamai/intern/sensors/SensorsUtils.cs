using System;
using System.Collections.Generic;
using System.Text;

namespace Akamai.intern.sensors
{
    class SensorsUtils
    {


        public static Tuple<String, long> o(float[] fArr, float f2)
        {
            int length = fArr.Length;
            float[] fArr3 = new float[length];
            Array.Copy(fArr, 0, fArr3, 0, fArr.Length);
            //Log.info("Input for Simple Quantization encoding: " + K(fArr));
            Tuple<float, float> n_ = n(fArr);
            float floatValue = n_.Item1;
            float floatValue2 = n_.Item2;
            //String sb = "min and max of SimpQuant data: min(" + floatValue + "), max(" + floatValue2 + ")";
            //Log.info(sb);
            String G_ = G(L(fArr, floatValue, floatValue2));
            long a2 = a(G_);
            float b2 = b(floatValue);
            float b3 = b(floatValue2);

            Object[] objArr = new Object[4];
            objArr[0] = b2;
            String str3 = "Incorrect sensor data";

            objArr[1] = b3;
            objArr[2] = a2;
            objArr[3] = G_;
            //Locale locale = Locale.US;
            String str2 = String.Format("2;{0:0.00};{1:0.00};{2};{3}", objArr);
            long valueOf2 = ((long)Math.Round((b3 * 100.0f) + (b2 * 100.0f))) + a2;
            //Log.info("Input for DCT encoding: " + K(fArr3));
            if (BitCount(length) == 1)
            {
                a0(fArr3, 0, length, new float[length]);
                //Log.info("Fast DCT Encoded: " + K(fArr3));
                float[] fArr4 = new float[length];
                for (int i2 = 0; i2 < length; i2++)
                {
                    fArr4[i2] = Math.Abs(fArr3[i2]);
                }
                Array.Sort(fArr4);
                float floatValue3 = fArr4[(int)Math.Floor(((float)(length - 1)) * f2)];
                for (int i3 = 0; i3 < length; i3++)
                {
                    if (Math.Abs(fArr3[i3]) < floatValue3)
                    {
                        fArr3[i3] = 0.0f;
                    }
                }
                //String sb2 = "Shrinked DCT (" + f2 + ")<" + floatValue3 + ">: " + K(fArr3);
                //Log.info(sb2);
                float f4 = fArr3[0];
                int i4 = length - 1;
                float[] fArr5 = new float[i4];
                Array.Copy(fArr3, 1, fArr5, 0, i4);
                Tuple<float, float> n2 = n(fArr5);
                float floatValue4 = n2.Item1;
                float floatValue5 = n2.Item2;
                //String sb3 = "Coef, min and max of DCT data: Coef(" + f4 + "), min(" + floatValue4 + "), max(" + floatValue5 + ")";
                //Log.info(sb3);
                String G2 = G(L(fArr5, floatValue4, floatValue5));
                int length3 = G2.Length;
                long a3 = a(G2);
                float b4 = b(floatValue4);
                float b5 = b(floatValue5);
                float b6 = b(f4);
                float f5 = b5 * 100.0f;
                long valueOf4 = ((long)Math.Round((b6 * 100.0f) + f5 + (b4 * 100.0f))) + a3;
                int length2 = G_.Length;
                long j2;
                if (length2 - length3 < 20)
                {
                    j2 = valueOf2;

                }
                else
                {
                    j2 = valueOf4;
                    str2 = String.Format("1;{0:0.00};{1:0.00};{2:0.00};{3};{4}", b4, b5, b6, a3, G2);

                }
                if (str2.Length == 0)
                {
                    str2 = "0;" + str3;
                    j2 = 0;
                }
                return new Tuple<String, long>(str2, j2);
            }
            throw new ArgumentException("Length must be power of 2");
        }


        public static int BitCount(int n)
        {
            var count = 0;
            while (n != 0)
            {
                count++;
                n &= (n - 1); //walking through all the bits which are set to one
            }

            return count;
        }

        public static void a0(float[] fArr, int i2, int i3, float[] fArr2)
        {
            if (i3 != 1)
            {
                int i4 = i3 / 2;
                for (int i5 = 0; i5 < i4; i5++)
                {
                    int i6 = i2 + i5;
                    float f2 = fArr[i6];
                    float f3 = fArr[((i2 + i3) - 1) - i5];
                    fArr2[i6] = f2 + f3;
                    fArr2[i6 + i4] = (f2 - f3) / (((float)Math.Cos(((((double)i5) + 0.5d) * 3.141592653589793d) / ((double)i3))) * 2.0f);
                }
                a0(fArr2, i2, i4, fArr);
                int i7 = i2 + i4;
                a0(fArr2, i7, i4, fArr);
                for (int i8 = 0; i8 < i4 - 1; i8++)
                {
                    int i9 = (i8 * 2) + i2;
                    int i10 = i2 + i8;
                    fArr[i9] = fArr2[i10];
                    int i11 = i10 + i4;
                    fArr[i9 + 1] = fArr2[i11] + fArr2[i11 + 1];
                }
                int i12 = i2 + i3;
                fArr[i12 - 2] = fArr2[i7 - 1];
                int i13 = i12 - 1;
                fArr[i13] = fArr2[i13];
            }
        }

        public static float b(float f2)
        {
            return ((float)Math.Round(f2 * 100.0f)) / 100.0f;
        }

        public static long[] a_a = { 3523407757L, 2768625435L, 1007455905L, 1259060791L, 3580832660L, 2724731650L, 996231864L, 1281784366L, 3705235391L, 2883475241L,
            852952723L, 1171273221L, 3686048678L, 2897449776L, 901431946L, 1119744540L, 3484811241L, 3098726271L, 565944005L, 1455205971L, 3369614320L, 3219065702L,
            651582172L, 1372678730L, 3245242331L, 3060352845L, 794826487L, 1483155041L, 3322131394L, 2969862996L, 671994606L, 1594548856L, 3916222277L, 2657877971L,
            123907689L, 1885708031L, 3993045852L, 2567322570L, 1010288L, 1997036262L, 3887548279L, 2427484129L, 163128923L, 2126386893L, 3772416878L, 2547889144L,
            248832578L, 2043925204L, 4108050209L, 2212294583L, 450215437L, 1842515611L, 4088798008L, 2226203566L, 498629140L, 1790921346L, 4194326291L, 2366072709L,
            336475711L, 1661535913L, 4251816714L, 2322244508L, 325317158L, 1684325040L, 2766056989L, 3554254475L, 1255198513L, 1037565863L, 2746444292L, 3568589458L,
            1304234792L, 985283518L, 2852464175L, 3707901625L, 1141589763L, 856455061L, 2909332022L, 3664761504L, 1130791706L, 878818188L, 3110715001L, 3463352047L,
            1466425173L, 543223747L, 3187964512L, 3372436214L, 1342839628L, 655174618L, 3081909835L, 3233089245L, 1505515367L, 784033777L, 2967466578L, 3352871620L,
            1590793086L, 701932520L, 2679148245L, 3904355907L, 1908338681L, 112844655L, 2564639436L, 4024072794L, 1993550816L, 30677878L, 2439710439L, 3865851505L,
            2137352139L, 140662621L, 2517025534L, 3775001192L, 2013832146L, 252678980L, 2181537457L, 4110462503L, 1812594589L, 453955339L, 2238339752L, 4067256894L,
            1801730948L, 476252946L, 2363233923L, 4225443349L, 1657960367L, 366298937L, 2343686810L, 4239843852L, 1707062198L, 314082080L, 1069182125L, 1220369467L,
            3518238081L, 2796764439L, 953657524L, 1339070498L, 3604597144L, 2715744526L, 828499103L, 1181144073L, 3748627891L, 2825434405L, 906764422L, 1091244048L,
            3624026538L, 2936369468L, 571309257L, 1426738271L, 3422756325L, 3137613171L, 627095760L, 1382516806L, 3413039612L, 3161057642L, 752284923L, 1540473965L,
            3268974039L, 3051332929L, 733688034L, 1555824756L, 3316994510L, 2998034776L, 81022053L, 1943239923L, 3940166985L, 2648514015L, 62490748L, 1958656234L,
            3988253008L, 2595281350L, 168805463L, 2097738945L, 3825313147L, 2466682349L, 224526414L, 2053451992L, 3815530850L, 2490061300L, 425942017L, 1852075159L,
            4151131437L, 2154433979L, 504272920L, 1762240654L, 4026595636L, 2265434530L, 397988915L, 1623188645L, 4189500703L, 2393998729L, 282398762L, 1741824188L,
            4275794182L, 2312913296L, 1231433021L, 1046551979L, 2808630289L, 3496967303L, 1309403428L, 957143474L, 2684717064L, 3607279774L, 1203610895L, 817534361L,
            2847130659L, 3736401077L, 1087398166L, 936857984L, 2933784634L, 3654889644L, 1422998873L, 601230799L, 3135200373L, 3453512931L, 1404893504L, 616286678L,
            3182598252L, 3400902906L, 1510651243L, 755860989L, 3020215367L, 3271812305L, 1567060338L, 710951396L, 3010007134L, 3295551688L, 1913130485L, 84884835L,
            2617666777L, 3942734927L, 1969605100L, 40040826L, 2607524032L, 3966539862L, 2094237127L, 198489425L, 2464015595L, 3856323709L, 2076066270L, 213479752L,
            2511347954L, 3803648100L, 1874795921L, 414723335L, 2175892669L, 4139142187L, 1758648712L, 534112542L, 2262612132L, 4057696306L, 1633981859L, 375629109L,
            2406151311L, 4167943193L, 1711886778L, 286155052L, 2282172566L, 4278190080L };

        public static long a(String str)
        {
            int length = str.Length;
            long j = 0;
            for (int i = 0; i < length; i++)
            {
                int charAt = (int)((255 & j) ^ ((long)str[i]));
                j = (CryptoAkamai.TripleShift(j, 8)) ^ a_a[charAt];
            }
            return j;
        }

  

        public static String G(String str)
        {
            int length = str.Length;
            StringBuilder sb = new StringBuilder();
            int i2 = 0;
            while (i2 < length)
            {
                int i3 = i2 + 1;
                char charAt = str[i2];
                int i4 = 1;
                while (i3 < length && charAt == str[i3])
                {
                    i4++;
                    i3++;
                }
                if (i4 > 1)
                {
                    sb.Append(i4);
                }
                sb.Append(charAt);
                i2 = i3;
            }
            return sb.ToString();
        }

        public static String L(float[] fArr, float f2, float f3)
        {
            int length = fArr.Length;
            StringBuilder sb = new StringBuilder();
            float f4 = (f3 - f2) / 60.0f;
            for (int i2 = 0; i2 < length; i2++)
            {
                char floor = (char)(((int)Math.Floor((fArr[i2] - f2) / f4)) + 65);
                if (fArr[i2] == f3)
                {
                    floor = '}';
                }
                if (floor == '\\')
                {
                    floor = '.';
                }
                else if (floor == '.')
                {
                    floor = '\\';
                }
                sb.Append(floor);
            }
            return sb.ToString();
        }


        public static Tuple<float, float> n(float[] fArr)
        {
            float f2 = fArr[0];
            float f3 = fArr[0];
            foreach (float f4 in fArr)
            {
                if (f4 < f2)
                {
                    f2 = f4;
                }
                else if (f4 > f3)
                {
                    f3 = f4;
                }
            }
            return new Tuple<float, float>(f2, f3);
        }


        public static String K(float[] fArr)
        {
            if (fArr.Length == 0)
            {
                return "(empty)";
            }
            StringBuilder V_ = V("(");
            for (int i2 = 0; i2 < fArr.Length; i2++)
            {
                if (i2 > 0)
                {
                    V_.Append(',');
                }
                V_.Append(String.Format("{0:0.00}", fArr[i2]));
            }
            V_.Append(")");
            return V_.ToString();
        }

        public static StringBuilder V(String str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            return sb;
        }





        public static float[] doublesTofloats(double[] doubles)
        {
            float[] floats = new float[doubles.Length];
            for (int i = 0; i < doubles.Length; i++)
            {
                floats[i] = (float)doubles[i];
            }

            return floats;
        }


        public static Tuple<Tuple<String, String>, long, long> getOrientationRandomData()
        {
            float[][] orientationsMatrix = generateRandomOrientation();
            Tuple<Tuple<String, String>, long, long> triple = getOrientationData(orientationsMatrix[0], orientationsMatrix[1], orientationsMatrix[2], orientationsMatrix[3]);
            return triple;
        }

        public static Tuple<Tuple<String, String>, long, long> getOrientationData(float[] azimut, float[] pitch, float[] roll, float[] timestamps)
        {
            Tuple<String, long> o_ = o(azimut, 0.6f);
            Tuple<String, long> o2 = o(pitch, 0.6f);
            Tuple<String, long> o3 = o(roll, 0.6f);
            Tuple<String, long> o4 = o(timestamps, 0.0f);
            Tuple<String, String> Tuple2 = new Tuple<String, String>(o_.Item1 + ":" + o2.Item1 + ":" + o3.Item1, o4.Item1);
            long longValue = o_.Item2 + o2.Item2 + o3.Item2;
            Tuple<Tuple<String, String>, long, long> triple = new Tuple<Tuple<String, String>, long, long>(Tuple2, longValue, (long)azimut.Length);
            return triple;

        }



        public static Tuple<Tuple<String, String>, long, long> getMotionRandomData()
        {
            float[][] motinMatrix = generateRandomMotion();
            Tuple<Tuple<String, String>, long, long> triple = getMotionData(
                    motinMatrix[0], motinMatrix[1], motinMatrix[2], motinMatrix[3],
                    motinMatrix[4], motinMatrix[5], motinMatrix[6], motinMatrix[7],
                    motinMatrix[8], motinMatrix[9]
                    );
            return triple;
        }

        public static Tuple<Tuple<String, String>, long, long> getMotionData(
                float[] ax, float[] ay, float[] az,
                float[] agx, float[] agy, float[] agz,
                float[] gx, float[] gy, float[] gz, float[] timestamps)
        {
            Tuple<String, long> o_ = o(ax, 0.6f);
            Tuple<String, long> o2 = o(ay, 0.6f);
            Tuple<String, long> o3 = o(az, 0.6f);
            Tuple<String, long> o4 = o(agx, 0.6f);
            Tuple<String, long> o5 = o(agy, 0.6f);
            Tuple<String, long> o6 = o(agz, 0.6f);
            Tuple<String, long> o7 = o(gx, 0.6f);
            Tuple<String, long> o8 = o(gy, 0.6f);
            Tuple<String, long> o9 = o(gz, 0.6f);
            Tuple<String, long> o10 = o(timestamps, 0.0f);

            Tuple<String, String> Tuple = new Tuple<String, String>(o_.Item1 + ":" + o2.Item1 + ":" + o3.Item1 + ":" + o4.Item1 + ":" + o5.Item1 + ":" + o6.Item1 + ":" + o7.Item1 + ":" +
                    o8.Item1 + ":" + o9.Item1, o10.Item1);
            Tuple<Tuple<String, String>, long, long> triple = new Tuple<Tuple<String, String>, long, long>(Tuple, o_.Item2 + o2.Item2 + o3.Item2 + o4.Item2 + o5.Item2 + o6.Item2 
                                                                                                                    + o7.Item2 + o8.Item2 + o9.Item2, (long)ax.Length);
            return triple;

        }

        private static int[] values_count = { 128 };// {32, 64,128};

        public static float[][] generateRandomOrientation()
        {
            int values = values_count[util.Random.nextInt(values_count.Length)];
            float[] azimut = new float[values];
            float azimutCenter = util.Random.nextInt(0, 45);
            float azimutRegion = util.Random.nextInt(0, 10);
            float[] pitch = new float[values];
            float pitchCenter = 0.7f; //Random.nextInt(0, 45);
            float pitchRegion = 0.07f; //Random.nextInt(0, 10);
            float[] roll = new float[values];
            float rollCenter = -0.5f;// Random.nextInt(0, 45);
            float rollRegion = 0.04f;// Random.nextInt(0, 10);
            float[] timestamps = new float[values];
            float timestampsCenter = 200;
            float timestampsRegion = util.Random.nextInt(0, 50);
            for (int i = 0; i < values; i++)
            {

                azimut[i] = randfloatSmall(azimutCenter, azimutRegion, 6);
                pitch[i] = randfloatSmall(pitchCenter, pitchRegion, 6);
                roll[i] = randfloatSmall(rollCenter, rollRegion, 6);
                timestamps[i] = randfloatSmall(timestampsCenter, timestampsRegion, 0);

            }

            if (true) timestamps[0] = util.Random.nextInt(600, 900);

            //Log.info("azimut : %s", Arrays.toString(azimut));
            //Log.info("pitch : %s", Arrays.toString(pitch));
            //Log.info("roll : %s", Arrays.toString(roll));
            //Log.info("timestamps : %s", Arrays.toString(timestamps));
            return new float[][] { (azimut), (pitch), (roll), (timestamps) };

        }


        public static float[][] generateRandomOrientationOld()
        {
            int values = values_count[util.Random.nextInt(values_count.Length)];
            float[] azimut = new float[values];
            int azimutCenter = util.Random.nextInt(0, 180);
            int azimutRegion = util.Random.nextInt(0, 10);
            float[] pitch = new float[values];
            int pitchCenter = util.Random.nextInt(0, 180);
            int pitchRegion = util.Random.nextInt(0, 10);
            float[] roll = new float[values];
            int rollCenter = util.Random.nextInt(0, 180);
            int rollRegion = util.Random.nextInt(0, 10);
            float[] timestamps = new float[values];
            int timestampsCenter = 200;
            int timestampsRegion = util.Random.nextInt(0, 100);
            for (int i = 0; i < values; i++)
            {

                azimut[i] = randfloatSmall(azimutCenter, azimutRegion, 6);
                pitch[i] = randfloatSmall(pitchCenter, pitchRegion, 6);
                roll[i] = randfloatSmall(rollCenter, rollRegion, 6);
                timestamps[i] = randfloatSmall(timestampsCenter, timestampsRegion, 1);

            }
            if (true) timestamps[0] = util.Random.nextInt(600, 900);
            //Log.info("azimut : %s", Arrays.toString(azimut));
            //Log.info("pitch : %s", Arrays.toString(pitch));
            //Log.info("roll : %s", Arrays.toString(roll));
            //Log.info("timestamps : %s", Arrays.toString(timestamps));
            return new float[][] { (azimut), (pitch), (roll), (timestamps) };

        }


        public static float[][] generateRandomMotion()
        {
            int values = values_count[util.Random.nextInt(values_count.Length)];
            float[] ax = new float[values];
            double axCenter = 0.02; //Random.nextInt(0, 45);
            double axRegion = 0.008; //Random.nextInt(0, 10);
            float[] ay = new float[values];
            double ayCenter = 0.03; //Random.nextInt(0, 45);
            double ayRegion = 0.01; //Random.nextInt(0, 10);
            float[] az = new float[values];
            double azCenter = 0.1; //Random.nextInt(0, 45);
            double azRegion = 0.04;//Random.nextInt(0, 10);

            float[] agx = new float[values];
            double agxCenter = 0.1; util.Random.nextInt(0, 45);
            double agxRegion = 0.04; util.Random.nextInt(0, 10);
            float[] agy = new float[values];
            double agyCenter = 0.04; //Random.nextInt(0, 45);
            double agyRegion = 0.01; //Random.nextInt(0, 10);
            float[] agz = new float[values];
            double agzCenter = -10; //Random.nextInt(0, 45);
            double agzRegion = 0.05; //Random.nextInt(0, 10);

            float[] gx = new float[values];
            double gxCenter = 0.2; //Random.nextInt(0, 45);
            double gxRegion = 0.4; util.Random.nextInt(0, 10);
            float[] gy = new float[values];
            double gyCenter = 0.3;// Random.nextInt(0, 45);
            double gyRegion = 0.03; // Random.nextInt(0, 10);
            float[] gz = new float[values];
            double gzCenter = -0.2; // Random.nextInt(0, 45);
            double gzRegion = 0.02; util.Random.nextInt(0, 10);


            float[] timestamps = new float[values];
            double timestampsCenter = 100;
            double timestampsRegion = util.Random.nextInt(0, 30);
            for (int i = 0; i < values; i++)
            {

                ax[i] = randfloatSmall(axCenter, axRegion, 8);
                ay[i] = randfloatSmall(ayCenter, ayRegion, 8);
                az[i] = randfloatSmall(azCenter, azRegion, 8);


                agx[i] = randfloatSmall(agxCenter, agxRegion, 8);
                agy[i] = randfloatSmall(agyCenter, agyRegion, 8);
                agz[i] = randfloatSmall(agzCenter, agzRegion, 8);

                gx[i] = randfloatSmall(gxCenter, gxRegion, 8);
                gy[i] = randfloatSmall(gyCenter, gyRegion, 8);
                gz[i] = randfloatSmall(gzCenter, gzRegion, 8);


                timestamps[i] = randfloatSmall(timestampsCenter, timestampsRegion, 0);

            }

            if (true) timestamps[0] = util.Random.nextInt(600, 900);

            //Log.info("ax : %s", Arrays.toString(ax));
            //Log.info("ay : %s", Arrays.toString(ay));
            //Log.info("az : %s", Arrays.toString(az));
            //Log.info("agx : %s", Arrays.toString(agx));
            //Log.info("agy : %s", Arrays.toString(agy));
            //Log.info("agz : %s", Arrays.toString(agz));
            //Log.info("gx : %s", Arrays.toString(gx));
            //Log.info("gy : %s", Arrays.toString(gy));
            //Log.info("gz : %s", Arrays.toString(gz));
            //Log.info("timestamps : %s", Arrays.toString(timestamps));
            return new float[][] { (ax), (ay), (az), (agx), (agy), (agz), (gx), (gy), (gz), (timestamps) };


        }

        public static float randfloatSmall(double center, double region, int accurate
        //int max, int min
        )
        {

            //double next = (center - region) + Math.random() * (2 * region);
            double next = (center - region) + (AkamaiUser.isTest ? 0.5 : util.Random.nextDouble()) * (2 * region);
            double round = Math.Pow(10, accurate);
            return (float)(Math.Round(next * round) / round);
        }



    }
}
