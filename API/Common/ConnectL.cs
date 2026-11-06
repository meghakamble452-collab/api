using API.Controllers;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using NativeCSharpJWTToken;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Routing;
using System.Web.Services.Description;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using Strings = Microsoft.VisualBasic.Strings;
using X509Certificate = System.Security.Cryptography.X509Certificates.X509Certificate;

namespace API.Common
{
    public class ConnectL
    {
        bool IsConnt = false;
        private ReadyPost class3_0;
        WebProxy webProxy_Smart = null;
        public X509Certificate2Collection TvJeboisorCertificate;

        private string Reffral = "";
        private string keyFromServer;
        private string greq;
        private string mup;
        private string _Authrization;
        private string access_token;
        private string jwtToken;
        private bool bool_48;
        internal CookieContainer cookie_;
        private bool isAPP;
        private string bool_63;

        public WebProxy Proxy_idcr1 { get; private set; }
        public string LoginType { get; private set; }

        private string postdata = "";
        private string errormsg;
        private string response;
        private DateTime dateTime_0;
        private DateTime dateTime_3;
        private CngKey randomGeneratedKey;
        private DateTime dateTime_1;
        private string _Error;
        private string _reponse;
        private int int_28;
        private bool bool_21;
        private object long_0;
        private object long_1;
        private string dsed;
        private bool isPremium_p;
        private string uriPNR;
        private string string_70;
        private bool bool_0;
        private string string_64;
        private string string_52;
        public string Status { get; private set; }
        public string Request_Type { get; private set; }
        public bool SensorDataSend { get; private set; }
        public bool Boolean_0 { get; private set; }
        public int Int32_0 { get; private set; }
        public string String_0 { get; private set; }
        public string ConnectionGroupName_ { get; private set; }

        private WebException Exception_;
        private object updTStatus;
        private JWTUtils jwtutils = new JWTUtils();
        private string string_90;
        private string string_91;
        public string string_88;
        private string string_72;
        private string string_86;
        private string string_87;
        private string string_29;
        private bool bool_24;
        private bool bool_11;
        private string string_16;
        private string string_5;
        private string string_71;
        private bool bool_501;
        private bool bool_38;
        private bool bool_36;
        private bool bool_37;
        private bool bool_29;
        private bool bool_30;
        private bool bool_23;
        private bool bool_51;
        private bool bool_27;
        private bool bool_14;
        private bool bool_13;
        private bool bool_40;
        private bool bool_41;
        private bool bool_15;
        private IWebProxy webProxy_0;
        private WebProxy webProxy_1;
        private CookieContainer cookieContainer_1;
        private WebException webException_0;
        private bool bool_28;
        private int int_Slot;
        private WebProxy Proxy_;
        private string bmiyek;
        private bool bool_22;
        public static X509Certificate2Collection x509Certificate2Collection_0;
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        private object randK0SecondService;
        private static IntPtr intptr_0 = (IntPtr)32;
        private static object object_28 = new RNGCryptoServiceProvider();
        protected static char[] hexArray = "0123456789ABCDEF".ToCharArray();
        public static string x509CertSecondServiceaaa = "-----BEGIN CERTIFICATE-----\nMIIErDCCA5SgAwIBAgIKFzMa/spgXyVfATANBgkqhkiG9w0BAQsFADCB9zELMAkG\nA1UEBhMCSU4xRTBDBgNVBAoTPEluc3RpdHV0ZSBmb3IgRGV2ZWxvcG1lbnQgYW5k\nIFJlc2VhcmNoIGluIEJhbmtpbmcgVGVjaG5vbG9neTEdMBsGA1UECxMUQ2VydGlm\neWluZyBBdXRob3JpdHkxDzANBgNVBBETBjUwMDA1NzEXMBUGA1UECBMOQW5kaHJh\nIFByYWRlc2gxKTAnBgNVBAkTIFJvYWQgTm8uMSwgTWFzYWIgVGFuaywgSHlkZXJh\nYmFkMRUwEwYDVQQzEwxDYXN0bGUgSGlsbHMxFjAUBgNVBAMTDUlEUkJUIENBIDIw\nMTQwHhcNMTYwMzMxMTIwMzUyWhcNMTgwMzMxMTIwMzUyWjASMRAwDgYDVQQDEwd1\ncGlucGNpMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAsqMattxoTibl\naGsAneFo5TgFfvRltQ2CqteIgUVJlLMz95P35Y+GQc2EOjVEO0L1OUd5IDTIBaqh\nrTqeWypOyna+CsHPqDRY0vsklCYizw/VQkdwLBZHMMhU4jL4wciE7qcf2kdyri6B\n135SzUF5IGPn4SnSkeB3IqHzneUrabP0lJweLF7IU5l9qtpPa6A5cH1iVKQT5YAI\n4NWH+3E/MRNKvdqgU1PILlOEaVB0vJZ1pBWW1aMaecoHfzC8/pTfM2PJ5s/CDbR0\n4xqX9/AYmkt34jMwBKvboyWjD1UgCkPnJd3SaZ4vDpA+nyTITM6uGOI6e6sv/b6v\ntF7nbM3H7wIDAQABo4IBHDCCARgwDgYDVR0PAQH/BAQDAgWgMB0GA1UdDgQWBBQq\nlITKolqdgylQXHZgJ1WJMLhvnDAfBgNVHSMEGDAWgBSAdQI0B9ReDs4FarWs8BBr\nQhsHxzAdBgNVHSUEFjAUBggrBgEFBQcDAQYIKwYBBQUHAwIwOAYDVR0gBDEwLzAt\nBgZggmRkAgMwIzAhBggrBgEFBQcCAjAVGhNDbGFzcyAzIENlcnRpZmljYXRlMBIG\nA1UdEQQLMAmCB3VwaW5wY2kwWQYDVR0fBFIwUDAkoCKgIIYeaHR0cDovLzEwLjAu\nNjUuNjUvY3JsXzI3QjAuY3JsMCigJqAkhiJodHRwOi8vaWRyYnRjYS5vcmcuaW4v\nY3JsXzI3QjAuY3JsMA0GCSqGSIb3DQEBCwUAA4IBAQB6Y1FmD1GRKdEW4GINYutM\njDxZmHy4HGFmkE3xZjQx9aDT34TpLSNpsg8jUF+nW/KUMb+nWKJuIRZESYfBSCS9\n2fP1AJAO+PKopJMep/weJ+6a0ydPeoKbqKYllTlmFy+DPC56/UuEBQ9iIX3n5RW9\nxZFTB3NFC9A8zhxCBTsxizElrP8Jd4s+I3+qzJIw9ZqGknDgipyYoi0GGx2mjfwH\npg4YQ4/2xjG2ZRQwkgEmcxy/NvbXz1NV5P5u7dit9SwX3gaAZybu2guIcLFcVEvw\n1VpioZlgPjr5RVhyGzX+tBS8rapTNG1C8A7ANLxpk3nqYzNh4XjhMm5EQ3oKDD9d\n-----END CERTIFICATE-----";
        private CookieContainer cookie_email;
        public static byte[] salt = Encoding.ASCII.GetBytes("YHQ8JZB22LKR7QHDPFTXWXNZV49S6T9M");
        public static string password = "7Kr^z)M@{!LW{nQV%p}8Rz#5Vb4&TYe*QF[Z]_1fw~u3Jc9Xg";
        private static readonly char[] _digits = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567".ToCharArray();

        public ConnectL()
        {
            string AdminIP = "in.smartproxy.com||10000||sph5n06d99||7bwovWwh6fHIVgwc67";
            string[] array = AdminIP.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
            webProxy_Smart = new WebProxy(array[0], int.Parse(array[1]));
            webProxy_Smart.Credentials = new NetworkCredential(array[2], array[3]);
        }

        public cls02 IrctcReponse(RequestBody BodyResponse, X509Certificate2Collection TvJeboisorCertificate2)
        {
            cls02 cls020 = new cls02();
            TvJeboisorCertificate = TvJeboisorCertificate2;
            string url = "";
            string postdata = "";
            string reff = "";
            WebProxy webProxy_0 = null;
            CookieContainer cookieContainer_0 = new CookieContainer();
            WebException webException_0 = null;
            string greq = "", bearer = "", token = "", Request_For = "", response = "", errormsg = "";

            string coke1 = BodyResponse.cookie0;
            string[] array10 = coke1.Split('=');
            string coke2 = BodyResponse.cookie1;
            string[] array11 = coke2.Split('=');
            Cookie cookie1 = new Cookie(array10[0], array10[1]);
            cookie1.Domain = "www.irctc.co.in";
            cookieContainer_0.Add(cookie1);
            Cookie cookie2 = new Cookie(array11[0], array11[1]);
            cookie2.Domain = "www.irctc.co.in";
            cookieContainer_0.Add(cookie2);
            if (BodyResponse.ip != "0")
            {
                BodyResponse.AdminIP = BodyResponse.ip;
            }
            else
            {
                BodyResponse.AdminIP = "as.lunaproxy.com||12233||user-boss123-region-in||786786";
            }
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.MaxServicePoints = 10000;
            ServicePointManager.DefaultConnectionLimit = int.MaxValue;
            if (!string.IsNullOrEmpty(BodyResponse.AdminIP))
            {
                if (BodyResponse.AdminIP != "0")
                {
                    string[] array = BodyResponse.AdminIP.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
                    webProxy_0 = new WebProxy(array[0], int.Parse(array[1]));
                    webProxy_0.Credentials = new NetworkCredential(array[2], array[3]);
                }
            }
            string Host = "https://www.contents.irctc.co.in";
            greq = BodyResponse.greq; bearer = BodyResponse.authorization; token = BodyResponse.token;
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary["greq"] = greq;
            dictionary["Authorization"] = bearer;
            ServicePointManager.UseNagleAlgorithm = false;
            ServicePointManager.Expect100Continue = false;
            if (BodyResponse.id == "APP")
            {
                url = "https://www.irctc.co.in/eticketing/mbi/MobileBankResponse";
                dictionary["dss"] = token;
                IsConnt = true;
            }
            else
            {
                Host = "https://www.irctc.co.in";
                url = "https://www.irctc.co.in/eticketing/BankResponse";
                dictionary["spa-csrf-token"] = token;
            }
            string BankData = BodyResponse.Data;
            if (BankData == "")
            {
                Task<bool> task = ConnectHttp_11(url, null, reff, webProxy_0, cookieContainer_0, true, true, 10000, 10000, response, errormsg, webException_0, "Bank", greq, bearer, token, Request_For);
            }
            else
            {
                url = Host + "/eticketing/protected/mapps1/verifyPayment/" + BodyResponse.TransactionID;
                string[] array22 = Strings.Split(BankData, "&", -1, CompareMethod.Binary);
                int num3 = Information.UBound(array22, 1);
                string V = "";
                for (int i2 = 0; i2 <= num3; i2++)
                {
                    string[] array32 = Strings.Split(array22[i2], "=", -1, CompareMethod.Binary);
                    V += "{\"key\":\"" + array32[0] + "\",\"value\":\"" + array32[1] + "\"}";
                    if ((i2 + 2) <= array22.Length)
                        V += ",";
                }
                postdata = "{\"amount\":" + BodyResponse.Fare + ",\"apiName\":null,\"bankId\":" + BodyResponse.BankID + ",\"captchaDto\":null,\"errorMsg\":null,\"paramList\":[" + V + "],\"transationId\":0,\"txnStatus\":1,\"txnType\":13}";
            }
            cls020.RequestToken = response;
            cls020.status = Request_For;
            return cls020;
        }
        public cls02 AbckReponse(RequestBody BodyResponse)
        {
            string url = "";
            string postdata = "";
            string reff = "";
            WebProxy webProxy_0 = null;
            CookieContainer cookieContainer_0 = new CookieContainer();
            WebException webException_0 = null;
            string greq = "", bearer = "", token = "", Request_For = "", response = "", errormsg = "";
            greq = BodyResponse.greq; bearer = BodyResponse.authorization; token = BodyResponse.token;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            ServicePointManager.Expect100Continue = false;
            ServicePointManager.MaxServicePoints = 10000;
            ServicePointManager.DefaultConnectionLimit = int.MaxValue;
            ServicePointManager.UseNagleAlgorithm = false;
            ServicePointManager.Expect100Continue = false;

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            url = "http://www.showcap.xyz/captcha/akamai_v2?token=65036e323482aeb1620493c508dfbf08&" + Base64Decode(BodyResponse.Data);
            postdata = null;
            cls02 cls020 = new cls02();
            cls020.RequestToken = response;
            cls020.status = Request_For;
            return cls020;
        }
        public cls02 TokensReponse(RequestBody BodyResponse)
        {
            Akamai.AkamaiPhoneModel Akm = new Akamai.AkamaiPhoneModel();
            string response = "";
            for (int y = 0; y < 30; y++)
            {
                string Aw = Akm.method_0(0, "");
                Aw = EncryptRJ256("svtheklodimnhkuaaujweoldvkwpriMv", "29201912541356092122518805456500", Aw);
                response += Aw + "||##||";
            }
            cls02 cls020 = new cls02();
            cls020.RequestToken = response;
            cls020.status = "Success";
            return cls020;
        }
        public cls02 VerifyResponse(RequestBody BodyResponse)
        {
            String softid = BodyResponse.data1;
            String validaturl = "";
            string action1 = BodyResponse.data0;
            String macid = BodyResponse.data2;
            string data3 = BodyResponse.data3;
            string data4 = BodyResponse.data4;
            string errMessage = "";
            String serial = "";
            String otpid1 = "";
            String otptoken1 = "";
            String Serverid = "";
            cls02 cls020 = new cls02();
            if (action1.Contains("ProcessBank"))
            {
                // cls020.RequestToken = Bank.HDFC_DC(encdata, card, url, bank, action1, referal, otpid1, otptoken1, validaturl, ref errMessage);
            }
            else
            {
                cls020.RequestToken = ChkHistory_Mibile(action1, softid, macid, data3, data4);
            }
            cls020.status = "Success";
            return cls020;
        }

        private string TotalTimeinMili()
        {
            DateTime utcNow = DateTime.UtcNow;
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long ts = (long)((utcNow - epoch).TotalMilliseconds);
            return ts.ToString();
        }
        internal string Mobile_gen(string softid, string mac, string valurl, string token, string serverid, ref string errMessage)
        {
            string response = "", errormsg = "";
            int timeA = 60000, timeB = 60000;
            string url = "", postdata = null, reff = "";
            WebProxy webProxy_0 = null;
            WebException webException_0 = null;
            CookieContainer cookieContainer_0 = null;
            String text15 = "xngiff@gmail.com";
            String text16 = "Surya@4633";
            token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VySWQiOiI2NGM3Mjc5ZDM1MTg3NGIwN2M0ODIxNDQiLCJyb2xlIjoidXNlciIsImlhdCI6MTY5ODAwODIwMSwiZXhwIjoxNzI5NTY1ODAxfQ.E4uVSk3DYiYwi2IiRp5vTVqtGnmXcoPXwiwpwda5Yjk";
            if (string.IsNullOrEmpty(token))
            {
                url = "https://otpbackend.ap-south-1.elasticbeanstalk.com/users/login";
                postdata = "{\"email\":\"" + text15 + "\",\"password\":\"" + text16 + "\",\"flag\":\"" + "true" + "\"}";
                this.NgetHttp(url, postdata, reff, "Plain0json", false, webProxy_0, ref cookieContainer_0, true, true, timeA, timeB, ref response, ref errormsg, ref webException_0);
                string textTOKEN = response.Substring(response.IndexOf("token") + 8);
                class3_0.otptoken = textTOKEN.Substring(0, textTOKEN.IndexOf("\""));
            }
            else
            {
                class3_0.otptoken = HttpUtility.UrlEncode(token);
            }
            url = "https://otpbackend.ap-south-1.elasticbeanstalk.com/service/all-services?limit=10&page=1";
            postdata = null;
            this.class3_0.string_63Ai = "authorization#" + class3_0.otptoken;
            this.NgetHttp(url, postdata, reff, "Plainj0son", false, webProxy_0, ref cookieContainer_0, true, true, 180000, 180000, ref response, ref errormsg, ref webException_0);
            url = "https://otpbackend.ap-south-1.elasticbeanstalk.com/mobile/generate";
            String bc = "";
            String server = "";
            if (serverid == "1")
            {
                bc = "irctc";
                server = "server2";
                postdata = null;
                postdata = "{\"businessCode\":\"" + bc + "\",\"server\":\"" + server + "\"}";
            }
            else if (serverid == "2")
            {
                bc = "irc";
                server = "server3";
                postdata = null;
                postdata = "{\"businessCode\":\"" + bc + "\",\"server\":\"" + server + "\"}";
            }
            else if (serverid == "3")
            {
                bc = "irc_3";
                server = "server3";
                postdata = null;
                postdata = "{\"businessCode\":\"" + bc + "\",\"server\":\"" + server + "\"}";
            }
            else if (serverid == "4")
            {
                bc = "us";
                server = "server1";
                postdata = null;
                postdata = "{\"businessCode\":\"" + bc + "\",\"server\":\"" + server + "\"}";
            }
            else
            {
                bc = "irc";
                server = "server3";
                postdata = null;
                postdata = "{\"businessCode\":\"" + bc + "\",\"server\":\"" + server + "\"}";
            }
            this.class3_0.string_63Ai = class3_0.otptoken;
            if (mobileotphttp(url, postdata, Reffral, webProxy_0, ref cookieContainer_0, bool_63: true, bool_64: true, 60000, 60000, ref response, ref errormsg, ref webException_0, "ADDTOKEN"))
                if (response.Contains("Mobile Number Successfully Generated"))
                {
                    string otpmobile = response.Substring(response.IndexOf("mobileno") + 14);
                    class3_0.otpmobile = otpmobile.Substring(0, otpmobile.IndexOf("\""));
                    string serialNumber = response.Substring(response.IndexOf("serialNumber") + 15);
                    class3_0.otpserial = serialNumber.Substring(0, serialNumber.IndexOf("\""));
                    string otpid = response.Substring(response.IndexOf("_id") + 6);
                    class3_0.otpid = otpid.Substring(0, otpid.IndexOf("\""));
                    if (class3_0.otpmobile.Length > 9)
                    {
                        return class3_0.otpmobile + "||" + class3_0.otpserial + "||" + class3_0.otpid + "||" + class3_0.otptoken;
                    }
                }
            return response;
        }

        internal string ChkMobile_Message(string serial, string otpid, string otptoken, string serverid, ref string errMessage)
        {
            String Result = "";
            string response = "", errormsg = "";
            string url = "", postdata = null;
            WebProxy webProxy_0 = null;
            WebException webException_0 = null;
            CookieContainer cookieContainer_0 = null;
            String bc = "";
            String server = "";
            if (serverid == "1")
            {
                bc = "irctc";
                server = "server2";
            }
            else if (serverid == "2")
            {
                bc = "irc";
                server = "server3";
            }
            else if (serverid == "3")
            {
                bc = "irc_3";
                server = "server3";
            }
            else if (serverid == "4")
            {
                bc = "us";
                server = "server1";
            }
            else
            {
                bc = "irc";
                server = "server3";
            }
            int ii = 0;
            otptoken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VySWQiOiI2NGM3Mjc5ZDM1MTg3NGIwN2M0ODIxNDQiLCJyb2xlIjoidXNlciIsImlhdCI6MTY5ODAwODIwMSwiZXhwIjoxNzI5NTY1ODAxfQ.E4uVSk3DYiYwi2IiRp5vTVqtGnmXcoPXwiwpwda5Yjk";
            postdata = "{\"serialNumber\":\"" + serial + "\",\"mobileId\":\"" + otpid + "\",\"businessCode\":\"" + bc + "\",\"server\":\"" + server + "\",\"resend\":" + "false" + "}";
            url = "https://otpbackend.ap-south-1.elasticbeanstalk.com/otp/generate";
            this.class3_0.string_63Ai = otptoken;
            if (!mobileotphttp(url, postdata, Reffral, webProxy_0, ref cookieContainer_0, bool_63: true, bool_64: true, 60000, 60000, ref response, ref errormsg, ref webException_0, "ADDTOKEN"))
            {
                return "Fail";
            }
            Result = response;
            return Result;
        }
        internal string ChkHistory_Mibile(string action1, string softid, string mac, string data3, string data4)
        {
            try
            {
                string response = "";
                class3_0 = new ReadyPost();
                string Host = "https://www.irctc.co.in";
                string VT = "";
                int num1 = DateTime.Now.Hour * 10000;
                int num2 = DateTime.Now.Minute * 100;
                int num3 = num1 + num2;
                int second = DateTime.Now.Second;
                long num4 = (long)(num3 + second);
                Host = "https://www.irctc.co.in";
                string Profile = "", add = "";
                add = Host;
                String mobile = "";
                if (action1.Contains("DISHA"))
                {
                    return mobile = FetchMail(data3, data4);
                }
                if (action1.Contains("FREECHARGE1"))
                {
                    return mobile = FREECHARGE1(data3, data4);
                }
                if (action1.Contains("FREECHARGE2"))
                {
                    return mobile = FREECHARGE2(data3, data4);
                }
                if (action1.Contains("TESLATOKEN"))
                {
                    return mobile = TSLATOKEN(softid, mac, data4);
                }
                if (action1.Contains("NPCIUPI1"))
                {
                    return mobile = NPCIUPI1(data3, data4);
                }
                if (action1.Contains("NPCIUPI2"))
                {
                    return mobile = NPCIUPI2(data3, data4);
                }
                if (action1.Contains("NPCIUPI3"))
                {
                    //return mobile = NPCIUPI3("", userid, pwd, otpid, token);
                }
                if (action1.Contains("GETMAILID"))
                {
                    return mobile = GETMAILID(data3);
                }
                if (action1.Contains("GETMAILMESSAGE"))
                {
                    return mobile = GETMAILMESSAGE(data3);
                }
                if (action1.Contains("DISHA"))
                {
                    return mobile = FetchMail(data3, data4);
                }
                if (action1.Contains("MESSAGE"))
                {
                    string[] array11 = softid.Split(new string[]
                    {
                        "@"
                    }, StringSplitOptions.RemoveEmptyEntries);
                    class3_0.email = array11[0];
                    class3_0.domain = array11[1];
                    //return mobile = getmess(class3_0.email, class3_0.domain, Int32.Parse(serial));
                }
                bool flag16 = false;
                if (action1.Contains("GetMobile"))
                {
                   // return mobile = Mobile_gen(softid, mac, valurl, token, Serverid, ref errMessage);
                }
                else if (action1.Contains("GetMessage"))
                {
                   // return mobile = ChkMobile_Message(serial, otpid, token, Serverid, ref errMessage);
                }
                else if (action1.Contains("ProcessBankipay"))
                {
                    String text25 = "";
                    String string_92 = "";
                    String text27 = "";
                    String text8 = "";
                    String string_95 = "";
                    string text34 = text25.ToUpper().Trim();
                    smethod_0(text34);
                    bool flag = class3_0.LoginType == "WEB";
                    bool flag2 = false;
                    string_90 = "";
                    string_91 = "";
                    string_88 = string_88.ToUpper();
                    string_72 = "";
                    response = string_86;
                    string text = string_88;
                    string[] array = string_87.Split(new string[1] { "||" }, StringSplitOptions.None);
                    string text2 = array[0].Trim();
                    string text3 = array[1];
                    string text4 = "";
                    string text5 = "";
                    string str = "";
                    string string_93 = "";
                    string string_94 = "";
                    string text6 = "";
                    string text7;
                    if (string_88.Contains("_DC") || string_88.Contains("_CC"))
                    {
                    }
                }
                Profile = response;
                return "";
            }
            catch (Exception ex)
            {
                return "Error@Exception";
            }
        }
        internal static uint smethod_0(string string_0)
        {
            uint num = 0u;
            if (string_0 != null)
            {
                num = 2166136261u;
                for (int i = 0; i < string_0.Length; i++)
                {
                    num = (string_0[i] ^ num) * 16777619;
                }
            }
            return num;
        }

        public static string jsonData_Serial(string str, string what)
        {
            string str4 = "";
            try
            {
                int num = str.IndexOf("\"" + what + "\"", StringComparison.CurrentCultureIgnoreCase);
                string A_3 = str.Substring(num);
                A_3 = A_3.Substring(A_3.IndexOf(":\"") + 2);
                str4 = A_3.Substring(0, A_3.IndexOf("\""));
                return str4;
            }
            catch { }
            return str4;
        }
        internal string ChkMobile_OTP(int userID)
        {
            string response = "", errormsg = "";
            int timeA = 60000, timeB = 60000;
            string Profile = "", url = "", postdata = null, reff = "";
            WebProxy webProxy_0 = null;
            WebException webException_0 = null;
            CookieContainer cookieContainer_0 = null;
            int ii = 0;
            String text15 = "xngiff@gmail.com";
            String text16 = "Surya@4633";
            url = "https://otpbackend.ap-south-1.elasticbeanstalk.com/users/login";
            postdata = "{\"email\":\"" + text15 + "\",\"password\":\"" + text16 + "\",\"flag\":\"" + "true" + "\"}";
            this.NgetHttp(url, postdata, reff, "Plain0json", false, webProxy_0, ref cookieContainer_0, true, true, timeA, timeB, ref response, ref errormsg, ref webException_0);
            string textTOKEN = response.Substring(response.IndexOf("token") + 8);
            class3_0.otptoken = textTOKEN.Substring(0, textTOKEN.IndexOf("\""));
            url = "https://otpbackend.ap-south-1.elasticbeanstalk.com/service/all-services?limit=10&page=1";
            postdata = null;
            this.class3_0.string_63Ai = "authorization#" + class3_0.otptoken;
            this.NgetHttp(url, postdata, reff, "Plainj0son", false, webProxy_0, ref cookieContainer_0, true, true, timeA, timeB, ref response, ref errormsg, ref webException_0);
            url = "https://otpbackend.ap-south-1.elasticbeanstalk.com/mobile/generate";
            postdata = null;
            postdata = "{\"businessCode\":\"" + "10151" + "\"}";
            this.class3_0.string_63Ai = "authorization#" + class3_0.otptoken;
            this.NgetHttp(url, postdata, reff, "Plain0json", false, webProxy_0, ref cookieContainer_0, true, true, timeA, timeB, ref response, ref errormsg, ref webException_0);
            if (response.Contains("Mobile Number Successfully Generated"))
            {
                string otpmobile = response.Substring(response.IndexOf("mobileno") + 14);
                class3_0.otpmobile = otpmobile.Substring(0, otpmobile.IndexOf("\""));
                string serialNumber = response.Substring(response.IndexOf("serialNumber") + 15);
                class3_0.otpserial = serialNumber.Substring(0, serialNumber.IndexOf("\""));
                string otpid = response.Substring(response.IndexOf("_id") + 6);
                class3_0.otpid = otpid.Substring(0, otpid.IndexOf("\""));
                if (class3_0.otpmobile.Length > 9)
                {
                    return class3_0.otpmobile + "||" + class3_0.otpserial + "||" + class3_0.otpid + "||" + class3_0.otptoken;
                }
            }
            return "retry";
        }
        private string method_1(string string_0, string string_1, string string_2)
        {
            string result;
            try
            {
                int num = string_1.Length + 2;
                string text = string_0.Substring(string_0.IndexOf(string_1) + num);
                result = text.Substring(0, text.IndexOf(string_2));
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            return result;
        }
        private bool web_httpRequest(string _url, string _deta, string _reff, string _type, int SLOT, bool bool_63, ref WebProxy webProxy_5, ref CookieContainer cookieContainer_2, bool bool_64, bool bool_65, int int_28, int int_29, ref string _response, ref string _error, ref WebException webException_1)
        {
            int num = 0;
            bool flag = bool_21;
            if (bool_21)
            {
                bool_21 = false;
            }
            dateTime_0 = DateTime.Now;
            bool result;
            while (true)
            {
                result = false;
                bool flag2 = false;
                bool flag3 = false;
                num++;
                if (_url.Contains("bookingData") & isPremium_p)
                {
                    _url = _url.Replace("bookingData", "verifyPayment");
                }
                long_0 = long_1;
                new Stopwatch().Start();
                _error = "";
                _response = "";
                string text = "";
                webException_1 = null;
                HttpWebResponse httpWebResponse = null;
                string text2 = "";
                try
                {
                    new Uri(_url);
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(_url);
                    if (_url.Contains("verifyPayment") & isPremium_p)
                    {
                        httpWebRequest.ClientCertificates = x509Certificate2Collection_0;
                    }
                    new HttpRequestCachePolicy(HttpRequestCacheLevel.Default);
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    httpWebRequest.ServerCertificateValidationCallback = CheckCertificate11;
                    ServicePointManager.Expect100Continue = false;
                    httpWebRequest.ProtocolVersion = HttpVersion.Version11;
                    httpWebRequest.Proxy = webProxy_5;
                    httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                    httpWebRequest.ConnectionGroupName = ConnectionGroupName_;
                    HttpRequestCachePolicy cachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
                    new HttpRequestCachePolicy(HttpCacheAgeControl.MaxAge, TimeSpan.FromDays(0.0));
                    httpWebRequest.CachePolicy = cachePolicy;
                    if (int_28 > 0)
                    {
                        httpWebRequest.Timeout = int_28;
                    }
                    if (int_29 > 0)
                    {
                        httpWebRequest.ReadWriteTimeout = int_29;
                    }
                    httpWebRequest.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, */*";
                    httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                    httpWebRequest.KeepAlive = true;
                    httpWebRequest.Connection = "keepalive";
                    httpWebRequest.AllowAutoRedirect = false;
                    httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36";
                    httpWebRequest.Headers.Add("Accept-Language", "en-US,en;q=0.9,hi;q=0.8");
                    if (_url.ToLower().Contains("irctc.co.in"))
                    {
                        httpWebRequest.AllowWriteStreamBuffering = false;
                        httpWebRequest.Headers.Add("bmirak", "webbm");
                    }
                    if (!string.IsNullOrEmpty(bmiyek))
                    {
                        httpWebRequest.Headers.Add("bmiyek", bmiyek);
                    }
                    if (flag)
                    {
                        httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                        if (webProxy_5 != null)
                        {
                            httpWebRequest.Headers.Add("Cache-Control", "no-cache");
                            httpWebRequest.Headers.Add("Pragma", "no-cache");
                        }
                        bool_21 = false;
                    }
                    if (cookieContainer_2 == null)
                    {
                        cookieContainer_2 = new CookieContainer();
                    }
                    httpWebRequest.CookieContainer = cookieContainer_2;
                    if (_type.Contains("Plain"))
                    {
                        httpWebRequest.Accept = "application/json, text/plain, */*";
                    }
                    else if (_type.Contains("text"))
                    {
                        httpWebRequest.Accept = "text/plain";
                    }
                    else if (_type.Contains("Java"))
                    {
                        httpWebRequest.Accept = "application/json";
                    }
                    if (_type.Contains("1") && !string.IsNullOrEmpty(class3_0._greq))
                    {
                        httpWebRequest.Headers.Add("greq", class3_0._greq);
                    }
                    if (_type.Contains("2"))
                    {
                        httpWebRequest.Headers.Add("spa-csrf-token", class3_0.token);
                    }
                    if (_type.Contains("3"))
                    {
                        httpWebRequest.Headers.Add("Authorization", class3_0._Authorization);
                    }
                    if (_type.Contains("Final"))
                    {
                        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                    }
                    else if (_type.Contains("text"))
                    {
                        httpWebRequest.ContentType = "text/plain";
                    }
                    else if (_type.Contains("json"))
                    {
                        httpWebRequest.ContentType = "application/json; charset=UTF-8";
                    }
                    else
                    {
                        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                    }
                    if (!string.IsNullOrEmpty(string_70))
                    {
                        string value = string_70;
                        string_70 = null;
                        httpWebRequest.Headers.Add("lso", value);
                        string_70 = null;
                    }
                    if (bool_0)
                    {
                        bool_0 = false;
                        httpWebRequest.Headers.Add("authority", "www.google.com");
                        httpWebRequest.Accept = "*/*";
                        httpWebRequest.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
                        httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36";
                        if (!string.IsNullOrEmpty(string_64))
                        {
                            httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/" + string_64 + " Safari/537.36";
                        }
                        httpWebRequest.Headers.Add("Accept-Language", "en-US,en;q=0.9");
                        httpWebRequest.Headers.Add("origin", "https://www.google.com");
                        httpWebRequest.Headers.Add("sec-fetch-dest", "empty");
                        httpWebRequest.Headers.Add("sec-fetch-mode", "cors");
                        httpWebRequest.Headers.Add("sec-fetch-site", "same-origin");
                        httpWebRequest.Headers.Add("x-client-data", "CKG1yQEIjrbJAQimtskBCMG2yQEIqZ3KAQi3uMoBCKzHygEI9cfKAQjnyMoBCOnIygEItMvKAQiNz8oBCNvVygEYisHKAQ==");
                    }
                    if (_url == "https://www.irctc.co.in/eticketing/PaymentRedirect")
                    {
                        httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
                        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                        httpWebRequest.Headers.Add("accept-encoding", "gzip, deflate, br, zstd");
                        httpWebRequest.Headers.Add("Accept-Language", "en-US,en;q=0.9");
                        httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7";
                        RequestCachePolicy requestCachePolicy5 = (httpWebRequest.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore));
                        RequestCachePolicy requestCachePolicy2 = requestCachePolicy5;
                        RequestCachePolicy requestCachePolicy3 = requestCachePolicy2;
                        HttpRequestCachePolicy httpRequestCachePolicy = (HttpRequestCachePolicy)requestCachePolicy3;
                    }
                    if (_url == "https://www.irctc.co.in/eticketing/BankResponse")
                    {
                        httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
                        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                        if (_reff == "https://www.irctcipay.com/")
                        {
                            httpWebRequest.Headers.Add("Origin", "https://www.irctcipay.com");
                        }
                        httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                        RequestCachePolicy requestCachePolicy5 = (httpWebRequest.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore));
                        RequestCachePolicy requestCachePolicy2 = requestCachePolicy5;
                        RequestCachePolicy requestCachePolicy3 = requestCachePolicy2;
                        HttpRequestCachePolicy httpRequestCachePolicy = (HttpRequestCachePolicy)requestCachePolicy3;
                    }
                    if (_url.Contains("https://www.irctc.co.in/eticketing/protected/mapps1/signupUser"))
                    {
                        httpWebRequest.Headers.Add("Bmiyek", "B0E30C1A6A07518591AD2E4A438F40CE");
                        httpWebRequest.ContentType = "application/json; charset=UTF-8";
                        httpWebRequest.Accept = "application/json, text/plain, *";
                        httpWebRequest.Headers.Add("Content-Language", "en");
                    }
                    if (_url.Contains("https://www.irctc.co.in/eticketing/protected/mapps1/signupVerification"))
                    {
                        httpWebRequest.Headers.Add("Bmiyek", "299C5BFB1D694DD74E88FA50D87C4879");
                        httpWebRequest.ContentType = "application/json; charset=UTF-8";
                        httpWebRequest.Accept = "application/json, text/plain, */*";
                        httpWebRequest.Headers.Add("Content-Language", "en");
                    }
                    if (!string.IsNullOrEmpty(_reff))
                    {
                        httpWebRequest.Referer = _reff;
                    }
                    if (!string.IsNullOrEmpty(_deta))
                    {
                        httpWebRequest.Method = "POST";
                        byte[] bytes = Encoding.UTF8.GetBytes(_deta);
                        httpWebRequest.ContentLength = bytes.Length;
                        httpWebRequest.GetRequestStream().Write(bytes, 0, bytes.Length);
                    }
                    else
                    {
                        httpWebRequest.Method = "GET";
                    }
                    httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    switch (httpWebResponse.StatusCode)
                    {
                        case HttpStatusCode.MovedPermanently:
                        case HttpStatusCode.Found:
                        case HttpStatusCode.SeeOther:
                        case HttpStatusCode.TemporaryRedirect:
                            text2 = httpWebResponse.GetResponseHeader("Location");
                            if (text2.IndexOf("https://") == 0)
                            {
                                if (num >= 4 || text2.IndexOf("booking-confirm") > 0)
                                {
                                    break;
                                }
                                httpWebResponse.Close();
                                httpWebResponse = null;
                                _url = text2;
                                _deta = "";
                            }
                            else
                            {
                                if (text2.IndexOf("/") != 0 || num >= 4)
                                {
                                    break;
                                }
                                httpWebResponse.Close();
                                httpWebResponse = null;
                                int num2 = text2.IndexOf("/") + 1;
                                int num3 = text2.IndexOf("/", num2);
                                string value2 = text2.Substring(num2, num3 - num2);
                                _url = _url.Substring(0, _url.IndexOf(value2) - 1) + text2;
                                _deta = "";
                            }
                            goto end_IL_00bd;
                        case HttpStatusCode.NotModified:
                        case HttpStatusCode.UseProxy:
                        case HttpStatusCode.Unused:
                            text2 = "retry";
                            break;
                        default:
                            {
                                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                                {
                                    text2 = streamReader.ReadToEnd();
                                }
                                break;
                            }
                    }
                    if (httpWebResponse.Headers["csrf-token"] != null)
                    {
                        class3_0.token = httpWebResponse.Headers["csrf-token"];
                    }
                    _response = text2;
                    flag3 = true;
                    result = true;
                    if (string.IsNullOrEmpty(_response))
                    {
                        if (_url.Contains("avlFareenquiry"))
                        {
                            class3_0.bool_13 = true;
                        }
                        _response = "retry";
                    }
                    if (_url.Contains("avlFareenquiry") && _response.Contains("Unable to process your request"))
                    {
                        class3_0.bool_13 = true;
                    }
                    if (string.IsNullOrEmpty(_response))
                    {
                    }
                    if (_response.Contains("Unable to serve this request") || response.Contains("This site is currently unreachable."))
                    {
                        continue;
                    }
                    goto IL_0d9a;
                end_IL_00bd:;
                }
                catch (WebException ex)
                {
                    WebException ex2 = (webException_1 = ex);
                    string text3 = "";
                    HttpStatusCode httpStatusCode = HttpStatusCode.OK;
                    if (ex2.Response != null)
                    {
                        try
                        {
                            if (ex2.Response.Headers["csrf-token"] != null)
                            {
                                class3_0.token = ex2.Response.Headers["csrf-token"];
                            }
                            text3 = (_response = ":" + new StreamReader(ex2.Response.GetResponseStream()).ReadToEnd());
                        }
                        catch
                        {
                        }
                        httpStatusCode = ((HttpWebResponse)ex2.Response).StatusCode;
                    }
                    _error = "<StatusCode>" + httpStatusCode.ToString() + "</StatusCode>\t<ErrorCode>" + ex2.Message + "</ErrorCode>\t<ResponseCode>" + text3 + "</ResponseCode>";
                    if (_error.Contains("DOWNTIME MESSAGE"))
                    {
                        _response = _error;
                        return true;
                    }
                    if (_error.Contains("The remote server returned an error: (407) Proxy Authentication Required") | _error.Contains("The server committed a protocol violation") | _error.Contains("The remote name could not be resolved:") | _error.Contains("This site can’t be reached") | _error.Contains("The operation has timed out") | _error.Contains("Unable to connect to") | _error.Contains("The remote server returned an error: (410) Gone") | _error.Contains("This site is currently unreachable") | _error.Contains("The remote server returned an error: (403) Forbidden"))
                    {
                        continue;
                    }
                    if (_error.Contains("INVALID REQUEST") | _error.Contains("The remote name could not be resolved:") | _error.Contains("This site can’t be reached") | _error.Contains("The operation has timed out") | _error.Contains("Unable to connect to the remote server"))
                    {
                        return result;
                    }
                    flag2 = true;
                    if (!_error.Contains("Unable to connect to the remote server"))
                    {
                        if (_error.Contains("The underlying connection was closed:"))
                        {
                            if (_error.Contains("An unexpected error occurred on a send"))
                            {
                                string_52 = "Tls12";
                                if (num < 5)
                                {
                                    Thread.Sleep(400);
                                }
                                else
                                {
                                    flag3 = true;
                                }
                            }
                            else if (_error.Contains("A connection that was expected to be kept alive was closed by the server") || _error.Contains("An unexpected error occurred on a receive"))
                            {
                                Thread.Sleep(5000);
                                _response = "";
                                _error = "A connection that was expected to be kept alive was closed by the server";
                                flag3 = true;
                            }
                        }
                        else if (_error.Contains("The request was aborted: Could not create SSL/TLS secure channel."))
                        {
                            string_52 = "Tls12";
                            if (num < 5)
                            {
                                Thread.Sleep(400);
                            }
                            else
                            {
                                flag3 = true;
                            }
                        }
                        else if (_error.Contains("(406) Not Acceptable") | _error.Contains("(401) Unauthorized"))
                        {
                            flag3 = true;
                        }
                        else if (_error.Contains("(404) Not Found") | _error.Contains("(409) Conflict"))
                        {
                            flag3 = true;
                        }
                        else if (_error.Contains("(400) Bad Request"))
                        {
                            flag3 = true;
                            text = ex2.Response.Headers["csrf-token"];
                        }
                        if (_error.Contains("Server error") || _error.Contains("Bad Gateway"))
                        {
                            _error = "retry";
                            continue;
                        }
                        else if (_error.Contains("(500) Internal Server Error"))
                        {
                            if (num <= 6)
                            {
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                flag3 = true;
                            }
                        }
                        else if (_error.Contains("(502) Bad Gateway"))
                        {
                            if (num <= 6)
                            {
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                flag3 = true;
                            }
                        }
                        else if (_error.Contains("(503) Server Unavailable"))
                        {
                            Thread.Sleep(1000);
                            _response = "";
                            _error = "A connection that was expected to be kept alive was closed by the server";
                            flag3 = true;
                        }
                        else if (_error.Contains("(504) Gateway Timeout"))
                        {
                            if (num < 6)
                            {
                                Thread.Sleep(1000);
                            }
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            _response = "";
                            _error = "A connection that was expected to be kept alive was closed by the server";
                            flag3 = true;
                        }
                        goto IL_0d9a;
                    }
                }
                catch (Exception ex3)
                {
                    _error = ex3.Message;
                    if (num > 2)
                    {
                        flag3 = true;
                    }
                    goto IL_0d9a;
                }
                finally
                {
                    try
                    {
                        httpWebResponse?.Close();
                    }
                    catch
                    {
                    }
                }
                goto IL_0d7f;
            IL_0d7f:
                if (!bool_63 && !flag2)
                {
                    return result;
                }
                continue;
            IL_0d9a:
                if (!string.IsNullOrEmpty(text))
                {
                    class3_0.token = text;
                }
                if (flag3)
                {
                    break;
                }
                if (num <= 3)
                {
                }
                goto IL_0d7f;
            }
            return result;
        }
        private bool CheckCertificate11(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true; ;
        }
        internal static string smethod_5_n()
        {
            string result = "";
            try
            {
                byte[] array = new byte[(long)intptr_0];
                ((RandomNumberGenerator)object_28).GetBytes(array);
                return bytesToHexString(array);
            }
            catch
            {
                return result;
            }
        }
        public static string bytesToHexString(byte[] bArr)
        {
            char[] array = new char[bArr.Length * 2];
            for (int i = 0; i < bArr.Length; i++)
            {
                int num = bArr[i] & 0xFF;
                array[i * 2] = hexArray[num >> 4];
                array[i * 2 + 1] = hexArray[num & 0xF];
            }
            return new string(array);
        }
        public static string Decrypt(byte[] ciphertext, byte[] key)
        {
            try
            {
                PaddedBufferedBlockCipher paddedBufferedBlockCipher = new PaddedBufferedBlockCipher(new SerpentEngine(), new Pkcs7Padding());
                paddedBufferedBlockCipher.Init(forEncryption: false, new KeyParameter(key));
                byte[] array2 = new byte[paddedBufferedBlockCipher.GetOutputSize(ciphertext.Length)];
                int num2 = paddedBufferedBlockCipher.ProcessBytes(ciphertext, 0, ciphertext.Length, array2, 0);
                num2 += paddedBufferedBlockCipher.DoFinal(array2, num2);
                return Encoding.UTF8.GetString(array2, 0, num2);
            }
            catch
            {
                return "old";
            }
        }
        public static byte[] FromBase32String(string encoded)
        {
            if (encoded == null)
                throw new ArgumentNullException("encoded");
            encoded = encoded.Trim().TrimEnd('=').ToUpper();
            if (encoded.Length == 0)
                return new byte[0];
            byte[] array = new byte[encoded.Length * 5 / 8];
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            string text = encoded;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                int num5 = CharToInt(c);
                if (num5 < 0)
                    throw new FormatException("Illegal character: `" + c + "`");
                num2 = (num2 << 5) | (num5 & 0x1F);
                num4 += 5;
                if (num4 >= 8)
                {
                    array[num3++] = (byte)(num2 >> num4 - 8);
                    num4 -= 8;
                }
            }
            return array;
        }
        private static int CharToInt(char c)
        {
            switch (c)
            {
                case '2':
                    return 26;
                case '3':
                    return 27;
                case '4':
                    return 28;
                case '5':
                    return 29;
                case '6':
                    return 30;
                case '7':
                    return 31;
                case 'A':
                    return 0;
                case 'B':
                    return 1;
                case 'C':
                    return 2;
                case 'D':
                    return 3;
                case 'E':
                    return 4;
                case 'F':
                    return 5;
                case 'G':
                    return 6;
                case 'H':
                    return 7;
                case 'I':
                    return 8;
                case 'J':
                    return 9;
                case 'K':
                    return 10;
                case 'L':
                    return 11;
                case 'M':
                    return 12;
                case 'N':
                    return 13;
                case 'O':
                    return 14;
                case 'P':
                    return 15;
                case 'Q':
                    return 16;
                case 'R':
                    return 17;
                case 'S':
                    return 18;
                case 'T':
                    return 19;
                case 'U':
                    return 20;
                case 'V':
                    return 21;
                case 'W':
                    return 22;
                case 'X':
                    return 23;
                case 'Y':
                    return 24;
                case 'Z':
                    return 25;
                default:
                    return -1;
            }
        }
        public static string decryption(string data)
        {
            string result;
            if (string.IsNullOrEmpty(data))
                result = "";
            else
                try
                {
                    using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt))
                    {
                        byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
                        rfc2898DeriveBytes.GetBytes(16);
                        if (Decrypt(FromBase32String(data), bytes) == "old")
                            try
                            {
                                using (Rfc2898DeriveBytes rfc2898DeriveBytes2 = new Rfc2898DeriveBytes("1Ptzt'l$%}NT(kSEx]{1xN.8a6@1YXga^W!M]}~9qbs~8v8Za^", Encoding.ASCII.GetBytes("GXG55344CYK3KGLJLOHDMAMSKC5D8E7Q")))
                                {
                                    byte[] bytes2 = rfc2898DeriveBytes2.GetBytes(32);
                                    rfc2898DeriveBytes2.GetBytes(16);
                                    return Decrypt(FromBase32String(data), bytes2);
                                }
                            }
                            catch
                            {
                                return "";
                            }
                        result = Decrypt(FromBase32String(data), bytes);
                    }
                }
                catch
                {
                    try
                    {
                        using (Rfc2898DeriveBytes rfc2898DeriveBytes3 = new Rfc2898DeriveBytes("1Ptzt'l$%}NT(kSEx]{1xN.8a6@1YXga^W!M]}~9qbs~8v8Za^", Encoding.ASCII.GetBytes("GXG55344CYK3KGLJLOHDMAMSKC5D8E7Q")))
                        {
                            byte[] bytes3 = rfc2898DeriveBytes3.GetBytes(32);
                            rfc2898DeriveBytes3.GetBytes(16);
                            result = Decrypt(FromBase32String(data), bytes3);
                        }
                    }
                    catch
                    {
                        result = "";
                    }
                }
            return result;
        }
        private string dishaocr(string base64)
        {
            try
            {
                string address = "https://mobile.taslatss.com/home/importantdataNew";
                string data = "base64=" + HttpUtility.UrlEncode(base64);
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    return webClient.UploadString(address, data);
                }
            }
            catch
            {
                return "1234";
            }
        }
        public string newencryption(string data)
        {
            string result = "";
            if (data.Length > 0)
            {
                using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt))
                {
                    byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
                    rfc2898DeriveBytes.GetBytes(16);
                    return ToBase32String(Encryptt(data, bytes));
                }
            }
            return result;
        }

        public static string ToBase32String(byte[] data, bool padOutput = false)
        {
            return ToBase32String(data, 0, data.Length, padOutput);
        }

        public static string ToBase32String(byte[] data, int offset, int length, bool padOutput = false)
        {
            if (data == null)
                throw new ArgumentNullException("data");
            if (offset < 0)
                throw new ArgumentOutOfRangeException("offset");
            if (length < 0)
                throw new ArgumentOutOfRangeException("length");
            if (offset + length > data.Length)
                throw new ArgumentOutOfRangeException();
            if (length == 0)
                return "";
            if (length >= 268435456)
                throw new ArgumentOutOfRangeException("data");
            StringBuilder stringBuilder = new StringBuilder((length * 8 + 5 - 1) / 5);
            int num = offset + length;
            int num2 = data[offset++];
            int num3 = 8;
            while (num3 > 0 || offset < num)
            {
                if (num3 < 5)
                {
                    if (offset < num)
                    {
                        num2 = (num2 << 8) | (data[offset++] & 0xFF);
                        num3 += 8;
                    }
                    else
                    {
                        int num4 = 5 - num3;
                        num2 <<= num4;
                        num3 += num4;
                    }
                }
                int num5 = 0x1F & (num2 >> num3 - 5);
                num3 -= 5;
                stringBuilder.Append(_digits[num5]);
            }
            if (padOutput)
            {
                int num6 = 8 - stringBuilder.Length % 8;
                if (num6 > 0)
                    stringBuilder.Append('=', (num6 != 8) ? num6 : 0);
            }
            return stringBuilder.ToString();
        }
        public static byte[] Encryptt(string plaintext, byte[] key)
        {
            PaddedBufferedBlockCipher paddedBufferedBlockCipher = new PaddedBufferedBlockCipher(new SerpentEngine(), new Pkcs7Padding());
            byte[] bytes = Encoding.UTF8.GetBytes(plaintext);
            paddedBufferedBlockCipher.Init(forEncryption: true, new KeyParameter(key));
            byte[] array = new byte[paddedBufferedBlockCipher.GetOutputSize(bytes.Length)];
            int num = paddedBufferedBlockCipher.ProcessBytes(bytes, 0, bytes.Length, array, 0);
            num += paddedBufferedBlockCipher.DoFinal(array, num);
            byte[] array2 = new byte[num];
            Array.Copy(array, 0, array2, 0, num);
            return array2;
        }
        private string FREECHARGE1(string phoneNumber, string pub_key)
        {
            string[] array4 = decryption(dishaocr(newencryption(pub_key + "|||" + phoneNumber))).Split(new string[1] { "|||" }, StringSplitOptions.None);
            string encmob = array4[0];
            string cske = array4[1];
            string upiact = array4[2];
            string smspart = array4[2].Replace("UPIACT ", "");
            string checksum = array4[3];
            string result = "";
            result = encmob + "||" + cske + "||" + upiact + "||" + checksum;
            //result = EncryptDataWithAes(result);
            return result;
        }
        private string dishaocrchecksum(string base64)
        {
            try
            {
                string address = "https://mobile.taslatss.com/home/fcnewupdate";
                string data = "base64=" + HttpUtility.UrlEncode(base64);
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                    return webClient.UploadString(address, data);
                }
            }
            catch
            {
                return "1234";
            }
        }
        private string FREECHARGE2(string phoneNumber, string pub_key)
        {
            string result = "";
            string d1 = newencryption(pub_key);
            string d2 = dishaocrchecksum(d1);
            string d3 = decryption(d2);
            string[] array = d3.Split(new string[1] { "|||" }, StringSplitOptions.None);
            string checks = array[0];
            string cskk = array[1];
            string cskk11 = array[1];
            result = checks + "||" + cskk + "||" + cskk11;
            //result = EncryptDataWithAes(result);
            return result;
        }
        public static string Decryption(string data)
        {
            string result;
            if (string.IsNullOrEmpty(data))
                result = "";
            else
                try
                {
                    using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt))
                    {
                        byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
                        rfc2898DeriveBytes.GetBytes(16);
                        if (Decrypt(FromBase32String(data), bytes) == "old")
                            try
                            {
                                using (Rfc2898DeriveBytes rfc2898DeriveBytes2 = new Rfc2898DeriveBytes("1Ptzt'l$%}NT(kSEx]{1xN.8a6@1YXga^W!M]}~9qbs~8v8Za^", Encoding.ASCII.GetBytes("GXG55344CYK3KGLJLOHDMAMSKC5D8E7Q")))
                                {
                                    byte[] bytes2 = rfc2898DeriveBytes2.GetBytes(32);
                                    rfc2898DeriveBytes2.GetBytes(16);
                                    return Decrypt(FromBase32String(data), bytes2);
                                }
                            }
                            catch
                            {
                                return "";
                            }
                        result = Decrypt(FromBase32String(data), bytes);
                    }
                }
                catch
                {
                    try
                    {
                        using (Rfc2898DeriveBytes rfc2898DeriveBytes3 = new Rfc2898DeriveBytes("1Ptzt'l$%}NT(kSEx]{1xN.8a6@1YXga^W!M]}~9qbs~8v8Za^", Encoding.ASCII.GetBytes("GXG55344CYK3KGLJLOHDMAMSKC5D8E7Q")))
                        {
                            byte[] bytes3 = rfc2898DeriveBytes3.GetBytes(32);
                            rfc2898DeriveBytes3.GetBytes(16);
                            result = Decrypt(FromBase32String(data), bytes3);
                        }
                    }
                    catch
                    {
                        result = "";
                    }
                }
            return result;
        }
        private static bool smethod_15(object object_40, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
        {
            int num;
            for (num = 1146480788; num <= 1146482383; num = 124 + (183 + num))
            {
            }
            Debug.Assert((byte)(0x4455EFC7 ^ num) != 0);
            if ((0x4455EFC7 ^ num) == 0 || (0x4455EFC6 ^ num) == 0)
            {
            }
            int num2 = -1146482629 ^ num;
            if (((-1512821939 - num) ^ (1963291541 - num)) == -1775785970 - num)
            {
                num2 += 4;
            }
            return (byte)num2 != 0;
        }
        private string TSLATOKEN(string teslaid, string mac, string data4)
        {
            string result = "";
            int i = 0;
            string path = "";
            string HostUri1 = "";
            string text = "";
            string text2 = string.Empty;
            string turl = "https://raw.githubusercontent.com/taslats/TaslaX/main/APKURL.txt";
            try
            {
                string turl11 = "https://hitmanxxx.com/Hitman/teslaid";
                using (WebClient webClient11 = new WebClient())
                {
                    webClient11.Headers.Add(HttpRequestHeader.UserAgent, "My appp");
                    webClient11.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                    NameValueCollection postData = new NameValueCollection();
                    postData["userid"] = teslaid;
                    postData["username"] = data4;
                    postData["macaddress"] = mac;
                    byte[] responseBytes = webClient11.UploadValues(turl11, "POST", postData);
                    string text11 = Encoding.UTF8.GetString(responseBytes);
                    if(text11.Contains("invalid user"))
                    {
                        return null;
                    }
                }
                List<string> list = new List<string>();
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.Headers.Add(HttpRequestHeader.UserAgent, "My appp");
                    text = webClient.DownloadString(new Uri(turl));
                    webClient.Dispose();
                   // text = "YRNAKR6G2N75EK53E7L5DM7YM66BUU64D4EJQQAQZ7VWP3HSMX35CAZXHONMA3IZZKOSME3FLAMZX5U6NZ6U7GQ6DXXVUKXPO4JGXZSKSGJZV3N7VOUSOJRNICSGFG4DBCBMIL56USPPQ5SW62DAOYCPMKXRE63PMG3XBHL6SYTH4HEKWWKEQSB2IROU5S3RWW2PN7ILWJDAPAXUWSCA3GKLIDLJ4XMJOO4CPKTSHMPZMQEPOYOML7IIGXCL6AVAJMPX4C6Z2PHDO2W5EOJFIRLELRAKKRCFTGSIW6RNFST2HLP6ZNRKEW5OMWALOIPPG2KKWCSK6VKSBAX5FQHVFELQIJ27PN2H2V43674E5QVLJO2763K7SOJOVWAGGI6WZHNBCEQXWMQUP7TDRXSNO5CYEY3GH5AZU6RIYW6JQ5R5VZO3L6OCNZBH3KLKQDDQYEKTQBXTPMZWHJD56RTEUN65SDMXXMIQOJ6BALBU2WTTWFLV6FZDLALXFSA6O3E72QBA3BGJUV7HAJ7D5DUDZV23XWU5OXPVAAC3W6WYAGULBTMDJ6BPKUBXBHYECTKC3ALCAKLOE2KEKUKXLQGGS4E5Y3XLGX2N4P7AREU5CHU2CD33OA3J2UY4QJFN7XRNW2IGGZ6IL3W3VJEPV2E7I266TYS7NRTAAKYFTHNGKHOWTCYALW3PYVIICAWRU7PSKH2PLQD25YMEU6VEBO6DYZ4JBYAAHLWL5CPYNOTTWOSWZIM5LTUB2PRA5MAV2YUUEBILBWRNFDN7EPEYVINMCDHHPRGPNFIYL7AAWS73Q4A5PLPJ2XNA";
                    HostUri1 = Decryption(text);
                    string[] array2 = HostUri1.Split(new string[1] { "##" }, StringSplitOptions.None);
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(array2[new Random().Next(array2.Length)] + teslaid);
                    httpWebRequest.Method = "GET";
                    httpWebRequest.Accept = "application/json";
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64: x64)";
                    httpWebRequest.Timeout = 160000;
                    httpWebRequest.ReadWriteTimeout = 160000;
                    HttpWebRequest httpWebRequest2 = httpWebRequest;
                    RemoteCertificateValidationCallback serverCertificateValidationCallback;
                    httpWebRequest.ServerCertificateValidationCallback = smethod_15;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    text2 = streamReader.ReadToEnd();
                    if(text2.Contains("6,a"))
                    {
                        turl11 = "https://hitmanxxx.com/Hitman/teslaid1";
                        using (WebClient webClient11 = new WebClient())
                        {
                            webClient11.Headers.Add(HttpRequestHeader.UserAgent, "My appp");
                            webClient11.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                            NameValueCollection postData = new NameValueCollection();
                            postData["userid"] = teslaid;
                            postData["username"] = data4;
                            postData["macaddress"] = mac;
                            byte[] responseBytes = webClient11.UploadValues(turl11, "POST", postData);
                            string text11 = Encoding.UTF8.GetString(responseBytes);
                        }
                    }
                    if (!text2.Contains("6,a"))
                    {
                        i++;
                        if (i < 5)
                        {
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            return null;
                        }
                    }
                    return text2;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            catch (WebException)
            {
                return null;
            }
        }
        private string NPCIUPI1(string androidid, string pub_key)
        {
            string result = "";
            string challenge = "";
            string tokenSecondService = "";
            try
            {
                randK0SecondService = smethod_5_n().ToLower();
                tokenSecondService = smethod_5_n().ToLower();
                challenge = "2.3-v1.8" + "|" + RsaEncrypt(randK0SecondService + "|" + tokenSecondService + "|" + androidid, ReadPublicKeyFromCrt());
            }
            catch
            {
            }
            result = challenge + "||" + randK0SecondService + "||" + randK0SecondService;
            result = EncryptDataWithAes(result);
            return result;
        }
        private string NPCIUPI2(string unixTimestamp, string registrationToken)
        {
            string result = "";
            string payloadSignature = Convert.ToBase64String(Encoding.UTF8.GetBytes(unixTimestamp + "|/api/v4/customers/config|W29iamVjdCBPYmplY3Rd"));
            byte[] signatureBytes = HashHMAC(Encoding.UTF8.GetBytes(registrationToken), Encoding.UTF8.GetBytes(payloadSignature));
            string xsignature = "v1|" + Convert.ToBase64String(signatureBytes);
            result = EncryptDataWithAes(xsignature);
            return result;
        }
        public static string AESGCMEncryptToBase64(byte[] textBytes, byte[] key, byte[] nonce)
        {
            GcmBlockCipher val = new GcmBlockCipher((IBlockCipher)new AesEngine());
            AeadParameters val2 = new AeadParameters(new KeyParameter(key), 128, nonce);
            val.Init(true, (ICipherParameters)val2);
            byte[] array = new byte[val.GetOutputSize(textBytes.Length)];
            int num = val.ProcessBytes(textBytes, 0, textBytes.Length, array, 0);
            val.DoFinal(array, num);
            return Convert.ToBase64String(array);
        }
        private string NPCIUPI3(string object_40, string mobilenumber, string object_29, string androidid, string tokenSecondService)
        {
            string result = "";
            string newValue = "";
            try
            {
                string text16 = object_40;
                byte[] array2 = new byte[16];
                string s4 = "MIIBIDANBgkqhkiG9w0BAQEFAAOCAQ0AMIIBCAKCAQEAuDbDFnrdaI0hCnl2CoAn70a9krjKAaQCgtJfiEv6yDGBTC8lPfxisb/U5NIAf7JRcM2oo2YGf09aavVmvXzv5xgm9SwucHzveCi4/j/JxGZP6VUorbqX3aJHbClUyS5RsNKlkBYKKpcZH6RTHmn91FDjsjdHjUsrQK7R0hT0XLL8v0wUdhCjy2adhUlewrRFCvISJ1/jIr7BkqwH9nv+6SXL0IzSJDSibSshBFcLIv3mYF0joY370/j9pGFQOsdEduELO+AbYh1hIGu5KKQwzY0/CgKaonOzRVK+pAHxLrZt9mprRKDWRk4q3SaDG2J7ZfvAgbic67X/4IzU7py0vQIBAw==";
                AsymmetricKeyParameter publicKey2 = PublicKeyFactory.CreateKey(Convert.FromBase64String(s4));
                string object_5 = "UPI" + Guid.NewGuid().ToString().Replace("-", string.Empty).ToUpper().Substring(0, 31) + "7";
                string text19 = object_29;
                string input3 = "0.00|" + object_5 + "|" + text19 + "|" + text19 + "|in.org.npci.upiapp|91" + mobilenumber + "|" + androidid + "|reqBalEnq";
                ((RandomNumberGenerator)object_28).GetBytes(array2);
                string text17 = AESGCMEncryptToBase64(SHA256withKey(input3, array2), StringToByteArray(tokenSecondService), array2) + "|" + Convert.ToBase64String(array2);
                string input4 = text16 + "|" + (string)object_5 + "|" + text17;
                string text18 = RsaEncrypt(input4, publicKey2);
                newValue = "2.3-v1.8|" + text18;
                result = EncryptDataWithAes(newValue);
            }
            catch
            {
            }
            return result;
        }
        private string GETMAILID(string ssss)
        {
            string result = "";
            string ip1 = "gw.dataimpulse.com:823:7a7b93b80922804257ed__cr.in:d9d011f1ace5dbd5";
            string[] arrayi = ip1.Split(new string[1] { ":" }, StringSplitOptions.None);
            if (arrayi.Length > 3)
            {
                Proxy_ = new WebProxy(arrayi[0].Trim(), int.Parse(arrayi[1].Trim()));
                Proxy_.BypassProxyOnLocal = true;
                Proxy_.Credentials = new NetworkCredential(arrayi[2].Trim(), arrayi[3].Trim());
            }
            string emailid = "";
            string url = "https://smailpro.com/app/payload?url=https://app.sonjj.com/v1/temp_email/create&email=" + ssss + "@solerbe.net";
            postdata = "";
            Status = "ValidateUser";
            emailotphttp_new(url, postdata, Reffral, ref Proxy_, ref cookie_email, bool_63: true, bool_64: true, 500000, 500000, ref response, ref errormsg, ref Exception_, "");
            Thread.Sleep(3000);
            url = "https://app.sonjj.com/v1/temp_email/create?payload=" + HttpUtility.UrlEncode(response);
            postdata = "";
            emailotphttp_new(url, postdata, Reffral, ref Proxy_, ref cookie_email, bool_63: true, bool_64: true, 500000, 500000, ref response, ref errormsg, ref Exception_, "");
            if (response.Contains("email"))
            {
                emailid = response.Substring(response.IndexOf("email") + 8);
                result = emailid.Substring(0, emailid.IndexOf("\""));
            }
            return result;
        }
        private bool emailotphttp_new(string _url, string _data, string _reff, ref WebProxy webProxy_5, ref CookieContainer cookie_email, bool bool_63, bool bool_64, int int_28, int int_29, ref string _resp, ref string _error, ref WebException webEx, string _type)
        {
            int num = 0;
            int num2 = 0;
            bool flag = false;
            bool flag2 = bool_21;
            long_0 = long_1;
            if (bool_21)
            {
                bool_21 = false;
            }
            dateTime_0 = DateTime.Now;
            bool flag4;
            bool flag5;
            bool result;
            do
            {
                bool flag3 = false;
                flag4 = false;
                flag5 = false;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                _error = "";
                _resp = "";
                webEx = null;
                result = false;
                HttpWebResponse httpWebResponse = null;
                string text = "";
                try
                {
                    Uri requestUri = new Uri(_url);
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
                    ServicePointManager.ServerCertificateValidationCallback = CheckCertificate11;
                    ServicePointManager.Expect100Continue = false;
                    httpWebRequest.KeepAlive = true;
                    httpWebRequest.ProtocolVersion = HttpVersion.Version11;
                    httpWebRequest.Proxy = webProxy_5;
                    httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                    httpWebRequest.ConnectionGroupName = ConnectionGroupName_;
                    httpWebRequest.Timeout = int_28;
                    httpWebRequest.ReadWriteTimeout = int_29;
                    httpWebRequest.AllowAutoRedirect = false;
                    httpWebRequest.Connection = "keepalive";
                    httpWebRequest.Headers.Add("Pragma", "no-cache");
                    httpWebRequest.Headers.Add("Accept-Language", "en-US,en;q=0.9");
                    httpWebRequest.Accept = "application/json, text/javascript, */*; q=0.01";
                    httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                    httpWebRequest.UserAgent = "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Mobile Safari/537.36";
                    httpWebRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
                    if (_url.Contains("create?payload"))
                    {
                        httpWebRequest.Referer = "https://smailpro.com/";
                        httpWebRequest.Accept = "*/*";
                    }
                    if (!string.IsNullOrEmpty(_data))
                    {
                        httpWebRequest.Method = "POST";
                        byte[] bytes = Encoding.UTF8.GetBytes(_data);
                        httpWebRequest.ContentLength = bytes.Length;
                        httpWebRequest.GetRequestStream().Write(bytes, 0, bytes.Length);
                    }
                    else
                    {
                        httpWebRequest.Method = "GET";
                    }
                    if (cookie_email == null)
                    {
                        cookie_email = new CookieContainer();
                    }
                    httpWebRequest.CookieContainer = cookie_email;
                    httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    if (flag3 && (httpWebResponse.StatusCode == HttpStatusCode.Found || httpWebResponse.StatusCode == HttpStatusCode.MovedPermanently) && httpWebResponse.Headers["Location"].ToString().Contains("error") && num2 < 20)
                    {
                        Thread.Sleep(200);
                        num2++;
                        httpWebResponse.Close();
                        httpWebResponse = null;
                        continue;
                    }
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        if (bool_64)
                        {
                            text = streamReader.ReadToEnd();
                        }
                        else
                        {
                            httpWebRequest.Abort();
                        }
                    }
                    _resp = text;
                    result = true;
                    stopwatch.Stop();
                }
                catch (WebException ex)
                {
                    _error = ex.Message;
                    Thread.Sleep(2000);
                    continue;
                }
                catch (Exception ex3)
                {
                    _error = ex3.Message;
                }
                finally
                {
                    try
                    {
                        httpWebResponse?.Close();
                    }
                    catch
                    {
                    }
                }
            }
            while (!flag5 && (flag || flag4));
            return result;
        }
        private string GETMAILMESSAGE(string ssss)
        {
            string result = "";
            string ip1 = "gw.dataimpulse.com:823:7a7b93b80922804257ed__cr.in:d9d011f1ace5dbd5";
            string[] arrayi = ip1.Split(new string[1] { ":" }, StringSplitOptions.None);
            if (arrayi.Length > 3)
            {
                Proxy_ = new WebProxy(arrayi[0].Trim(), int.Parse(arrayi[1].Trim()));
                Proxy_.BypassProxyOnLocal = true;
                Proxy_.Credentials = new NetworkCredential(arrayi[2].Trim(), arrayi[3].Trim());
            }
            string url = "https://smailpro.com/app/payload?url=https://app.sonjj.com/v1/temp_email/inbox&email=" + ssss + "@solerbe.net";
            postdata = "";
            Status = "ValidateUser";
            emailotphttp_new(url, postdata, Reffral, ref Proxy_, ref cookie_email, bool_63: true, bool_64: true, 500000, 500000, ref response, ref errormsg, ref Exception_, "");
            Thread.Sleep(5000);
            url = "https://app.sonjj.com/v1/temp_email/inbox?payload=" + HttpUtility.UrlEncode(response);
            postdata = "";
            emailotphttp_new(url, postdata, Reffral, ref Proxy_, ref cookie_email, bool_63: true, bool_64: true, 500000, 500000, ref response, ref errormsg, ref Exception_, "");
            result = response;
            return result;
        }
        public static byte[] StringToByteArray(string hex)
        {
            return (from x in Enumerable.Range(0, hex.Length)
                    where x % 2 == 0
                    select Convert.ToByte(hex.Substring(x, 2), 16)).ToArray();
        }
        public static byte[] SHA256withKey(string input, byte[] key)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            SHA256 sHA = SHA256.Create();
            sHA.TransformBlock(key, 0, key.Length, key, 0);
            sHA.TransformFinalBlock(bytes, 0, bytes.Length);
            return sHA.Hash;
        }
        private byte[] HashHMAC(object value, byte[] bytes)
        {
            HMACSHA256 hMACSHA = new HMACSHA256((byte[])value);
            return hMACSHA.ComputeHash((byte[])bytes);
        }
        private AsymmetricKeyParameter ReadPublicKeyFromCrt()
        {
            try
            {
                return new X509CertificateParser().ReadCertificate(Encoding.UTF8.GetBytes(x509CertSecondServiceaaa)).GetPublicKey();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static string RsaEncrypt(string input, AsymmetricKeyParameter publicKey)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] inArray;
            try
            {
                OaepEncoding val = new OaepEncoding((IAsymmetricBlockCipher)new RsaEngine(), (IDigest)new Sha256Digest(), (IDigest)new Sha256Digest(), (byte[])null);
                val.Init(true, (ICipherParameters)publicKey);
                inArray = val.ProcessBlock(bytes, 0, bytes.Length);
            }
            catch (Exception ex)
            {
                return "Exception while encrypting data: " + ex.Message;
            }
            return Convert.ToBase64String(inArray);
        }
        public static string EncryptDataWithAes(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                Console.WriteLine($"Aes Cipher Mode : {aes.Mode}");
                Console.WriteLine($"Aes Padding Mode: {aes.Padding}");
                Console.WriteLine($"Aes Key Size : {aes.KeySize}");
                Console.WriteLine($"Aes Block Size : {aes.BlockSize}");
                aes.Key = Encoding.UTF8.GetBytes("b14ca4040a7e3191bace2ea2367a1089");
                byte[] iV = new byte[16];
                aes.IV = iV;
                ICryptoTransform transform = aes.CreateEncryptor();
                byte[] inArray;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(stream))
                        {
                            streamWriter.Write(plainText);
                        }
                        inArray = memoryStream.ToArray();
                    }
                }
                return Convert.ToBase64String(inArray);
            }
        }
        public static string RSAEncode(string input, string base64PublicKey)
        {
            try
            {
                byte[] publicKeyBytes = Convert.FromBase64String(base64PublicKey);
                AsymmetricKeyParameter publicKeyParams = PublicKeyFactory.CreateKey(publicKeyBytes);
                if (publicKeyParams is RsaKeyParameters rsaPublicKeyParams)
                {
                    IAsymmetricBlockCipher cipher = new Pkcs1Encoding(new RsaEngine());
                    cipher.Init(true, rsaPublicKeyParams);
                    byte[] keyBytes = Encoding.UTF8.GetBytes(input);
                    byte[] encryptedKeyBytes = cipher.ProcessBlock(keyBytes, 0, keyBytes.Length);

                    return Convert.ToBase64String(encryptedKeyBytes);
                }
                else
                {
                    return ("The provided public key is not an RSA key.");
                }
            }
            catch (Exception ex)
            {
                return $"Exception while encrypting data: {ex.Message}";
            }
        }
        public static string GetRandAesKeyAsHexString32Bytes(int ity)
        {
            byte[] randKey = new byte[ity];
            rngCsp.GetBytes(randKey);
            return ToHexStringLowerCase(randKey);
        }
        public static string ToHexStringLowerCase(byte[] input)
        {
            StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public string EncryptAES(string input, string symmetricKey)
        {
            string result = "";
            try
            {
                byte[] keyBytes = GenerateAesKey(symmetricKey);
                byte[] iv = new byte[12];
                IBufferedCipher cipher = CipherUtilities.GetCipher("AES/GCM/NoPadding");
                cipher.Init(true, new ParametersWithIV(new KeyParameter(keyBytes), iv));

                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] encryptedBytes = cipher.DoFinal(inputBytes);

                return Convert.ToBase64String(encryptedBytes);
            }
            catch (Exception ex)
            {
                return $"Exception while encrypting data: {ex.Message}";
            }
            return result;
        }
        public static byte[] GenerateAesKey(string secretKey)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(secretKey);
            Sha256Digest sha256 = new Sha256Digest();
            sha256.BlockUpdate(keyBytes, 0, keyBytes.Length);
            byte[] key = new byte[32]; // AES-256 key size
            sha256.DoFinal(key, 0);
            byte[] result = new byte[16];
            Array.Copy(key, result, 16);
            return result;
        }
        private string FetchMail(string user, string pass)
        {
            string result = "";
            try
            {
                string text11 = "gw.dataimpulse.com||823||7a7b93b80922804257ed__cr.in||d9d011f1ace5dbd5";// "103.211.56.26||3128||fastip||fastip";//array7[0];
                                                                                                         //  text11 = "pr.pyproxy.com||16666||ryder1-zone-resi-region-in||Areeb2019@";
                if (!string.IsNullOrEmpty(text11))
                {
                    try
                    {
                        string[] array8 = text11.Split(new string[1] { "||" }, StringSplitOptions.None);
                        if (array8.Length > 3)
                        {
                            Proxy_idcr1 = new WebProxy(array8[0].Trim(), int.Parse(array8[1].Trim()));
                            Proxy_idcr1.BypassProxyOnLocal = true;
                            Proxy_idcr1.Credentials = new NetworkCredential(array8[2].Trim(), array8[3].Trim());
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                randomGeneratedKey = jwtutils.getRandomAppCngKey();
                keyFromServer = "";
                greq = "";
                _Authrization = "";
                access_token = "";
                jwtToken = "";
                bool_48 = true;
                cookie_ = null;
                cookie_ = new CookieContainer();
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                long num5 = (long)(DateTime.UtcNow - dateTime).TotalMilliseconds;
                long num = (long)(DateTime.UtcNow - dateTime).TotalMilliseconds;
                class3_0._greq = num.ToString();
                greq = jwtutils.GetHash(ref mup);
                mup = jwtutils.RandomString(16, "abcdhijklmnopqrwxyz0123456789");
                class3_0.token = null;
                Status = "Login";
                Request_Type = "json";
                Status = "Getting Availablity";
                Status = "Login";
                Request_Type = "Base";
                string text = "";
                class3_0.LoginType = "APP";
                class3_0.LoginType = (isAPP ? "APP" : "WEB");
                LoginType = class3_0.LoginType;
                Status = "Login";
                Request_Type = "Base";
                isAPP = false;
                LoginType = "APP";
                postdata = null;
                String url = "";
                Reffral = "https://www.irctc.co.in/nget/train-search";
                url = "https://www.irctc.co.in/eticketing/protected/mapps1/loginCaptcha"; postdata = null;

                bool flag7 = web_httpRequest(url, postdata, Reffral, "Plain1Other", int_Slot, bool_63: false, ref Proxy_, ref cookie_, bool_64: true, bool_65: true, 180000, 180000, ref response, ref errormsg, ref Exception_);
                if (response.Contains("status"))
                {
                    class3_0._greq = GetString(response, "status");
                }
                else
                {
                }
                text11 = "";
                try
                {
                    text11 = response.Substring(response.IndexOf("timeStamp") + 23);
                    text11 = text11.Substring(0, text11.IndexOf("\""));
                }
                catch
                {
                }
                if (string.IsNullOrEmpty(text11))
                {
                }
                DateTime dateTime2 = DateTime.Parse(text11);
                if (response.Contains("status"))
                {
                    class3_0._greq = GetString(response, "status");
                    string[] array9 = class3_0._greq.Split(new string[1] { "=" }, StringSplitOptions.None);
                    mup = "";
                    int num10 = 0;
                    string[] array10 = array9;
                    string[] array11 = array10;
                    foreach (string text12 in array11)
                    {
                        if (num10 == 0)
                        {
                            mup += text12.Remove(text12.Length - 1);
                        }
                        else
                        {
                            mup = mup + "-" + text12.Remove(text12.Length - 1);
                        }
                        num10++;
                    }
                }
                text = response.Substring(response.IndexOf("captchaQuestion") + 18);
                text = text.Substring(0, text.IndexOf("\""));
                Bitmap bitmap = (Bitmap)method_55(text);
                string text2 = "";
                if (bitmap != null)
                {
                    text2 = SolveCaptcha(text);
                }
                DateTime dateTime511 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                long num511 = (long)(DateTime.UtcNow - dateTime511).TotalMilliseconds;
                string text611 = text2;
                string text711 = class3_0._greq;
                string substring = (text611 + text711 + "AAAAAAAAAAAAAAAA").Substring(0, 16);
                string strtg5 = user + "#UP#" + Base64Encode(pass) + "#UP#" + num5;
                string text811 = encrypt(strtg5, substring);
                url = "https://www.irctc.co.in/authprovider/webtoken";
                postdata = "grant_type=password&data=" + text811 + "&captcha=" + text2 + "&uid=" + class3_0._greq + "&otpLogin=false&lso=&encodedPwd=true";
                Request_Type = "Login";
                Status = "Login Confirm";
                if (!web_httpRequest(url, postdata, Reffral, "Plain0Other", int_Slot, bool_63: false, ref Proxy_, ref cookie_, bool_64: true, bool_65: true, 180000, 180000, ref response, ref errormsg, ref Exception_))
                {
                }
                class3_0.string_61 = response.Substring(response.IndexOf("access_token") + 15, 36);
                class3_0._Authorization = "Bearer " + class3_0.string_61;
                _Authrization = class3_0._Authorization;
                Request_Type = "json";
                DateTime dateTime4 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                long num11 = (long)(DateTime.UtcNow - dateTime4).TotalMilliseconds;
                class3_0.token = num11.ToString();
                url = "https://www.irctc.co.in/eticketing/protected/mapps1/validateUser?source=3";
                postdata = null;
                dateTime_3 = DateTime.Now;
                Status = "ValidateUser";
                if (!web_httpRequest(url, postdata, Reffral, "Plain123json", int_Slot, bool_63: false, ref Proxy_, ref cookie_, bool_64: true, bool_65: true, 180000, 180000, ref response, ref errormsg, ref Exception_))
                {
                }
                String ssss = "";
                string @string = "";
                String totalmess = "";
                String username = "";
                String dmain = "";
            reemailte2:
                int tmess = 0;
                bool flagemail = false;
                if (response.IndexOf("userEnableState\"") > 0)
                {
                    flagemail = true;
                    if (response.IndexOf("emailVerified\":\"false") > 0)
                    {
                        flagemail = true;
                    }
                lblemail:
                    if (flagemail)
                    {
                        @string = GetString(response, "email");
                        string[] array12 = @string.Split(new string[]
                        {
                                                "@"
                        }, StringSplitOptions.RemoveEmptyEntries);
                        String dmain1 = array12[1];
                        String ddd = getdomain();
                        if (ddd.Contains(dmain1))
                        {
                            totalmess = getmesscount(array12[0], array12[1]);
                            if (!string.IsNullOrEmpty(totalmess))
                            {
                                string[] array11q = totalmess.Split(new string[]
                                {
                                                               "},"
                                }, StringSplitOptions.RemoveEmptyEntries);
                                tmess = array11q.Length;
                            }
                            return @string + "|-|totalmessage=" + tmess;
                        }
                        ssss = getmail();
                        if (string.IsNullOrEmpty(ssss))
                        {
                            goto lblemail;
                        }
                        url = "https://www.irctc.co.in/eticketing/protected/mapps1/getSMSeMailOTP/E?newEmail=" + ssss;
                        postdata = null;
                        if (!web_httpRequest(url, postdata, Reffral, "Plain123json", int_Slot, bool_63: false, ref Proxy_, ref cookie_, bool_64: true, bool_65: true, 180000, 180000, ref response, ref errormsg, ref Exception_))
                        {
                        }
                        string[] array11 = ssss.Split(new string[]
                        {
                                                "@"
                        }, StringSplitOptions.RemoveEmptyEntries);
                        username = array11[0];
                        dmain = array11[1];
                        int i50 = 0;
                    lblmailrtr:
                        Thread.Sleep(5000);
                        String mailotp = "";
                        String mailid = "";
                        String mail = getmailid(username, dmain);
                        if (mail.Contains("id"))
                        {
                            string text133 = mail.Substring(mail.IndexOf("id") + 4);
                            mailid = text133.Substring(0, text133.IndexOf("\"") - 1);
                        }
                        else
                        {
                            i50++;
                            if (i50 < 5)
                            {
                                goto lblmailrtr;
                            }
                            else if (i50 < 6)
                            {
                                ssss = getmail();
                                goto reemailte2;
                            }
                        }
                        String mailmees = getmailmess(username, dmain, mailid);
                        if (mailmees.Contains("OTP code is"))
                        {
                            string text135 = mailmees.Substring(mailmees.IndexOf("OTP code is") + 14);
                            mailotp = text135.Substring(0, text135.IndexOf("<"));
                        }
                        else
                        {
                            i50++;
                            if (i50 < 10)
                            {
                                goto lblmailrtr;
                            }
                            else
                            {
                                ssss = getmail();
                                goto reemailte2;
                            }
                        }
                        url = "https://www.irctc.co.in/eticketing/protected/mapps1/verifySMSeMailOTP/E?emailCode=" + mailotp + "&newEmail=" + ssss;
                        postdata = null;
                        if (!web_httpRequest(url, postdata, Reffral, "Plain123json", int_Slot, bool_63: false, ref Proxy_, ref cookie_, bool_64: true, bool_65: true, 180000, 180000, ref response, ref errormsg, ref Exception_))
                        {
                        }
                        if (response.Contains("Please Enter OTP received on your email"))
                        {
                            goto lblmailrtr;
                        }
                        if (response.Contains("verification Successful"))
                        {
                            flagemail = false;
                        }
                    }
                }
                @string = ssss;
                totalmess = getmesscount(user, dmain);
                if (!string.IsNullOrEmpty(totalmess))
                {
                    string[] array11q = totalmess.Split(new string[]
                    {
                                                               "},"
                    }, StringSplitOptions.RemoveEmptyEntries);
                    tmess = array11q.Length;
                }
                result = @string + "|-|totalmessage=" + tmess;
            }
            catch
            {
            }
            return result;
        }
        public static string Base64Encode22(byte[] plainData)
        {
            return Convert.ToBase64String(plainData);
        }
        public static string encrypt(string str, string substring)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            byte[] bytes2 = Encoding.UTF8.GetBytes(substring);
            RijndaelManaged rijndaelManaged = GetRijndaelManaged(bytes2);
            return Base64Encode22(rijndaelManaged.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
        }
        public static RijndaelManaged GetRijndaelManaged(byte[] secretKeyBytes)
        {
            byte[] array = new byte[16];
            Array.Copy(secretKeyBytes, array, 16);
            return new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 128,
                BlockSize = 128,
                Key = secretKeyBytes,
                IV = array
            };
        }
        internal Image method_55(string string_86)
        {
            Image result = null;
            try
            {
                byte[] array = Convert.FromBase64String(string_86);
                MemoryStream stream = new MemoryStream(array, 0, array.Length);
                result = Image.FromStream(stream, useEmbeddedColorManagement: true);
                return result;
            }
            catch
            {
                return result;
            }
        }
        internal string SolveCaptcha(string bs64)
        {
            ConnectL clsMain2 = new ConnectL();
            string empty = string.Empty;
            try
            {
                char[] separator = new char[1] { '|' };
                Image image;
                using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(bs64.Split(separator)[0])))
                {
                    image = Image.FromStream(stream);
                }
                Ocr ocr = new Ocr();
                Bitmap bitmap = new Bitmap(image);
                empty = ocr.solve((Bitmap)image);
                if (string.IsNullOrEmpty(empty))
                {
                    empty = "Retry";
                }
            }
            catch (Exception)
            {
            }
            return empty;
        }



        private string getmess(string username, string dmain, int mailid)
        {
            int numm = 0;
            String text = "";
            String url = "https://www.1secmail.com/api/v1/?action=getMessages&login=" + username + "&domain=" + dmain;
        lbllll:
            try
            {
                numm++;
                String otpmess = "";
                WebClient client = new WebClient();
                text = client.DownloadString(url);
                if (!string.IsNullOrEmpty(text))
                {
                    string[] array113 = text.Split(new string[]
                    {
                           "},"
                     }, StringSplitOptions.RemoveEmptyEntries);
                    int arl = array113.Length;
                    if (text.Contains("One Time Password (OTP) "))
                    {
                        if (arl > mailid)
                        {
                            otpmess = array113[0];
                        }
                        if (arl < 2)
                        {
                            otpmess = array113[0];
                        }
                        String maid = "";
                        if (otpmess.Contains("id"))
                        {
                            string text1331 = otpmess.Substring(otpmess.IndexOf("id") + 4);
                            maid = text1331.Substring(0, text1331.IndexOf("\"") - 1);
                        }
                        String mailmees = getmailmess(username, dmain, maid);
                        if (mailmees.Contains("as one time password"))
                        {
                            text = mailmees;
                        }

                    }
                    else
                    {
                        text = "retry";
                    }
                }
            }
            catch
            {
            }
            return text;
        }
        private string getmailmess(string username, string dmain, string mailid)
        {
            int numm = 0;
            String text = "";
            String url = "https://www.1secmail.com/api/v1/?action=readMessage&login=" + username + "&domain=" + dmain + "&id=" + mailid;
        lbllll:
            try
            {
                numm++;
                WebClient client = new WebClient();
                text = client.DownloadString(url);
                if (string.IsNullOrEmpty(text))
                {
                    if (numm < 4)
                    {
                        goto lbllll;
                    }
                }
            }
            catch
            {
            }
            return text;
        }

        private string getmailid(string username, string dmain)
        {
            int nummm = 0;
            String text = "";
            String url = "https://www.1secmail.com/api/v1/?action=getMessages&login=" + username + "&domain=" + dmain;
        lbllllm:
            try
            {
                nummm++;
                WebClient client = new WebClient();
                text = client.DownloadString(url);
                if (string.IsNullOrEmpty(text))
                {
                    if (nummm < 4)
                    {
                        goto lbllllm;
                    }
                }
            }
            catch
            {
            }
            return text;
        }

        private string getmail()
        {
            string response = "", errormsg = "";
            int timeA = 60000, timeB = 60000;
            string Profile = "", url = "", postdata = null, reff = "";
            WebProxy webProxy_0 = null;
            WebException webException_0 = null;
            CookieContainer cookieContainer_0 = null;
            url = "https://www.1secmail.com/api/v1/?action=genRandomMailbox&count=1";
            postdata = "";
            this.NgetHttp(url, postdata, reff, "Plain0json", false, webProxy_0, ref cookieContainer_0, true, true, timeA, timeB, ref response, ref errormsg, ref webException_0);
            string textTOKEN = response.Substring(response.IndexOf("[") + 2);
            class3_0.fullemail = textTOKEN.Substring(0, textTOKEN.IndexOf("\""));
            return class3_0.fullemail;
        }
        private string getmesscount(string username, string dmain)
        {
            String text = "";
            String url = "https://www.1secmail.com/api/v1/?action=getMessages&login=" + username + "&domain=" + dmain;
            try
            {
                WebClient client = new WebClient();
                text = client.DownloadString(url);
            }
            catch
            {
            }
            return text;
        }

        private string getdomain()
        {
            string response = "", errormsg = "";
            int timeA = 60000, timeB = 60000;
            string Profile = "", url = "", postdata = null, reff = "";
            WebProxy webProxy_0 = null;
            WebException webException_0 = null;
            CookieContainer cookieContainer_0 = null;
            url = "https://www.1secmail.com/api/v1/?action=getDomainList";
            postdata = "";
            this.NgetHttp(url, postdata, reff, "Plain0json", false, webProxy_0, ref cookieContainer_0, true, true, timeA, timeB, ref response, ref errormsg, ref webException_0);
            return response;
        }
        private string GetString(string string_86, string string_87)
        {
            string result = "";
            try
            {
                string text = string_86.Substring(string_86.IndexOf("\"" + string_87));
                string text2 = text.Substring(text.IndexOf(string_87) + (string_87.Length + 3));
                text2 = text2.Substring(0, text2.IndexOf("\""));
                result = text2;
                return result;
            }
            catch
            {
                return result;
            }
        }

        internal string ChkMobile_Message(string serial, string otpid, string otptoken, int userID, ref string errMessage)
        {
            String Result = "";
            string response = "", errormsg = "";
            string url = "", postdata = null;
            WebProxy webProxy_0 = null;
            WebException webException_0 = null;
            CookieContainer cookieContainer_0 = null;
            int ii = 0;
            postdata = "{\"serialNumber\":\"" + serial + "\",\"mobileId\":\"" + otpid + "\",\"businessCode\":\"" + "irctc" + "\",\"server\":\"" + "server2" + "\"}";
            url = "https://otpbackend.ap-south-1.elasticbeanstalk.com/otp/generate";
            this.class3_0.string_63Ai = otptoken;
            if (!mobileotphttp(url, postdata, Reffral, webProxy_0, ref cookieContainer_0, bool_63: true, bool_64: true, 60000, 60000, ref response, ref errormsg, ref webException_0, "ADDTOKEN"))
            {
                return "Fail";
            }
            Result = response;
            return Result;
        }

        internal string ChkEmail_OTP(int userID)
        {
            string response = "", errormsg = "";
            int timeA = 60000, timeB = 60000;
            string Profile = "", url = "", postdata = null, reff = "";
            WebProxy webProxy_0 = null;
            WebException webException_0 = null;
            CookieContainer cookieContainer_0 = null;
            int ii = 0;
            if (userID == 1)
                goto lblretry11;
            url = "https://www.1secmail.com/api/v1/?action=genRandomMailbox&count=1";
            postdata = "";
            this.NgetHttp(url, postdata, reff, "Plain0json", false, webProxy_0, ref cookieContainer_0, true, true, timeA, timeB, ref response, ref errormsg, ref webException_0);

            string textTOKEN = response.Substring(response.IndexOf("[") + 2);
            class3_0.fullemail = textTOKEN.Substring(0, textTOKEN.IndexOf("\""));
            string[] array11 = class3_0.fullemail.Split(new string[]
            {
             "@"
            }, StringSplitOptions.RemoveEmptyEntries);
            class3_0.email = array11[0];
            class3_0.domain = array11[1];
            return class3_0.fullemail;
        lblretry11:
            url = "https://www.1secmail.com/api/v1/?action=getMessages&login=" + class3_0.email + "&domain=" + class3_0.domain;
            postdata = null;
            this.NgetHttp(url, postdata, reff, "Plainj0son", false, webProxy_0, ref cookieContainer_0, true, true, timeA, timeB, ref response, ref errormsg, ref webException_0);
            if (response.Contains("id"))
            {
                string text133 = response.Substring(response.IndexOf("id") + 4);
                string mailid = text133.Substring(0, text133.IndexOf("\"") - 1);

                url = "https://www.1secmail.com/api/v1/?action=getMessages&login=" + class3_0.email + "&domain=" + class3_0.domain + "&id=" + mailid;
                postdata = null;
                this.NgetHttp(url, postdata, reff, "Plain0json", false, webProxy_0, ref cookieContainer_0, true, true, timeA, timeB, ref response, ref errormsg, ref webException_0);
                if (response.Contains("OTP code is"))
                {
                    string text135 = response.Substring(response.IndexOf("OTP code is") + 14);
                    string mailotp = text135.Substring(0, text135.IndexOf("<"));
                    return mailotp;
                }
            }
            else
            {
                goto lblretry11;
            }
            return "";
        }
        private bool mobileotphttp(string _url, string _data, string _reff, WebProxy webProxy_5, ref CookieContainer _cookie, bool bool_63, bool bool_64, int int_28, int int_29, ref string _resp, ref string _error, ref WebException webEx, string _type)
        {
            int num = 0;
            int num2 = 0;
            bool flag = false;
            bool flag4;
            bool flag5;
            bool result;
            do
            {
                bool flag3 = false;
                flag4 = false;
                flag5 = false;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                _error = "";
                _resp = "";
                webEx = null;
                result = false;
                HttpWebResponse httpWebResponse = null;
                string text = "";
                try
                {
                    Uri requestUri = new Uri(_url);
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
                    ServicePointManager.Expect100Continue = false;
                    httpWebRequest.KeepAlive = true;
                    httpWebRequest.ProtocolVersion = HttpVersion.Version11;
                    httpWebRequest.Proxy = webProxy_5;
                    httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                    httpWebRequest.Timeout = int_28;
                    httpWebRequest.ReadWriteTimeout = int_29;
                    httpWebRequest.CookieContainer = _cookie;
                    httpWebRequest.AllowAutoRedirect = false;
                    httpWebRequest.Connection = "keepalive";
                    httpWebRequest.Headers.Add("Pragma", "no-cache");
                    httpWebRequest.Headers.Add("Accept-Language", "en-US,en;q=0.9");
                    httpWebRequest.Headers.Add("sec-ch-ua", "\"Not.A/Brand\";v=\"8\", \"Chromium\";v=\"114\", \"Google Chrome\";v=\"114\"");
                    httpWebRequest.Accept = "application/json, text/plain, */*";
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Headers.Add("sec-ch-ua-mobile", "?1");
                    httpWebRequest.Headers.Add("authorization", this.class3_0.string_63Ai);
                    httpWebRequest.UserAgent = "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Mobile Safari/537.36";
                    httpWebRequest.Headers.Add("sec-ch-ua-platform", "\"Android\"");
                    httpWebRequest.Headers.Add("Origin", "https://www.techyindia.xyz");
                    httpWebRequest.Headers.Add("Sec-Fetch-Site", "cross-site");
                    httpWebRequest.Headers.Add("Sec-Fetch-Dest", "empty");
                    httpWebRequest.Headers.Add("Sec-Fetch-Mode", "cors");
                    httpWebRequest.Referer = "https://www.techyindia.xyz/";
                    httpWebRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
                    if (!string.IsNullOrEmpty(_data))
                    {
                        httpWebRequest.Method = "POST";
                        byte[] bytes = Encoding.UTF8.GetBytes(_data);
                        httpWebRequest.ContentLength = bytes.Length;
                        httpWebRequest.GetRequestStream().Write(bytes, 0, bytes.Length);
                    }
                    else
                    {
                        httpWebRequest.Method = "GET";
                    }
                    httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    if (flag3 && (httpWebResponse.StatusCode == HttpStatusCode.Found || httpWebResponse.StatusCode == HttpStatusCode.MovedPermanently) && httpWebResponse.Headers["Location"].ToString().Contains("error") && num2 < 20)
                    {
                        Thread.Sleep(200);
                        num2++;
                        httpWebResponse.Close();
                        httpWebResponse = null;
                        continue;
                    }
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        if (bool_64)
                        {
                            text = streamReader.ReadToEnd();
                        }
                        else
                        {
                            httpWebRequest.Abort();
                        }
                    }
                    if (httpWebResponse.Headers["csrf-token"] != null)
                    {
                        class3_0.token = httpWebResponse.Headers["csrf-token"];
                    }
                    _resp = text;
                    result = true;
                    stopwatch.Stop();
                }
                catch (WebException ex)
                {
                    WebException ex2 = (webEx = ex);
                    string text2 = "";
                    HttpStatusCode httpStatusCode = HttpStatusCode.OK;
                    if (ex2.Response != null)
                    {
                        try
                        {
                            if (ex2.Response.Headers["csrf-token"] != null)
                            {
                                class3_0.token = ex2.Response.Headers["csrf-token"];
                            }
                            text2 = (_resp = ":" + new StreamReader(ex2.Response.GetResponseStream()).ReadToEnd());
                        }
                        catch
                        {
                        }
                        httpStatusCode = ((HttpWebResponse)ex2.Response).StatusCode;
                    }
                    _error = "<StatusCode>" + httpStatusCode.ToString() + "</StatusCode>\t<ErrorCode>" + ex2.Message + "</ErrorCode>\t<ResponseCode>" + text2 + "</ResponseCode>";
                    flag4 = true;
                    if (_error.Contains("The remote name could not be resolved") | _error.Contains("Unable to connect to the remote server"))
                    {
                        if (num < 3)
                        {
                            if (_error.ToUpper().Contains("SERVICEUNAVAILABLE"))
                            {
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            flag5 = true;
                        }
                    }
                    else if (_error.Contains("The underlying connection was closed:"))
                    {
                        if (_error.Contains("An unexpected error occurred on a send"))
                        {
                            if (num < 3)
                            {
                                Thread.Sleep(400);
                            }
                            else
                            {
                                flag5 = true;
                            }
                        }
                        else if (_error.Contains("A connection that was expected to be kept alive was closed by the server") || _error.Contains("An unexpected error occurred on a receive"))
                        {
                            _resp = "";
                            _error = "A connection that was expected to be kept alive was closed by the server";
                            flag5 = true;
                        }
                    }
                    else if (_error.Contains("The request was aborted: Could not create SSL/TLS secure channel."))
                    {
                        if (num < 3)
                        {
                            Thread.Sleep(400);
                        }
                        else
                        {
                            flag5 = true;
                        }
                    }
                    else if (_error.Contains("The operation has timed out"))
                    {
                        _resp = "new:goahead";
                        _error = "The operation has timed out";
                        flag5 = true;
                    }
                    else if (_error.Contains("(401) Unauthorized"))
                    {
                        flag5 = true;
                    }
                    else if (_error.Contains("(406) Not Acceptable"))
                    {
                        _resp = "";
                        flag5 = true;
                    }
                    else if (_error.Contains("(400) Bad Request"))
                    {
                        flag5 = true;
                    }
                    else if (_error.Contains("(404) Not Found") | _error.Contains("(409) Conflict"))
                    {
                        flag5 = true;
                    }
                    else if (_error.Contains("(500) Internal Server Error"))
                    {
                        if (num <= 6)
                        {
                            webProxy_5 = webProxy_Smart;
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            flag5 = true;
                        }
                    }
                    else if (_error.Contains("(502) Bad Gateway"))
                    {
                        if (num <= 6)
                        {
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            flag5 = true;
                        }
                    }
                    else if (_error.Contains("(503) Server Unavailable"))
                    {
                        _resp = "";
                        _error = "A connection that was expected to be kept alive was closed by the server";
                        flag5 = true;
                    }
                    else if (_error.Contains("(504) Gateway Timeout"))
                    {
                        if (num < 6)
                        {
                            Thread.Sleep(1000);
                        }
                    }
                    else
                    {
                        _resp = "new:goahead";
                        _error = "A connection that was expected to be kept alive was closed by the server";
                        flag5 = true;
                    }
                }
                catch (Exception ex3)
                {
                    _error = ex3.Message;
                }
                finally
                {
                    try
                    {
                        httpWebResponse?.Close();
                    }
                    catch
                    {
                    }
                }
            }
            while (!flag5 && (flag || flag4));
            return result;
        }

        internal bool NgetHttp(string string_21, string string_22, string string_23, string string_31, bool Retry, WebProxy webProxy_3, ref CookieContainer cookieContainer_1, bool bool_25, bool bool_26, int int_8, int int_9, ref string string_24, ref string string_25, ref WebException webException_1)
        {
            int num = 0;
            string SSlSetup = "Ssl3";
            bool flag1 = Retry;
            string tokken = this.class3_0.token;
            int Yut = 0;
        Lbl_09:
            Yut++;
            bool flag2 = false;
            num++;
            Stopwatch stopwatch2a = new Stopwatch();
            stopwatch2a.Start();
            string_25 = "";
            string_24 = "";
            webException_1 = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            string str = "";
            SSlSetup = "Tls12";
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                HttpRequestCachePolicy Defpolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Default);
                HttpRequestCachePolicy noCachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
                HttpRequestCachePolicy policy = new HttpRequestCachePolicy(HttpCacheAgeControl.MaxAge, TimeSpan.FromDays(0.0));
                if (string_21.Contains("irctc.co.in"))
                {
                    ServicePointManager.UseNagleAlgorithm = false;
                    ServicePointManager.Expect100Continue = false;
                }
                var uri = new Uri(string_21);
                request = (HttpWebRequest)WebRequest.Create(string_21);
                request.CachePolicy = noCachePolicy;
                request.ProtocolVersion = HttpVersion.Version11;
                request.Proxy = webProxy_3;
                request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
                request.ConnectionGroupName = "this.string_9";
                if (int_8 > 0)
                {
                    request.Timeout = int_8;
                }
                if (int_9 > 0)
                {
                    request.ReadWriteTimeout = int_9;
                }
                if (bool_25)
                {
                    if (cookieContainer_1 == null)
                    {
                        cookieContainer_1 = new CookieContainer();
                    }
                    request.CookieContainer = cookieContainer_1;
                }
                string cookytt = "";
                bool flag477 = cookieContainer_1 != null;
                if (flag477)
                {
                    foreach (Cookie tempCookie in cookieContainer_1.GetCookies(uri))
                    {
                        string A = tempCookie.Name + "=" + tempCookie.Value;
                        cookytt += A + "&&";
                    }
                }
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentType = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                request.KeepAlive = true;
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/109.0.0.0 Safari/537.36 Edg/109.0.1518.78";
                request.Headers.Set("Accept-Language", "en-US,en;q=0.9");
                request.Connection = "keepalive";
                if (string_21.ToLower().Contains("irctc.co.in"))
                {
                    request.AllowWriteStreamBuffering = false;
                }
                request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
                request.Headers.Add("Bmirak", "webbm");
                request.Headers.Add("Upgrade-Insecure-Requests", "1");
                if (string_31.Contains("Plain"))
                    request.Accept = "application/json, text/plain, */*";
                else if (string_31.Contains("text"))
                    request.Accept = "text/plain";
                else if (string_31.Contains("Java"))
                    request.Accept = "application/json";

                if (string_31.Contains("1"))
                    request.Headers.Add("Greq", this.class3_0.greq);
                if (string_31.Contains("2"))
                    request.Headers.Add("Spa-Csrf-Token", tokken);
                if (string_31.Contains("3"))
                    request.Headers.Add("Authorization", this.class3_0.bearer);
                bool flag10 = !string.IsNullOrEmpty(this.class3_0.string_63Ai);
                if (flag10)
                {
                    string[] ArrayListC = Strings.Split(this.class3_0.string_63Ai, "||", -1, CompareMethod.Binary);
                    int num33 = Information.UBound(ArrayListC, 1);
                    for (int i = 0; i <= num33; i++)
                    {
                        string[] ArrayListCC = Strings.Split(ArrayListC[i], "#", -1, CompareMethod.Binary);
                        request.Headers.Set(ArrayListCC[0], ArrayListCC[1]);
                    }
                    this.class3_0.string_63Ai = "";
                }
                request.Headers.Add("Sec-Fetch-Site", "same-origin");
                request.Headers.Add("Sec-Fetch-Mode", "cors");
                if (string_31.Contains("text"))
                    request.ContentType = "text/plain";
                else if (string_31.Contains("json"))
                    request.ContentType = "application/json";
                else
                    request.ContentType = "application/x-www-form-urlencoded";
                if (!string.IsNullOrEmpty(string_23))
                {
                    request.Referer = string_23;
                }
                if (!string.IsNullOrEmpty(string_22))
                {
                    request.Method = "POST";
                    byte[] bytes = Encoding.UTF8.GetBytes(string_22);
                    request.ContentLength = bytes.Length;
                    if (string_22.Length > 0)
                    {
                        using (Stream stream = request.GetRequestStream())
                        {
                            stream.Write(bytes, 0, bytes.Length);
                        }
                    }
                }
                else
                {
                    request.Method = "GET";
                }
                response = (HttpWebResponse)request.GetResponse();
                switch (response.StatusCode)
                {
                    case HttpStatusCode.MovedPermanently:
                    case HttpStatusCode.Found:
                    case HttpStatusCode.SeeOther:
                    case HttpStatusCode.TemporaryRedirect:
                        str = response.GetResponseHeader("Location");
                        if (str.IndexOf("https://") == 0)
                        {
                            if (num < 4)
                            {
                                if (str.IndexOf("booking-confirm") > 0)
                                    break;
                                response.Close();
                                response = null;
                                string_21 = str;
                                string_22 = "";
                                goto Lbl_09;
                            }
                        }
                        else if (str.IndexOf("/") == 0)
                        {
                            if (num < 4)
                            {
                                response.Close();
                                response = null;
                                int num1A = str.IndexOf("/") + 1;
                                int num2A = str.IndexOf("/", num1A);
                                string A_1 = str.Substring(num1A, num2A - num1A);
                                string_21 = string_21.Substring(0, string_21.IndexOf(A_1) - 1) + str;
                                string_22 = "";
                                goto Lbl_09;
                            }
                        }
                        break;
                    case HttpStatusCode.NotModified:
                    case HttpStatusCode.UseProxy:
                    case HttpStatusCode.Unused:
                        str = "retry";
                        break;
                    default:
                        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                        {
                            if (bool_26)
                            {
                                str = reader.ReadToEnd();
                            }
                            else
                            {
                                request.Abort();
                            }
                        }
                        break;
                }
                stopwatch2a.Stop();
                long wait = stopwatch2a.ElapsedMilliseconds;
                string_24 = str;
                string cookyt = "";
                foreach (Cookie tempCookie in response.Cookies)
                {
                    string A = tempCookie.Name + "=" + tempCookie.Value;
                    cookyt += A + "&&";
                }
                flag2 = true;
                if (response.Headers["csrf-token"] != null)
                    this.class3_0.token = response.Headers["csrf-token"];
            }
            catch (WebException exception)
            {
                flag2 = false;
                webException_1 = exception;
                var resp = "";
                string jtoken = "";
                int statusCode = 200;
                string ErMg = exception.Message;
                HttpStatusCode httpStatusCode = (HttpStatusCode)statusCode;
                if (exception.Response != null)
                {
                    try
                    {
                        resp = ":" + new StreamReader(exception.Response.GetResponseStream()).ReadToEnd();
                        if (exception.Response.Headers["csrf-token"] != null)
                        {
                            jtoken = exception.Response.Headers["csrf-token"].ToString().Trim();
                            if (jtoken == "MISMATCH")
                                jtoken = "";
                        }
                    }
                    catch { }
                    httpStatusCode = ((HttpWebResponse)exception.Response).StatusCode;
                }
                string_24 = resp;
                if (ErMg.Contains("The remote name could not be resolved") | ErMg.Contains("Unable to connect to the remote server"))
                {
                    if (ErMg.ToUpper().Contains("SERVICEUNAVAILABLE"))  //UnSucessfull Hit, Go For Retry
                    {
                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Thread.Sleep(1000);
                    }
                    if (Yut > 1)
                    {
                        string_24 = "retry";
                    }
                    else
                        goto Lbl_09;
                }
                else if (ErMg.Contains("The request was aborted: Could not create SSL/TLS secure channel."))
                {
                    Thread.Sleep(1000);
                    if (Yut > 2)
                    {
                        string_24 = "retry";
                    }
                    else
                        goto Lbl_09;
                }
                else if (ErMg.Contains("The underlying connection was closed:"))
                {
                    this.class3_0.token = "";
                    if (ErMg.Contains("An unexpected error occurred on a send"))
                    {

                    }
                    else if (ErMg.Contains("A connection that was expected to be kept alive was closed by the server") || ErMg.Contains("An unexpected error occurred on a receive")) //UnSucessfull Hit, Go for Retry With new Token
                    {

                    }
                    else
                    {

                    }
                    string_24 = "new:retry";
                }
                else
                {
                    this.class3_0.token = "";
                    /*method_88NgetTokenRegen(ref this.class3_0.token, ref this.response);
                    if (Errochk4_App(this.response, ref errormsg, ref errormsg))
                    {

                    }*/
                    if (ErMg.Contains("The operation has timed out"))  //Sucessfull Hit, Go for Next Thread With new Token
                    {
                        string_24 = "new:goahead";
                    }
                    else if (ErMg.Contains("(406) Not Acceptable"))
                    {                                                        //Sucessfull Hit, But RequestError Occured, Go For Out
                        string_24 = "new:retry";
                    }
                    else if (ErMg.Contains("(401) Unauthorized"))
                    {                                                        //Sucessfull Hit, But RequestError Occured, Go For Out
                        string_24 = resp;
                    }
                    else if (ErMg.Contains("(400) Bad Request"))
                    {                                                        //Sucessfull Hit, But RequestError Occured, Go For Out
                        string_24 = resp;
                    }
                    else if (ErMg.Contains("(404) Not Found") | ErMg.Contains("(409) Conflict"))         //Go For Exit
                    {
                        string_24 = resp;
                    }
                    else if (ErMg.Contains("(500) Internal Server Error"))
                    {
                        string_24 = "new:retry";
                    }
                    else if (ErMg.Contains("(502) Bad Gateway"))        //UnSucessfull Hit, Go For Retry With New Token
                    {
                        string_24 = "new:retry";
                    }
                    else if (ErMg.Contains("(503) Server Unavailable"))  //UnSucessfull Hit, Go For Retry With New Token
                    {
                        ErMg = ("A connection that was expected to be kept alive was closed by the server");
                        string_24 = "new:retry";
                    }
                    else if (ErMg.Contains("(504) Gateway Timeout"))  //UnSucessfull Hit, Go For Retry With Same Token
                    {
                        string_24 = "new:retry";
                    }
                    else
                    {                                                    //Sucessfull Hit, Go for Next Thread With new Token
                        string_24 = "new:goahead";
                    }
                }
                if (!string.IsNullOrEmpty(jtoken))
                    this.class3_0.token = jtoken;
                string_25 = "<StatusCode>" + httpStatusCode.ToString() + "</StatusCode>\t<ErrorCode>" + ErMg + "</ErrorCode>\t<ResponseCode>" + resp + "</ResponseCode>";
            }
            catch (Exception exception2)
            {
                flag2 = false;
                string_25 = exception2.Message;
            }
            finally
            {
                try
                {
                    if (response != null)
                    {
                        response.Close();
                    }
                }
                catch
                { }
            }
            //-------------Site to Check----------------??
            return flag2;
        }
        private bool ConnectHttp(string _url, string _data, string _reff, int SLOT, ref WebProxy webProxy_5, ref CookieContainer _cookie, bool bool_63, bool bool_64, int int_28, int int_29, ref string _reponse, ref string _Error, ref WebException webExcep_, string _Type_)
        {
            int num = 0;
            long_0 = long_1;
            string text = "";
            if (bool_21)
            {
                bool_21 = false;
            }
            string ip1b = "";
            dateTime_0 = DateTime.Now;
            _Type_ = Request_Type;
            while (true)
            {
                if (_url.Contains("www.irctc"))
                {
                    _url = _url.Replace("www", "www.contents");
                }
                bool flag = false;
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                _Error = "";
                _reponse = "";
                webExcep_ = null;
                bool result = false;
                HttpWebResponse httpWebResponse = null;
                string text2 = "";
                try
                {
                    dateTime_3 = DateTime.Now;
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(_url);
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    RequestCachePolicy requestCachePolicy5 = (httpWebRequest.CachePolicy = new HttpRequestCachePolicy(HttpCacheAgeControl.MaxAge, TimeSpan.FromDays(0.0)));
                    RequestCachePolicy requestCachePolicy2 = requestCachePolicy5;
                    RequestCachePolicy requestCachePolicy3 = requestCachePolicy2;
                    HttpRequestCachePolicy httpRequestCachePolicy = (HttpRequestCachePolicy)requestCachePolicy3;
                    ServicePointManager.ServerCertificateValidationCallback = CheckCertificate11;
                    ServicePointManager.Expect100Continue = false;
                    httpWebRequest.ProtocolVersion = HttpVersion.Version11;
                    httpWebRequest.Timeout = int_28;
                    httpWebRequest.ReadWriteTimeout = int_29;
                    httpWebRequest.Proxy = webProxy_5;
                    httpWebRequest.KeepAlive = true;
                    httpWebRequest.Connection = "keepalive";
                    httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
                    httpWebRequest.ConnectionGroupName = ConnectionGroupName_;
                    httpWebRequest.CookieContainer = _cookie;
                    httpWebRequest.UserAgent = "Mozilla/5.0 (Linux; Android 7.0; SM-G925F Build/LMY47X; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/55.0.2883.91 Mobile Safari/537.36";
                    httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                    httpWebRequest.AllowAutoRedirect = false;
                    httpWebRequest.Headers.Add("bmirak", "iosbm");
                    if (_url.Contains("secure.paytm.in/oltp-web/processTransaction") && _data.Contains("MSISDN"))
                    {
                        httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                        httpWebRequest.Headers.Set("X-Requested-With", "cris.org.in.prs.ima");
                        httpWebRequest.UserAgent = "Mozilla/5.0 (Linux; Android 7.0; SM-G925F Build/LMY47X; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/55.0.2883.91 Mobile Safari/537.36";
                        httpWebRequest.Headers.Set("Accept-Language", "en-GB,en-US;q=0.8");
                        httpWebRequest.Headers.Set("Origin", "null");
                    }
                    if (_Type_ == "Bank")
                    {
                        httpWebRequest.Headers.Set("Accept-Language", "en-US,en;q=0.8");
                        httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*;q=0.8";
                        httpWebRequest.UserAgent = "Mozilla/5.0 (Linux; Android 7.0; SM-G935F Build/NRD90M; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/55.0.2883.91 Mobile Safari/537.36";
                    }
                    if ((_Type_ != "Bank") & (_Type_ != "pay"))
                    {
                        httpWebRequest.Accept = "application/json";
                        if (_Type_ != "Login")
                        {
                            httpWebRequest.Headers.Set("greq", greq);
                            httpWebRequest.Headers.Set("mup", mup);
                        }
                    }
                    if (_Type_ == "pay")
                    {
                        httpWebRequest.UserAgent = "Dalvik/2.1.0 (Linux; U; Android 6.0.1; SM-J500F Build/MMB29M)";
                        httpWebRequest.AllowAutoRedirect = true;
                    }
                    if ((_Type_ == "validateUser") | (_Type_ == "GetTrain"))
                    {
                        httpWebRequest.Headers.Add("Authorization", _Authrization);
                        httpWebRequest.Headers.Add("dss", jwtToken);
                    }
                    if (_Type_ == "Logincnf")
                    {
                        httpWebRequest.ContentType = "text/plain";
                        httpWebRequest.Accept = "text/plain";
                        httpWebRequest.Headers.Add("Authorization", _Authrization);
                    }
                    if (_Type_ == "Login")
                    {
                        if (!string.IsNullOrEmpty(bmiyek))
                        {
                            httpWebRequest.Headers.Add("bmiyek", bmiyek);
                        }
                        else
                        {
                            httpWebRequest.Headers.Add("bmiyek", "503B5A301D61637237D3DA71CA080E56");
                        }
                        httpWebRequest.Accept = "*/*";
                        httpWebRequest.Headers.Add("Authorization", "Basic " + _Authrization);
                    }
                    if (_Type_ == "air")
                    {
                        httpWebRequest.UserAgent = "Mozilla/5.0 (Linux; Android 8.0.0; SM-G570F Build/R16NW; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/110.0.5481.65 Mobile Safari/537.36";
                        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                        httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7";
                        httpWebRequest.Headers.Add("X-Requested-With", "cris.org.in.prs.ima");
                    }
                    if (!string.IsNullOrEmpty(_reff))
                    {
                        httpWebRequest.Referer = _reff;
                    }
                    if (_Type_ == "json")
                    {
                        httpWebRequest.ContentType = "application/json; charset=UTF-8";
                        httpWebRequest.Accept = "application/json";
                        httpWebRequest.Headers.Add("content-language", "en");
                        httpWebRequest.Headers.Add("Authorization", _Authrization);
                        httpWebRequest.Headers.Add("dss", jwtToken);
                    }
                    if (_Type_ == "Plain135text")
                    {
                        httpWebRequest.ContentType = "text/plain";
                        httpWebRequest.Accept = "text/plain";
                        httpWebRequest.Headers.Add("Authorization", _Authrization);
                        httpWebRequest.Headers.Add("dss", jwtToken);
                        httpWebRequest.Headers.Set("greq", greq);
                    }
                    if (!string.IsNullOrEmpty(_data))
                    {
                        httpWebRequest.Method = "POST";
                        byte[] bytes = Encoding.UTF8.GetBytes(_data);
                        httpWebRequest.ContentLength = bytes.Length;
                        httpWebRequest.GetRequestStream().Write(bytes, 0, bytes.Length);
                    }
                    else
                    {
                        httpWebRequest.Method = "GET";
                    }
                    httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    if (flag && (httpWebResponse.StatusCode == HttpStatusCode.Found || httpWebResponse.StatusCode == HttpStatusCode.MovedPermanently) && httpWebResponse.Headers["Location"].ToString().Contains("error") && num < 20)
                    {
                        Thread.Sleep(200);
                        num++;
                        httpWebResponse.Close();
                        httpWebResponse = null;
                        continue;
                    }
                    if (bool_22)
                    {
                        if (httpWebResponse.Headers["Date"] != null)
                            dateTime_1 = DateTime.Parse(httpWebResponse.Headers["Date"]);
                    }
                    if (bool_24)
                    {
                        string_29 = httpWebResponse.ResponseUri.ToString();
                    }
                    using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                    {
                        if (bool_64)
                        {
                            text2 = streamReader.ReadToEnd();
                        }
                        else
                        {
                            httpWebRequest.Abort();
                        }
                    }
                    if (_Type_ == "Logincnf")
                    {
                        keyFromServer = text2;
                    }
                    if (httpWebResponse != null)
                    {
                        try
                        {
                            if (httpWebResponse.Headers["X-Request-For"] != null)
                            {
                                text = httpWebResponse.Headers["X-Request-For"].ToString().Trim();
                                jwtToken = jwtutils.createJwtToken(randomGeneratedKey, keyFromServer, greq, text);
                            }
                        }
                        catch
                        {
                            _reponse = "Check Internet Connection";
                            return true;
                        }
                    }
                    if (httpWebResponse != null)
                    {
                        if (httpWebResponse.Headers["Date"] != null)
                            dateTime_1 = DateTime.Parse(httpWebResponse.Headers["Date"]);
                    }
                    _reponse = text2;
                    if (string.IsNullOrEmpty(_reponse))
                    { }
                    if (_reponse.Contains("Unable to serve this request"))
                    {
                        continue;
                    }
                    result = true;
                    stopwatch.Stop();
                    long_1 = stopwatch.ElapsedMilliseconds;
                    return result;
                }
                catch (WebException ex)
                {
                    WebException ex2 = (webExcep_ = ex);
                    string text3 = "";
                    string text4 = ex2.Message;
                    HttpStatusCode httpStatusCode = HttpStatusCode.OK;
                    if (ex2.Response != null)
                    {
                        try
                        {
                            text3 = ":" + new StreamReader(ex2.Response.GetResponseStream()).ReadToEnd();
                            if (ex2.Response.Headers["X-Request-For"] != null)
                            {
                                text = ex2.Response.Headers["X-Request-For"].ToString().Trim();
                                jwtToken = jwtutils.createJwtToken(randomGeneratedKey, keyFromServer, greq, text);
                            }
                        }
                        catch
                        {
                        }
                        httpStatusCode = ((HttpWebResponse)ex2.Response).StatusCode;
                    }
                    if (text4.Contains("DOWNTIME MESSAGE"))
                    {
                        _reponse = text4;
                        return true;
                    }
                    if (text4.Contains("The remote server returned an error: (407) Proxy Authentication Required") | text4.Contains("The remote name could not be resolved:") | text4.Contains("This site can’t be reached") | text4.Contains("The operation has timed out") | text4.Contains("Unable to connect to") | text.Contains("The remote server returned an error: (410) Gone") | text.Contains("The remote server returned an error: (403) Forbidden"))
                    {
                        continue;
                    }
                    if (num > 3 | text4.Contains("The server committed a protocol violation"))
                    {
                        continue;
                    }
                    _reponse = text3;
                    if (text4.Contains("(503) Server Unavailable"))
                    {
                        num++;
                        if (num < 20)
                        {
                            Thread.Sleep(200);
                            continue;
                        }
                        return false;
                    }
                    if (text4.Contains("Your earlier session has expired"))
                    {
                        _reponse = "relogin";
                    }
                    if (text4.Contains("The remote name could not be resolved") | text4.Contains("Unable to connect to the remote server"))
                    {
                        if (text4.ToUpper().Contains("SERVICEUNAVAILABLE"))
                        {
                            Thread.Sleep(2000);
                            _reponse = "retry";
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            _reponse = "retry";
                        }
                        goto IL_0de1;
                    }
                    if (text4.Contains("The underlying connection was closed:"))
                    {
                        if (text4.Contains("An unexpected error occurred on a send"))
                        {
                            _reponse = "retry";
                            continue;
                        }
                        if (!text4.Contains("A connection that was expected to be kept alive was closed by the server") && !text4.Contains("An unexpected error occurred on a receive"))
                        {
                            _reponse = "retry";
                            continue;
                        }
                        _reponse = "retry";
                        if (string.IsNullOrEmpty(text))
                        {
                            _reponse = "new:retry";
                        }
                        goto IL_0de1;
                    }
                    if (text4.Contains("The request was aborted: Could not create SSL/TLS secure channel."))
                    {
                        _reponse = "retry";
                        goto IL_0de1;
                    }
                    if (text4.Contains("Server error") || text4.Contains("Bad Gateway"))
                    {
                        _reponse = "retry";
                        continue;
                    }
                    if (text4.Contains("The operation has timed out"))
                    {
                        if (string.IsNullOrEmpty(text))
                        {
                            _reponse = "new:goahead";
                        }
                    }
                    else if (text4.Contains("(400) Bad Request"))
                    {
                        _reponse = text3;
                    }
                    else if (text4.Contains("(401) Unauthorized"))
                    {
                        _reponse = text3;
                    }
                    else if (text4.Contains("(404) Not Found"))
                    {
                        _reponse = text3;
                    }
                    else if (text4.Contains("(406) Not Acceptable"))
                    {
                        _reponse = text3;
                        _reponse = "new:retry";
                        if (text3.Contains("evaluation time"))
                        {
                            try
                            {
                                string text5 = text3.Substring(text3.IndexOf("evaluation time NumericDate"));
                                text5 = text5.Substring(text5.IndexOf("->") + 3);
                                text5 = text5.Substring(0, text5.IndexOf("IST") - 1);
                                DateTime dateTime = DateTime.ParseExact(text5, "MMM d, yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                                string string_ = dateTime.ToString("M-d-yyyy").Replace(dateTime.Year.ToString(), (dateTime.Year % 100).ToString());
                                string string_2 = dateTime.ToString("hh:mm:ss tt");
                                method_20(string_);
                                method_21(string_2);
                            }
                            catch
                            {
                            }
                        }
                    }
                    else if (text4.Contains("(409) Conflict"))
                    {
                        _reponse = text3;
                    }
                    else if (text4.Contains("(415) Unsupported Media Type"))
                    {
                        _reponse = text3;
                    }
                    else if (text4.Contains("(500) Internal Server Error"))
                    {
                        _reponse = "retry";
                        _reponse = "new:goahead";
                    }
                    else if (text4.Contains("(502) Bad Gateway"))
                    {
                        _reponse = "retry";
                        _reponse = "new:retry";
                    }
                    else if (text4.Contains("(503) Server Unavailable"))
                    {
                        _reponse = "new:retry";
                        text4 = "A connection that was expected to be kept alive was closed by the server";
                    }
                    else if (text4.Contains("(504) Gateway Timeout"))
                    {
                        _reponse = "retry";
                    }
                    else if (string.IsNullOrEmpty(text))
                    {
                        _reponse = "new:goahead";
                    }
                    goto IL_0de1;
                IL_0de1:
                    _Error = "<StatusCode>" + httpStatusCode.ToString() + "</StatusCode>\t<ErrorCode>" + text4 + "</ErrorCode>\t<ResponseCode>" + text3 + "</ResponseCode>";
                    return result;
                }
                catch (Exception ex3)
                {
                    _Error = ex3.Message;
                    return result;
                }
                finally
                {
                    try
                    {
                        httpWebResponse?.Close();
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void method_20(string string_86)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.UseShellExecute = false;
                processStartInfo.WorkingDirectory = "C:\\Windows\\System32";
                processStartInfo.CreateNoWindow = true;
                processStartInfo.FileName = "C:\\Windows\\System32\\cmd.exe";
                processStartInfo.Verb = "runas";
                processStartInfo.Arguments = "/C date " + string_86;
                try
                {
                    Process.Start(processStartInfo);
                }
                catch
                {
                }
            }
            catch
            {
            }
        }

        private void method_21(string string_86)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.UseShellExecute = false;
                processStartInfo.WorkingDirectory = "C:\\Windows\\System32";
                processStartInfo.CreateNoWindow = true;
                processStartInfo.FileName = "C:\\Windows\\System32\\cmd.exe";
                processStartInfo.Verb = "runas";
                processStartInfo.Arguments = "/C time " + string_86;
                try
                {
                    Process.Start(processStartInfo);
                }
                catch
                {
                }
            }
            catch
            {
            }
        }
        internal bool ConnectHttp_00(string url, string postdata, string reff, WebProxy webProxy_3, CookieContainer cookieContainer_1, bool bool_CContainer, bool bool_26, int int_timeout, int int_RWtimeout, string response, string errormsg, WebException webException_1, string type, string greq, string bearer, string jwtToken, string X_Request_For)
        {
            bool result;
            int num2 = 0;
            int Yut = 0;
        Lbl_09:
            Yut++;
            bool flag2 = false;
            bool flag3 = false;
            bool flag4 = false;
            errormsg = "";
            response = "";
            webException_1 = null;
            result = false;
            byte[] bytes = null;
            HttpWebResponse httpWebResponse = null;
            HttpWebRequest httpWebRequest = null;
            string text = "";
            try
            {
                HttpRequestCachePolicy Defpolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Default);
                HttpRequestCachePolicy noCachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
                HttpRequestCachePolicy policy = new HttpRequestCachePolicy(HttpCacheAgeControl.MaxAge, TimeSpan.FromDays(0.0));
                var uri = new Uri(url);
                httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.CachePolicy = noCachePolicy;
                httpWebRequest.ProtocolVersion = HttpVersion.Version11;
                httpWebRequest.Proxy = webProxy_3;
                httpWebRequest.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
                httpWebRequest.Timeout = int_timeout;
                httpWebRequest.ReadWriteTimeout = int_RWtimeout;
                httpWebRequest.CookieContainer = cookieContainer_1;
                httpWebRequest.UserAgent = "Mozilla/5.0 (Windows T 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.AllowAutoRedirect = false;
                httpWebRequest.Connection = "keepalive";
                string cookytt = "";
                bool flag477 = cookieContainer_1 != null;
                if (flag477)
                {
                    foreach (Cookie tempCookie in cookieContainer_1.GetCookies(uri))
                    {
                        string A = tempCookie.Name + "=" + tempCookie.Value;
                        cookytt += A + "&&";
                    }
                    //if (cookytt != "")
                    //this.Cookieklist = cookytt;
                }
                if (type == "Bank")
                {
                    httpWebRequest.Headers.Set("Accept-Language", "en-US,en;q=0.8");
                    httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                    httpWebRequest.UserAgent = "Mozilla/5.0 (Linux; Android 7.0; SM-G935F Build/NRD90M; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/55.0.2883.91 Mobile Safari/537.36";
                }
                if (!string.IsNullOrEmpty(reff))
                {
                    httpWebRequest.Referer = reff;
                }
                if (postdata != null)
                {
                    httpWebRequest.Method = "POST";
                    bytes = Encoding.UTF8.GetBytes(postdata);
                    httpWebRequest.ContentLength = (long)bytes.Length;
                    using (Stream requestStream = httpWebRequest.GetRequestStream())
                    {
                        requestStream.Write(bytes, 0, bytes.Length);
                    }
                }
                else
                {
                    httpWebRequest.Method = "PUT";
                }
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                if (flag2 && (httpWebResponse.StatusCode == HttpStatusCode.Found || httpWebResponse.StatusCode == HttpStatusCode.MovedPermanently) && httpWebResponse.Headers["Location"].ToString().Contains("error") && num2 < 20)
                {
                    Thread.Sleep(200);
                    num2++;
                    httpWebResponse.Close();
                    httpWebResponse = null;
                    goto Lbl_09;
                }
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    if (bool_26)
                    {
                        text = streamReader.ReadToEnd();
                    }
                    else
                    {
                        httpWebRequest.Abort();
                    }
                }
                response = text;
                result = true;
            }
            catch (WebException ex)
            {
                result = false;
                webException_1 = ex;
                var resp = "";
                string jtoken = "";
                int statusCode = 200;
                string ErMg = ex.Message;
                HttpStatusCode httpStatusCode = (HttpStatusCode)statusCode;
                if (ex.Response != null)
                {
                    try
                    {
                        resp = ":" + new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                        if (ex.Response.Headers["X-Request-For"] != null)
                        {
                            jtoken = ex.Response.Headers["X-Request-For"].ToString().Trim();
                        }
                    }
                    catch { }
                    httpStatusCode = ((HttpWebResponse)ex.Response).StatusCode;
                }
                flag3 = true;
                response = resp;
                Thread.Sleep(100);
                if (ErMg.Contains("The remote name could not be resolved") | ErMg.Contains("Unable to connect to the remote server"))
                {

                }
                else if (ErMg.Contains("The underlying connection was closed:") || ErMg.Contains("The request was aborted: Could not create SSL/TLS secure channel."))
                {
                    if (ErMg.Contains("An unexpected error occurred on a send")) //UnSucessfull Hit, Go For Retry
                    {
                    }
                    else if (ErMg.Contains("A connection that was expected to be kept alive was closed by the server") || ErMg.Contains("An unexpected error occurred on a receive")) //UnSucessfull Hit, Go for Retry With new Token
                    {
                    }
                    else
                    {
                    }
                    webProxy_3 = webProxy_Smart;
                    webProxy_3.BypassProxyOnLocal = true;
                    response = "new:retry";
                }
                else
                {
                    X_Request_For = "";
                    if (ErMg.Contains("The operation has timed out"))       //Sucessfull Hit, Go for Next Thread With new Token
                    {
                        response = "new:goahead";
                    }
                    else if (ErMg.Contains("(400) Bad Request"))
                    {                                                        //Sucessfull Hit, But RequestError Occured, Go For Out

                    }
                    else if (ErMg.Contains("(401) Unauthorized"))
                    {                                                        //Sucessfull Hit, But RequestError Occured, Go For Out

                    }
                    else if (ErMg.Contains("(404) Not Found"))               //Go For Exit
                    {

                    }
                    else if (ErMg.Contains("(406) Not Acceptable"))
                    {                                                        //Sucessfull Hit, But RequestError Occured, Go For Out

                        if (resp.Contains("evaluation time"))
                        {
                            try
                            {
                                string DtTm = resp.Substring(resp.IndexOf("evaluation time NumericDate"));
                                DtTm = DtTm.Substring(DtTm.IndexOf("->") + 3);
                                DtTm = DtTm.Substring(0, DtTm.IndexOf("IST") - 1);
                                DateTime jdte = DateTime.ParseExact(DtTm, "MMM d, yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                                string Dt = jdte.ToString("M-d-yyyy").Replace(jdte.Year.ToString(), (jdte.Year % 100).ToString());
                                string Tm = jdte.ToString("hh:mm:ss tt");
                                //setDate(Dt);  //"5-6-92"  M-d-YY
                                //setTime(Tm);  //"2:4:5 AM"
                            }
                            catch { }
                        }
                    }
                    else if (ErMg.Contains("(409) Conflict"))           //Go For Exit
                    {
                        response = resp;
                    }
                    else if (ErMg.Contains("(415) Unsupported Media Type"))
                    {                                                   //Sucessfull Hit, But RequestError Occured, Go For Out
                        response = resp;
                    }
                    else if (ErMg.Contains("(500) Internal Server Error"))
                    {
                        response = "new:retry";
                    }
                    else if (ErMg.Contains("(502) Bad Gateway"))        //UnSucessfull Hit, Go For Retry With New Token
                    {
                        response = "new:retry";
                    }
                    else if (ErMg.Contains("(503) Server Unavailable"))  //UnSucessfull Hit, Go For Retry With New Token
                    {
                        ErMg = ("A connection that was expected to be kept alive was closed by the server");
                        response = "new:retry";
                    }
                    else if (ErMg.Contains("(504) Gateway Timeout"))     //UnSucessfull Hit, Go For Retry With Same Token
                    {
                        response = "new:retry";
                    }
                    else
                    {                                                    //Sucessfull Hit, Go for Next Thread With new Token
                        response = "new:goahead";
                    }
                }
                errormsg = "<StatusCode>" + httpStatusCode.ToString() + "</StatusCode>\t<ErrorCode>" + ErMg + "</ErrorCode>\t<ResponseCode>" + resp + "</ResponseCode>";
            }
            catch (Exception ex2)
            {
                result = false;
                errormsg = ex2.Message;
            }
            finally
            {
                try
                {
                    if (httpWebResponse != null)
                    {
                        httpWebResponse.Close();
                    }
                }
                catch
                {
                }
            }
            return result;
        }
        internal async Task<bool> ConnectHttp_11(string url, string postdata, string reff, WebProxy webProxy_3, CookieContainer cookieContainer_1, bool bool_CContainer, bool bool_26, int int_timeout, int int_RWtimeout, string response, string errormsg, WebException webException_1, string type, string greq, string bearer, string jwtToken, string X_Request_For)
        {
            bool result;
            int num2 = 0;
            int Yut = 0;
        Lbl_09:
            Yut++;
            bool flag2 = false;
            bool flag3 = false;
            bool flag4 = false;
            errormsg = "";
            response = "";
            webException_1 = null;
            result = false;
            byte[] bytes = null;
            HttpWebResponse httpWebResponse = null;
            HttpWebRequest httpWebRequest = null;
            string text = "";
            try
            {
                HttpRequestCachePolicy Defpolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.Default);
                HttpRequestCachePolicy noCachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
                HttpRequestCachePolicy policy = new HttpRequestCachePolicy(HttpCacheAgeControl.MaxAge, TimeSpan.FromDays(0.0));
                var uri = new Uri(url);
                httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.CachePolicy = noCachePolicy;
                httpWebRequest.ProtocolVersion = HttpVersion.Version11;
                httpWebRequest.Proxy = webProxy_3;
                httpWebRequest.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
                httpWebRequest.Timeout = int_timeout;
                httpWebRequest.ReadWriteTimeout = int_RWtimeout;
                httpWebRequest.CookieContainer = cookieContainer_1;
                httpWebRequest.UserAgent = "Mozilla/5.0 (Windows T 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.AllowAutoRedirect = false;
                httpWebRequest.Connection = "keepalive";
                string cookytt = "";
                bool flag477 = cookieContainer_1 != null;
                if (flag477)
                {
                    foreach (Cookie tempCookie in cookieContainer_1.GetCookies(uri))
                    {
                        string A = tempCookie.Name + "=" + tempCookie.Value;
                        cookytt += A + "&&";
                    }
                    //if (cookytt != "")
                    //this.Cookieklist = cookytt;
                }
                if (type == "Bank")
                {
                    httpWebRequest.Headers.Set("Accept-Language", "en-US,en;q=0.8");
                    httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                    httpWebRequest.UserAgent = "Mozilla/5.0 (Linux; Android 7.0; SM-G935F Build/NRD90M; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/55.0.2883.91 Mobile Safari/537.36";
                }
                if (!string.IsNullOrEmpty(reff))
                {
                    httpWebRequest.Referer = reff;
                }
                if (postdata != null)
                {
                    httpWebRequest.Method = "POST";
                    bytes = Encoding.UTF8.GetBytes(postdata);
                    httpWebRequest.ContentLength = (long)bytes.Length;
                    using (Stream requestStream = httpWebRequest.GetRequestStream())
                    {
                        requestStream.Write(bytes, 0, bytes.Length);
                    }
                }
                else
                {
                    httpWebRequest.Method = "PUT";
                }
                httpWebResponse = (HttpWebResponse)await httpWebRequest.GetResponseAsync();
                if (flag2 && (httpWebResponse.StatusCode == HttpStatusCode.Found || httpWebResponse.StatusCode == HttpStatusCode.MovedPermanently) && httpWebResponse.Headers["Location"].ToString().Contains("error") && num2 < 20)
                {
                    Thread.Sleep(200);
                    num2++;
                    httpWebResponse.Close();
                    httpWebResponse = null;
                    goto Lbl_09;
                }
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    if (bool_26)
                    {
                        text = streamReader.ReadToEnd();
                    }
                    else
                    {
                        httpWebRequest.Abort();
                    }
                }
                response = text;
                result = true;
            }
            catch (WebException ex)
            {
                result = false;
                webException_1 = ex;
                var resp = "";
                string jtoken = "";
                int statusCode = 200;
                string ErMg = ex.Message;
                HttpStatusCode httpStatusCode = (HttpStatusCode)statusCode;
                if (ex.Response != null)
                {
                    try
                    {
                        resp = ":" + new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                        if (ex.Response.Headers["X-Request-For"] != null)
                        {
                            jtoken = ex.Response.Headers["X-Request-For"].ToString().Trim();
                        }
                    }
                    catch { }
                    httpStatusCode = ((HttpWebResponse)ex.Response).StatusCode;
                }
                flag3 = true;
                response = resp;
                Thread.Sleep(100);
                if (ErMg.Contains("The remote name could not be resolved") | ErMg.Contains("Unable to connect to the remote server"))
                {

                }
                else if (ErMg.Contains("The underlying connection was closed:") || ErMg.Contains("The request was aborted: Could not create SSL/TLS secure channel."))
                {
                    if (ErMg.Contains("An unexpected error occurred on a send")) //UnSucessfull Hit, Go For Retry
                    {
                    }
                    else if (ErMg.Contains("A connection that was expected to be kept alive was closed by the server") || ErMg.Contains("An unexpected error occurred on a receive")) //UnSucessfull Hit, Go for Retry With new Token
                    {
                    }
                    else
                    {
                    }
                    webProxy_3 = webProxy_Smart;
                    webProxy_3.BypassProxyOnLocal = true;
                    response = "new:retry";
                }
                else
                {
                    X_Request_For = "";
                    if (ErMg.Contains("The operation has timed out"))       //Sucessfull Hit, Go for Next Thread With new Token
                    {
                        response = "new:goahead";
                    }
                    else if (ErMg.Contains("(400) Bad Request"))
                    {                                                        //Sucessfull Hit, But RequestError Occured, Go For Out

                    }
                    else if (ErMg.Contains("(401) Unauthorized"))
                    {                                                        //Sucessfull Hit, But RequestError Occured, Go For Out

                    }
                    else if (ErMg.Contains("(404) Not Found"))               //Go For Exit
                    {

                    }
                    else if (ErMg.Contains("(406) Not Acceptable"))
                    {                                                        //Sucessfull Hit, But RequestError Occured, Go For Out

                        if (resp.Contains("evaluation time"))
                        {
                            try
                            {
                                string DtTm = resp.Substring(resp.IndexOf("evaluation time NumericDate"));
                                DtTm = DtTm.Substring(DtTm.IndexOf("->") + 3);
                                DtTm = DtTm.Substring(0, DtTm.IndexOf("IST") - 1);
                                DateTime jdte = DateTime.ParseExact(DtTm, "MMM d, yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                                string Dt = jdte.ToString("M-d-yyyy").Replace(jdte.Year.ToString(), (jdte.Year % 100).ToString());
                                string Tm = jdte.ToString("hh:mm:ss tt");
                                //setDate(Dt);  //"5-6-92"  M-d-YY
                                //setTime(Tm);  //"2:4:5 AM"
                            }
                            catch { }
                        }
                    }
                    else if (ErMg.Contains("(409) Conflict"))           //Go For Exit
                    {
                        response = resp;
                    }
                    else if (ErMg.Contains("(415) Unsupported Media Type"))
                    {                                                   //Sucessfull Hit, But RequestError Occured, Go For Out
                        response = resp;
                    }
                    else if (ErMg.Contains("(500) Internal Server Error"))
                    {
                        response = "new:retry";
                    }
                    else if (ErMg.Contains("(502) Bad Gateway"))        //UnSucessfull Hit, Go For Retry With New Token
                    {
                        response = "new:retry";
                    }
                    else if (ErMg.Contains("(503) Server Unavailable"))  //UnSucessfull Hit, Go For Retry With New Token
                    {
                        ErMg = ("A connection that was expected to be kept alive was closed by the server");
                        response = "new:retry";
                    }
                    else if (ErMg.Contains("(504) Gateway Timeout"))     //UnSucessfull Hit, Go For Retry With Same Token
                    {
                        response = "new:retry";
                    }
                    else
                    {                                                    //Sucessfull Hit, Go for Next Thread With new Token
                        response = "new:goahead";
                    }
                }
                errormsg = "<StatusCode>" + httpStatusCode.ToString() + "</StatusCode>\t<ErrorCode>" + ErMg + "</ErrorCode>\t<ResponseCode>" + resp + "</ResponseCode>";
            }
            catch (Exception ex2)
            {
                result = false;
                errormsg = ex2.Message;
            }
            finally
            {
                try
                {
                    if (httpWebResponse != null)
                    {
                        httpWebResponse.Close();
                    }
                }
                catch
                {
                }
            }
            return result;
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public static string DecryptRJ256(string prm_key, string prm_iv, string prm_text_to_decrypt)
        {
            try
            {
                ICryptoTransform cryptoTransform = new RijndaelManaged
                {
                    Padding = PaddingMode.Zeros,
                    Mode = CipherMode.CBC,
                    KeySize = 256,
                    BlockSize = 256
                }.CreateDecryptor(Encoding.ASCII.GetBytes(prm_key), Encoding.ASCII.GetBytes(prm_iv));
                byte[] array = Convert.FromBase64String(prm_text_to_decrypt);
                byte[] array2 = new byte[array.Length];
                new CryptoStream(new MemoryStream(array), cryptoTransform, 0).Read(array2, 0, array2.Length);
                return Encoding.ASCII.GetString(array2);
            }
            catch
            {
            }
            return "#";
        }
        public static string EncryptRJ256(string prm_key, string prm_iv, string prm_text_to_encrypt)
        {
            ICryptoTransform cryptoTransform = new RijndaelManaged
            {
                Padding = PaddingMode.Zeros,
                Mode = CipherMode.CBC,
                KeySize = 256,
                BlockSize = 256
            }.CreateEncryptor(Encoding.ASCII.GetBytes(prm_key), Encoding.ASCII.GetBytes(prm_iv));
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
            byte[] bytes = Encoding.ASCII.GetBytes(prm_text_to_encrypt);
            cryptoStream.Write(bytes, 0, bytes.Length);
            cryptoStream.FlushFinalBlock();
            return Convert.ToBase64String(memoryStream.ToArray());
        }
    }
}
