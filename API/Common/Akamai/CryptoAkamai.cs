using Akamai.intern;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Akamai
{
    class CryptoAkamai
    {
        private static String PUBLIC_KEY_RSA = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDMUymkqr6SQfxqefXMdkI6E1tDzHispEm4WhZAfIWjhvEqfStzy16HvCjIBX2SRpn5pqW2w1TxqyxRnJOe4NEskWGdYY2y4JiD9vpYpWB54u6TOnKutXn2LzjMrvfIJpVXYZ5LYtD1ZUaeTKPz6qELXmBNcSfh/kGLiP8AH4eWKwIDAQAB";
        private static String DELIMETER_DATA = "-1,2,-94,";
        public static String AKAMAI_OUTPUT_FORMAT = "3,a,{0},{1}${2}$1000,1000,1000$$";

        public static byte[] aes128CBCEncrypt(byte[] plainTextBytes, byte[] aesKeyBytes, byte[] ivBytes)
        {
            RijndaelManaged aes = GetCBCRijndaelManaged(aesKeyBytes, ivBytes);
            return aes.CreateEncryptor().TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length);
        }

        public static byte[] aes128CBCDecrypt(byte[] encTextBytes, byte[] aesKeyBytes, byte[] ivBytes)
        {
            RijndaelManaged aes = GetCBCRijndaelManaged(aesKeyBytes, ivBytes);
            return aes.CreateDecryptor().TransformFinalBlock(encTextBytes, 0, encTextBytes.Length);
        }

        public static RijndaelManaged GetCBCRijndaelManaged(byte[] secretKeyBytes, byte[] ivBytes)
        {

            return new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 16 * 8,
                BlockSize = 128,
                Key = secretKeyBytes,
                IV = ivBytes
            };
        }


        public static byte[] hmacSha256(byte[] message, byte[] key)
        {
            var hash = new HMACSHA256(key);
            return hash.ComputeHash(message);
        }



        public static String rsaEncrypt(byte[] data)
        {
            RSACryptoServiceProvider RSA = PemKeyUtils.DecodeX509PublicKey(System.Convert.FromBase64String(PUBLIC_KEY_RSA));
            byte[] encryptedData = RSA.Encrypt(data, false);
            return System.Convert.ToBase64String(encryptedData);
        }


        public static String concatData(List<Tuple<String, String>> list)
        {
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0)
                {
                    b.Append(list[i].Item2);
                }
                else
                {
                    b.Append(list[i].Item1).Append(",").Append(list[i].Item2);
                }

                if (i != list.Count - 1)
                {
                    b.Append(DELIMETER_DATA);
                }

            }

            return b.ToString();
        }


        public static int hashCustom(String str)
        {
            if (str == null || str.Trim().Equals(""))
            {
                return -1;
            }
            int i2 = 0;
            int i3 = 0;
            while (i2 < str.Length)
            {
                char charAt = str[i2];
                if (charAt < 128)
                {
                    i3 += charAt;
                }
                i2++;
            }
            return i3;
        }



        public static long k(long l10, int n10)
        {
            int n11;

            int n12 = (int)l10;
            int n13 = (int)(l10 >> 32);
            int n14 = 0;
            while ((n11 = n14) < 16)
            {
                n14 = n11 + 1;
                n11 = n13 ^ ((n10 << n11 | TripleShift(n10, 32 - n11)) ^ n12);//for debug problem
                n13 = n12;
                n12 = n11;
            }
            l10 = n13;
            long l11 = n12;

            return l10 << 32 | l11 & 0xFFFFFFFFL;
        }

        public static long TripleShift(long n, int s)
        {
            if (n >= 0)
                return n >> s;
            return (n >> s) + (2 << ~s);
        }


        public static int TripleShift(int n, int s)
        {
            if (n >= 0)
                return n >> s;
            return (n >> s) + (2 << ~s);
        }



        public static String getPerfomanceString(AkamaiUser akamaiUser)
        {

            long limit1 = util.Random.nextInt(2, 8);
            long limit2 = util.Random.nextInt(1, 3);
            long limit3 = util.Random.nextInt(10, 20);

            int i;
            try
            {
                long uptimeMillis = akamaiUser.uptimeMillis();
                int i2 = 1;
                int i3 = 0;
                int i4 = 0;
                while (true)
                {
                    if (i2 < 1000000)
                    {
                        if (((4508713 % i2) * 11) % i2 == 0)
                        {
                            i3++;
                        }
                        if (i2 % 100 == 0 && akamaiUser.uptimeMillis() - uptimeMillis > limit1)
                        {

                            break;
                        }
                        i4++;
                        i2++;
                    }
                    else
                    {
                        break;
                    }
                }
                int i5 = i4 / 100;
                float f = 33.34f;
                long uptimeMillis2 = akamaiUser.uptimeMillis();
                int i6 = 0;
                int i7 = 0;
                for (int i8 = 1; i8 < 1000000; i8++)
                {
                    f += (float)i8;
                    if ((19.239f * f) / 3.56f < 10000.0f)
                    {
                        i6++;
                    }
                    if (i8 % 100 == 0 && akamaiUser.uptimeMillis() - uptimeMillis2 > 2)
                    {
                        break;
                    }
                    i7++;
                }
                int i9 = i7 / 100;
                long uptimeMillis3 = akamaiUser.uptimeMillis();
                int i10 = 0;
                int i11 = 0;
                for (double d = 1.0d; d < 1000000.0d; d += 1.0d)
                {
                    if (Math.Sqrt(d) > 30.0d)
                    {

                        i10++;
                    }
                    if (((int)d) % 100 == 0 && akamaiUser.uptimeMillis() - uptimeMillis3 > limit2)
                    {
                        break;
                    }
                    i11++;
                }
                int i12 = i10;
                int i13 = i11 / 100;
                //System.out.printf("i12=%d, i13=%d%n", i12, i13);

                long uptimeMillis4 = akamaiUser.uptimeMillis();
                int i14 = 1;
                int i15 = 0;
                int i16 = 0;
                for (i = 1000000; i14 < i; i = 1000000)
                {
                    long j = uptimeMillis4;
                    if (Math.Acos((double)(i14 / i)) + Math.Asin((double)(i14 / i)) + Math.Atan((double)(i14 / 1000000)) > 1.5d)
                    {
                        i15++;
                    }
                    if (i14 % 100 == 0 && akamaiUser.uptimeMillis() - j > limit3)
                    {
                        break;
                    }
                    i16++;
                    i14++;
                    uptimeMillis4 = j;
                }
                int i17 = i16 / 100;
                long uptimeMillis5 = akamaiUser.uptimeMillis();
                int i18 = 0;
                for (int i19 = 1; i19 < 1000000 && akamaiUser.uptimeMillis() - uptimeMillis5 <= 2; i19++)
                {
                    i18++;
                }
                return i3 + "," + i5 + "," + i6 + "," + i9 + "," + i12 + "," + i13 + "," + i15 + "," + i17 + "," + i18;
            }
            catch (Exception e)
            {

                throw e;
                //return "-1,-1,-1,-1,-1,-1,-1,-1,-1";
            }
        }

        public static String D0(String str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            //bytes[0] = (byte) 7;
            StringBuilder b = new StringBuilder(bytes.Length);

            foreach (byte b2 in bytes)
            {
                if (!(b2 < 33 || b2 > 126 || b2 == 34 || b2 == 37 || b2 == 39 || b2 == 44 || b2 == 92))
                {
                    b.Append((char)b2);

                }
                else
                {

                    b.Append('%');
                    char forDigit_ = forDigit((b2 >> 4) & 15, 16);
                    if (Char.IsLetter(forDigit_))
                    {
                        forDigit_ = (char)(forDigit_ - ' ');
                    }
                    b.Append(forDigit_);
                    char forDigit2 = forDigit(b2 & 15, 16);
                    if (Char.IsLetter(forDigit2))
                    {
                        forDigit2 = (char)(forDigit2 - ' ');
                    }
                    b.Append(forDigit2);
                }
            }
            return b.ToString();
        }

        public static char forDigit(int digit, int radix)
        {
            if ((digit >= radix) || (digit < 0))
            {
                return '\0';
            }
            if ((radix < 2) || (radix > 36))
            {
                return '\0';
            }
            if (digit < 10)
            {
                return (char)('0' + digit);
            }
            return (char)('a' - 10 + digit);
        }



    }
}
