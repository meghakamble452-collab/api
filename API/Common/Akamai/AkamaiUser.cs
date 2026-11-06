using Akamai.intern.hook;
using Akamai.intern.sensors;
using Akamai.intern.touch;
using Akamai.key;
using Akamai.life;
using Akamai.util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using System.Web;

namespace Akamai
{
    internal class AkamaiPhoneModel
    {
        private String phoneMan = "";
        internal AkamaiPhoneModel()
        {
            string[] authors = { "samsung", "oneplus", "nokia", "michina", "apple", "motorola", "sony", "alcatel", "panasonic", "htc", "siemens" };
            int ind = new System.Random().Next(authors.Length);
            phoneMan = authors[ind];
        }
        public string method_0(int Aj, string Mup)
        {
            AkamaiUser userNext = new AkamaiUser();
            //userNext.phoneBrand = phoneMan;
            //userNext.phoneManufacture = phoneMan;
            //-userNext.phoneAndroidId = Mup;

            //userNext.phoneHardware = phoneMan + "exynos7870";
            //userNext.phoneFingerPrint = phoneMan + "/j7y17ltexxm/j7y17lte:9/PPR1.180610.011/J730FMXXS7CUD2:user/release-keys";
            string Pri_x_acf = userNext.buildAkamaiHeader(0);
            return (Pri_x_acf);     //HttpUtility.UrlDecode
        }
    }
    class AkamaiUser
    {
        /******* for test ************/
        public static bool isTest = false;



        private SystemClock systemClock = new SystemClock();

        private long timeBeginSession = System2.currentTimeMillis() - util.Random.nextInt(120000, 190000);
        //System.currentTimeMillis() - Random.nextInt(40000, 70000);

        private String packageName = "cris.org.in.prs.ima";
        private String phoneRelease = "12";
        private String phoneModel = "SM-J730FM";
        private String phoneBootloader = "J730FMXXS7CUD2";
        private String phoneSDK = "32";
        private String phoneHardware = "nokiaexynos7870";
        public String phoneAndroidId = getRandomAndroidID();
        private String phoneIncremental = "J730FMXXS7CUD2";
        private String phoneManufacture = "nokia";
        private String phoneProduct = "j7y17ltexxm";
        private String phoneDisplay = "PPR1.180610.011.J730FMXXS7CUD2";
        private String phoneBoard = "universal7870";
        private String phoneBrand = "nokia";
        private String phoneDevice = "j7y87lte";
        private String phoneFingerPrint = "nokia/j7y17ltexxm/j7y87lte:9/PPR1.180610.011/J730FMXXS7CUD2:user/release-keys";
        private String phoneHost = "SWDH4621";
        private String phoneId = "PPR1.180610.011";
        private String phoneBatteryCharge = util.Random.nextInt(30, 90).ToString();
        private int phoneHeightPixels = 1920;
        private int phoneWidthPixels = 1080;

        private String phoneData;
        private long timeCalculatePhoneData;
        private String perfomance_string = "default_performance";


        public AkamaiUser()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
        }

        public long uptimeMillis()
        {
            return systemClock.uptimeMillis();
        }

        public static String getRandomAndroidID()
        {
            long randlong = Math.Abs((long)util.Random.nextUnLong()) + 0x1000000000000000L;

            return randlong.ToString("x16");
        }

        public long getTimeBeginSession()
        {
            return timeBeginSession;
        }

        public void setTimeBeginSession(long timeBeginSession)
        {
            this.timeBeginSession = timeBeginSession;
        }

        public String getPhoneRelease()
        {
            return phoneRelease;
        }

        public void setPhoneRelease(String phoneRelease)
        {
            this.phoneRelease = phoneRelease;
        }

        public String getPhoneModel()
        {
            return phoneModel;
        }

        public void setPhoneModel(String phoneModel)
        {
            this.phoneModel = phoneModel;
        }

        public String getPhoneBootloader()
        {
            return phoneBootloader;
        }

        public void setPhoneBootloader(String phoneBootloader)
        {
            this.phoneBootloader = phoneBootloader;
        }

        public String getPhoneSDK()
        {
            return phoneSDK;
        }

        public void setPhoneSDK(String phoneSDK)
        {
            this.phoneSDK = phoneSDK;
        }

        public String getPhoneHardware()
        {
            return phoneHardware;
        }

        public void setPhoneHardware(String phoneHardware)
        {
            this.phoneHardware = phoneHardware;
        }

        public String getPackageName()
        {
            return packageName;
        }

        public void setPackageName(String packageName)
        {
            this.packageName = packageName;
        }

        public String getPhoneAndroidId()
        {
            return phoneAndroidId;
        }

        public void setPhoneAndroidId(String phoneAndroidId)
        {
            this.phoneAndroidId = phoneAndroidId;
        }

        public String getPhoneIncremental()
        {
            return phoneIncremental;
        }

        public void setPhoneIncremental(String phoneIncremental)
        {
            this.phoneIncremental = phoneIncremental;
        }

        public String getPhoneManufacture()
        {
            return phoneManufacture;
        }

        public void setPhoneManufacture(String phoneManufacture)
        {
            this.phoneManufacture = phoneManufacture;
        }

        public String getPhoneProduct()
        {
            return phoneProduct;
        }

        public void setPhoneProduct(String phoneProduct)
        {
            this.phoneProduct = phoneProduct;
        }

        public String getPhoneBoard()
        {
            return phoneBoard;
        }

        public void setPhoneBoard(String phoneBoard)
        {
            this.phoneBoard = phoneBoard;
        }

        public String getPhoneDisplay()
        {
            return phoneDisplay;
        }

        public void setPhoneDisplay(String phoneDisplay)
        {
            this.phoneDisplay = phoneDisplay;
        }

        public String getPhoneBrand()
        {
            return phoneBrand;
        }

        public void setPhoneBrand(String phoneBrand)
        {
            this.phoneBrand = phoneBrand;
        }

        public String getPhoneDevice()
        {
            return phoneDevice;
        }

        public void setPhoneDevice(String phoneDevice)
        {
            this.phoneDevice = phoneDevice;
        }

        public String getPhoneFingerPrint()
        {
            return phoneFingerPrint;
        }

        public void setPhoneFingerPrint(String phoneFingerPrint)
        {
            this.phoneFingerPrint = phoneFingerPrint;
        }

        public String getPhoneHost()
        {
            return phoneHost;
        }

        public void setPhoneHost(String phoneHost)
        {
            this.phoneHost = phoneHost;
        }

        public String getPhoneId()
        {
            return phoneId;
        }

        public void setPhoneId(String phoneId)
        {
            this.phoneId = phoneId;
        }

        public String getPhoneBatteryCharge()
        {
            return phoneBatteryCharge;
        }

        public void setPhoneBatteryCharge(String phoneBatteryCharge)
        {
            this.phoneBatteryCharge = phoneBatteryCharge;
        }

        public int getPhoneHeightPixels()
        {
            return phoneHeightPixels;
        }

        public void setPhoneHeightPixels(int phoneHeightPixels)
        {
            this.phoneHeightPixels = phoneHeightPixels;
        }

        public int getPhoneWidthPixels()
        {
            return phoneWidthPixels;
        }

        public void setPhoneWidthPixels(int phoneWidthPixels)
        {
            this.phoneWidthPixels = phoneWidthPixels;
        }

        public String getPhoneData()
        {
            if (phoneData == null)
            {
                phoneData = generatePhoneData();
            }

            return phoneData;
        }

        public void setPhoneData(String phoneData)
        {
            this.phoneData = phoneData;
        }

        public void setTimeCalculatePhoneData(long timeCalculatePhoneData)
        {
            this.timeCalculatePhoneData = timeCalculatePhoneData;
        }

        public long getTimeCalculatePhoneData()
        {
            return timeCalculatePhoneData;
        }

        public String getPerfomance_string()
        {
            return perfomance_string;
        }

        public void setPerfomance_string(String perfomance_string)
        {
            this.perfomance_string = perfomance_string;
        }


        private String generatePhoneData()
        {
            long uptimeMillis_ = uptimeMillis();

            int i = getPhoneHeightPixels(); // displayMetrics.heightPixels;
            int i2 = getPhoneWidthPixels(); //  displayMetrics.widthPixels;

            int i3 = util.Random.nextInt(1, 3); //getResources().getConfiguration().orientation
            String language = "in"; //Locale.getDefault().getLanguage();
            String str = getPhoneRelease(); //Build.VERSION.RELEASE;
            int i4 = util.Random.nextInt(0, 2); // Settings.System.getInt(application.getContentResolver(), "accelerometer_rotation", 0) == 1 ? 1 : 0;
            String str2 = getPhoneModel(); //  Build.MODEL;
            String str3 = getPhoneBootloader(); // Build.BOOTLOADER;
            String i5 = getPhoneSDK(); //Build.VERSION.SDK_INT;
            String str4 = getPhoneHardware(); //  Build.HARDWARE;
            String packageName = getPackageName(); //  application.getPackageName();
            String b2 = getPhoneAndroidId(); //C0837se.b(application);
            int i6 = 0; //application.getResources().getConfiguration().keyboard != 1 ? 1 : 0;
            long j = uptimeMillis_;
            int i7 = 0; //Settings.Global.getInt(application.getContentResolver(), "adb_enabled", 0);
            String str5 = "REL"; //Build.VERSION.CODENAME;
            String str6 = getPhoneIncremental(); //Build.VERSION.INCREMENTAL;
            String str7 = getPhoneManufacture(); //Build.MANUFACTURER;
            String str8 = getPhoneProduct(); //Build.PRODUCT;
            String str9 = "release-keys"; //Build.TAGS;
            String str10 = "user"; //Build.TYPE;
            String str11 = "dpi"; //  "android-build";  // Build.USER;
            String str12 = getPhoneDisplay(); // Build.DISPLAY;
            String str13 = getPhoneBoard(); // Build.BOARD;
            String str14 = getPhoneBrand(); //Build.BRAND;
            String str15 = getPhoneDevice(); //Build.DEVICE;
            String str16 = getPhoneFingerPrint(); //Build.FINGERPRINT;
            String str17 = getPhoneHost(); //Build.HOST;
            String str18 = getPhoneId(); //Build.ID;

            StringBuilder sb = new StringBuilder();
            sb.Append("-1");
            sb.Append(",uaend,-1,");
            sb.Append(i);
            sb.Append(",");
            sb.Append(i2);
            sb.Append(",");
            sb.Append(1);
            sb.Append(",");
            sb.Append(getPhoneBatteryCharge());
            sb.Append(",");
            sb.Append(i3);
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(language));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str));
            sb.Append(",");
            sb.Append(i4);
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str2));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str3));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str4));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0("-1"));
            sb.Append(",");
            sb.Append(packageName);
            sb.Append(",");
            sb.Append(CryptoAkamai.D0("-1"));
            sb.Append(",-1,");
            sb.Append(b2);
            sb.Append(",-1,");
            sb.Append(i6);
            sb.Append(",");
            sb.Append(i7); //adb enabled
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str5)); // REL
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str6));
            sb.Append(",");
            sb.Append(i5); //Build.VERSION.SDK_IN
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str7));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str8));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str9));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str10));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str11));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str12));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str13));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str14));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str15));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str16));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str17));
            sb.Append(",");
            sb.Append(CryptoAkamai.D0(str18));
            //Log.info(sb.toString());
            //"System Info: ".concat(String.valueOf(sb2));
            //C0775ie.b = sb2;
            //setPhoneData(sb.toString());

            Thread.Sleep(util.Random.nextInt(1, 2));

            setTimeCalculatePhoneData(uptimeMillis() - j);
            //C0770he.f6420c = uptimeMillis() - j;
            //f4317a = true;

            return sb.ToString();
        }

        public String buildAkamaiHeader(int A)
        {
            if (A == 0)
                return buildAkamaiHeader(HookEvent.Webmtoken);
            else if (A == 1)
                return buildAkamaiHeader(HookEvent.ValidateUser);
            else if (A == 2)
                return buildAkamaiHeader(HookEvent.AvlFarenquiry);
            else
                return buildAkamaiHeader(HookEvent.Universal);
        }

        /*** building sensor data ********/
        public String buildAkamaiHeader(HookEvent hookEvent)
        {
            if (getPerfomance_string().Equals("default_performance"))
            {
                setPerfomance_string(CryptoAkamai.getPerfomanceString(this));
                //Log.info("perfomance string : %s", getPerfomance_string());
            }

            long uptimeMillis_ = uptimeMillis();

            String phoneData = getPhoneData();
            //Log.info("phoneData : %s", phoneData);
            String str7 = phoneData + "," + CryptoAkamai.hashCustom(phoneData) + "," +
                          util.Random.nextInt(Int32.MaxValue) + "," + getTimeBeginSession() / 2;
            //Log.info("data -100 : %s", str7);

            Tuple<Tuple<String, String>, long, long> c = SensorsUtils.getOrientationRandomData();
            Tuple<Tuple<String, String>, long, long> b2 = SensorsUtils.getMotionRandomData();
            Tuple<Tuple<String, long>, long> touchData = TouchUtils.getRandomTouchData();
            Tuple<String, long> Tuple = touchData.Item1;
            Tuple<Tuple<String, long>, long> keyData = KeysUtils.getRandomKeyData(hookEvent);
            Tuple<String, long> Tuple2 = keyData.Item1;
            String str9 = Tuple2.Item1;
            String str10 = Tuple.Item1;
            String str11 = KeysUtils.getEditTextsList(hookEvent);
            String str12 = ActivityUtils.getRandomActivityData(hookEvent, this);
            String str16 = "do_en,dm_en,t_en"; // means do orientation and movie listener
            long uptimeMillis2 = (uptimeMillis() - uptimeMillis_) * 1000;
            int i = 0; // means this thread is not main Gui thread
            long longValue = Tuple2.Item2 + Tuple.Item2 + c.Item2 + b2.Item2;
            long currentTimeMillis = System2.currentTimeMillis() - getTimeBeginSession();
            long j = keyData.Item2;
            long j3 = touchData.Item2;
            String str22 = Tuple2.Item2 + "," + Tuple.Item2 + "," + c.Item2 + "," + b2.Item2 + "," + longValue + "," +
                           currentTimeMillis + "," + j + "," + j3 + ","
                           + c.Item3 + "," + b2.Item3 + "," + (getTimeCalculatePhoneData() * 1000) + ","
                           + uptimeMillis2 / 4 //debug
                           + "," + 1 + "," +
                           CryptoAkamai.k(
                               (((long)((int)longValue)) << 32) |
                               (((long)((int)(j + j3 + c.Item3 + b2.Item3))) & 0xFFFFFFFFL),
                               (int)currentTimeMillis) +
                           "," + getTimeBeginSession();
            String str23 = i + "," + 0;
            String str24 = c.Item1.Item1;
            String str25 = b2.Item1.Item1;

            List<Tuple<String, String>> arrayList = new List<Tuple<String, String>>();
            arrayList.Add(new Tuple<String, String>("", "3.3.0"));
            arrayList.Add(new Tuple<String, String>("-70", ""));
            arrayList.Add(new Tuple<String, String>("-80", ""));
            arrayList.Add(new Tuple<String, String>("-100", str7));
            arrayList.Add(new Tuple<String, String>("-101", str16));
            arrayList.Add(new Tuple<String, String>("-102", str11));
            arrayList.Add(new Tuple<String, String>("-103", str12));
            arrayList.Add(new Tuple<String, String>("-108", str9));
            arrayList.Add(new Tuple<String, String>("-112", getPerfomance_string()));
            arrayList.Add(new Tuple<String, String>("-115", str22));
            arrayList.Add(new Tuple<String, String>("-117", str10));
            arrayList.Add(new Tuple<String, String>("-120", "")); // contain exception stack if some exception in akamai process
            arrayList.Add(new Tuple<String, String>("-121", ""));
            arrayList.Add(new Tuple<String, String>("-144", c.Item1.Item2));
            arrayList.Add(new Tuple<String, String>("-142", str24));
            arrayList.Add(new Tuple<String, String>("-145", b2.Item1.Item2));
            arrayList.Add(new Tuple<String, String>("-143", str25));
            arrayList.Add(new Tuple<String, String>("-150", str23));
            //Log.info(arrayList.toString());

            StringBuilder builder = new StringBuilder("ArrayList<Tuple<String, String>> list2 = new ArrayList<>();");
            foreach (Tuple<String, String> next in arrayList)
            {
                builder.Append("\r\n").Append(String.Format("list2.add(new Tuple<String, String>(\"{0}\", \"{1}\"));",
                    next.Item1, next.Item2));

            }
            //Log.info(builder.toString());

            if (isTest)
            {
                foreach (Tuple<String, String> p in arrayList)
                {
                    Console.WriteLine(String.Format("\"{0}\", \"{1}\"", p.Item1, p.Item2));
                }
            }
            String data = CryptoAkamai.concatData(arrayList);
            if (isTest) Console.WriteLine(data);

            byte[] key = new byte[16];
            byte[] hmacKey = new byte[32];
            byte[] iv = new byte[16];

            util.Random.nextBytes(key);
            util.Random.nextBytes(hmacKey);
            util.Random.nextBytes(iv);

            byte[] encrypted = CryptoAkamai.aes128CBCEncrypt(Encoding.UTF8.GetBytes(data), key, iv);
            //Log.info(HexDumpUtil.hexDump(encrypted));
            //Log.info("0x%x(%d)", encrypted.Length, encrypted.Length);

            byte[] bytesForHmac = new byte[iv.Length + encrypted.Length];
            Array.Copy(iv, 0, bytesForHmac, 0, iv.Length);
            Array.Copy(encrypted, 0, bytesForHmac, iv.Length, encrypted.Length);

            byte[] hmac = CryptoAkamai.hmacSha256(bytesForHmac, hmacKey);
            //Log.info("hmac%n%s", HexDumpUtil.hexDump(hmac));

            byte[] bytesForBase64 = new byte[bytesForHmac.Length + hmac.Length];
            Array.Copy(bytesForHmac, 0, bytesForBase64, 0, bytesForHmac.Length);
            Array.Copy(hmac, 0, bytesForBase64, bytesForHmac.Length, hmac.Length);
            //Log.info(HexDumpUtil.hexDump(bytesForBase64));

            String dataPart = System.Convert.ToBase64String(bytesForBase64);
            //Log.info(dataPart);

            String rsaAesKeyEncrypt = CryptoAkamai.rsaEncrypt(key);
            //Log.info("rsa key encrypted :      %s", rsaAesKeyEncrypt);

            String rsaHmacKeyEncrypt = CryptoAkamai.rsaEncrypt(hmacKey);
            //Log.info("rsa hmac key encrypted : %s", rsaHmacKeyEncrypt);

            String akamai = String.Format(CryptoAkamai.AKAMAI_OUTPUT_FORMAT, rsaAesKeyEncrypt, rsaHmacKeyEncrypt,
                dataPart);
            //Log.info(akamai);
            return akamai;
        }
    }
}
