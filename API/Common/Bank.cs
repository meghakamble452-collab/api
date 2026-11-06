using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Globalization;
using System.IO;
using System.Net.Cache;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using API.Controllers;
using System.Web.Routing;
using System.Net.Security;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Drawing;
using System.Security.Policy;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Web.Http.Results;
using Image = System.Drawing.Image;
using NativeCSharpJWTToken;
using Microsoft.VisualBasic.ApplicationServices;
using System.Web.Services.Description;
using Org.BouncyCastle.Utilities;
using Strings = Microsoft.VisualBasic.Strings;
using System.Net.NetworkInformation;

namespace API.Common
{
    public class Bank
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
        internal WebProxy webProxy_3;
        private bool bool_28;
        private object result;
        string string_93 = "";
        string string_94 = "";

        public Bank()
        {
            string AdminIP = "in.smartproxy.com||10000||sph5n06d99||7bwovWwh6fHIVgwc67";
            string[] array = AdminIP.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
            webProxy_Smart = new WebProxy(array[0], int.Parse(array[1]));
            webProxy_Smart.Credentials = new NetworkCredential(array[2], array[3]);
        }

        public cls02 VerifyResponse(RequestBody BodyResponse)
        {
            String softid = BodyResponse.user;
            String encdata = BodyResponse.enc;
            String card = BodyResponse.card;
            String url = BodyResponse.url;
            String bank = BodyResponse.bank;
            String validaturl = BodyResponse.id;
            String macid = BodyResponse.mac;
            string userID = BodyResponse.irctcID;
            string pwd = BodyResponse.irctcPass;
            string action1 = BodyResponse.Action;
            string referal = BodyResponse.referal;
            string errMessage = BodyResponse.Data;
            String serial = BodyResponse.serial;
            String otpid1 = BodyResponse.otpid;
            String otptoken1 = BodyResponse.otptoken;
            String amount = BodyResponse.amount;
            cls02 cls020 = new cls02();
            if (action1.Contains("ProcessBank"))
            {
                cls020.RequestToken = HDFC_DC(encdata, card, url, bank, action1, referal, amount, otptoken1, validaturl, ref errMessage);
            }
            else
            {
                
            }
            cls020.status = "Success";
            return cls020;
        }
        internal string HDFC_DC(string enc, string card, string url, string bank, string action1, string referal, string amount, string token, string valurl, ref string errMessage)
        {
            try
            {
                uint num;
                string response = "";
                class3_0 = new ReadyPost();
                string Host = "https://www.irctc.co.in";
                string VT = errMessage;
                int num1 = DateTime.Now.Hour * 10000;
                int num2 = DateTime.Now.Minute * 100;
                int num3 = num1 + num2;
                int second = DateTime.Now.Second;
                long num4 = (long)(num3 + second);
                Host = "https://www.irctc.co.in";
                string Profile = "", add = "";
                add = Host;
                if (action1.Contains("ProcessBankipay"))
                {
                    string_90 = "";
                    string_91 = "";
                    string_88 = bank.ToUpper();
                    string_72 = "";
                    response = string_86;
                    string text = string_88;
                    string[] array = card.Split(new string[1] { "||" }, StringSplitOptions.None);
                    string cardno = array[0].Trim();
                    string exmonth = array[1];
                    string exyear = array[2];
                    string atmpin = array[3];
                    string cvv = array[4];
                    string cardtype = array[5];
                    string name = array[6];
                    string dphh = array[7];
                    postdata = enc;
                    String text7;
                    string text6 = "";
                    if (string_88.Contains("_DC") || string_88.Contains("_CC"))
                    {
                        text7 = "DC";
                        string_52 = "Tls12";
                        bool result;
                        if (!_Request(url, postdata, referal, webProxy_1, ref cookieContainer_1, bool_63: true, bool_64: true, 60000, 60000, ref response, ref errormsg, ref webException_0))
                        {
                            result = false;
                        }
                        postdata = Method_SerialInp(response, ref url, bool_14: false);
                        string text12 = postdata.Substring(postdata.IndexOf("customToken") + 12);
                        url = "https://www.irctcipay.com/pgui/jsp/binResolver";
                        string text21 = card.Substring(0, 9);
                        postdata = "token=" + text12 + "&bin=" + text21;
                        if (!_Request(url, postdata, Reffral, webProxy_1, ref cookieContainer_1, bool_63: true, bool_64: true, 60000, 60000, ref response, ref errormsg, ref webException_0))
                        {
                        }
                        string text22 = method_103(response, "mopType", ":", ",").Replace("\"", "");
                        string text23 = method_103(response, "paymentType", ":", ",").Replace("\"", "");
                        if (text7 == "DC")
                        {
                            string str2 = cardno.Substring(0, 4) + " " + cardno.Substring(4, 4) + " " + cardno.Substring(8, 4) + " " + cardno.Substring(12, 4);
                            postdata = "paymentType=" + text23 + "&mopType=" + text22 + "&issuerBankName=&issuerCountry=&cardHolderType=&paymentsRegion=&cardNumber=" + HttpUtility.UrlEncode(str2) + "&expiryYear=" + exyear + "&expiryMonth=" + exmonth + "&cvvNumber=" + cvv + "&cardName=" + HttpUtility.UrlEncode(name) + "&amount=" + amount + "&customToken=" + text12 + "&cardsaveflag=false";
                        }
                        else if (text7 == "CC")
                        {
                            string str3 = cardno.Substring(0, 4) + " " + cardno.Substring(4, 4) + " " + cardno.Substring(8, 4) + " " + cardno.Substring(12, 4);
                            postdata = "paymentType=" + text23 + "&mopType=" + text22 + "&issuerBankName=&issuerCountry=&cardHolderType=&paymentsRegion=&cardNumber=" + HttpUtility.UrlEncode(str3) + "&expiryYear=" + exyear + "&expiryMonth=" + exyear + "&cvvNumber=" + cvv + "&cardName=" + HttpUtility.UrlEncode(name) + "&cardsaveflag1=on&amount=" + amount + "&customToken=" + text12 + "&cardsaveflag=false";
                        }
                        CookieContainer cookieContainer_;
                        url = "https://www.irctcipay.com/pgui/jsp/pay";
                        string_52 = "Tls12";
                        if (!_Request(url, postdata, Reffral, webProxy_1, ref cookieContainer_1, bool_63: true, bool_64: true, 60000, 60000, ref response, ref errormsg, ref webException_0))
                        {                           
                        }
                        if (exmonth.Length < 2)
                        {
                            exmonth = "0" + exmonth;
                        }
                        if ((text == "HDFC_DC") | text.Contains("HDFC_CC"))
                        {
                            text6 = "21";
                        }
                        else if ((text == "SBI_DC") | text.Contains("SBI_CC"))
                        {
                            text6 = "101";
                        }
                        else if (text.Contains("AIRTEL_CC"))
                        {
                            text6 = "102";
                        }
                        else if (text.Contains("KOTAK_"))
                        {
                            text6 = "KOTAK_DC";
                        }
                        else if (text.Contains("PAYZAP_"))
                        {
                            text6 = "103";
                        }
                        cookieContainer_ = null;
                        String text15 = text6;
                        num = smethod_0(text15);
                        if (num <= 1781929964)
                        {
                        }
                        else
                        {
                            switch (num)
                            {
                                case 2364708844u:
                                    if (text15 == "21")
                                    {
                                        method_174(response, string_94, cookieContainer_, dphh, ref response, ref string_91);
                                    }
                                    break;
                            }
                        }
                        postdata = Method_SerialInp(response, ref url, bool_14: false);
                        if (!_Request(url, postdata, Reffral, webProxy_1, ref cookieContainer_1, bool_63: true, bool_64: true, 60000, 60000, ref response, ref errormsg, ref webException_0))
                        {
                            
                        }
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                return "Error@Exception";
            }
        }

        private void method_174(string response1, object string_94, CookieContainer cookieContainer_, object string_93, ref string response2, ref string string_91)
        {
            throw new NotImplementedException();
        }

        private bool method_174(string string_86, string string_87, CookieContainer cookieContainer_2, string string_88, ref string string_89, ref string string_90)
        {
            string string_91 = "";
            string string_92 = "";
            string text = string_86;
            string string_93 = text;
            bool flag = false;
            bool result;
            if (text.IndexOf("netsafe.hdfcbank.com") >= 0)
            {
                bool flag2 = true;
                while (true)
                {
                    try
                    {
                        text = Method_SerialInp(string_86, ref string_91, bool_14: true);
                        if (!_Request(string_91, text, string_87, webProxy_3, ref cookieContainer_2, bool_63: true, bool_64: true, 60000, 60000, ref string_93, ref string_92, ref webException_0))
                        {
                            string text2 = cookieContainer_2?.ToString() + " Gateway not working - Payment Failed";
                            result = flag;
                            break;
                        }
                        string_87 = string_91;
                        string text3 = "https://netsafe.hdfcbank.com";
                        while (true)
                        {
                            if ((string_93.IndexOf("Enter OTP") > 0) & (string_88 != ""))
                            {
                                int startIndex = string_93.IndexOf("randomDigit");
                                startIndex = string_93.IndexOf("\"", startIndex) + 1;
                                int num = string_93.IndexOf("\"", startIndex) - startIndex;
                                string text4 = string_93;
                                int startIndex2 = startIndex;
                                int length = num;
                                string text5 = text4.Substring(startIndex2, length);
                                Cookie cookie = new Cookie("enTrace", text5)
                                {
                                    Domain = "netsafe.hdfcbank.com"
                                };
                                CookieContainer cookieContainer = cookieContainer_2;
                                Cookie cookie2 = cookie;
                                cookieContainer.Add(cookie2);
                                string_91 = text3 + "/ACSWeb/com.enstage.entransact.servers.AccessControlServerSSL?perform=SEND_EGUARD_REQUEST";
                                string text6 = "perform=ajaxRequest&testData=Ajax&xdeviceId=" + text5 + "&bTz=Asia/Kolkata&bTzOS=-330";
                                string_91 = string_91.Replace("SEND_EGUARD_REQUEST", "CONFIRM_FORM_LOAD");
                                int num2 = 0;
                                string text9;
                                if (string_93.IndexOf("Select Any Option", StringComparison.CurrentCultureIgnoreCase) > 0)
                                {
                                    string_91 = text3 + "/ACSWeb/jsp/SCode.jsp";
                                    if (string_93.IndexOf("ACSWeb/jsp/PayerAuth.jsp", StringComparison.CurrentCultureIgnoreCase) > 0)
                                    {
                                        flag = true;
                                        string_91 = text3 + "/ACSWeb/jsp/PayerAuth.jsp";
                                    }
                                    else if (string_93.IndexOf("jsp/DinerAuth.jsp", StringComparison.CurrentCultureIgnoreCase) > 0)
                                    {
                                        string_91 = text3 + "/ACSWeb/jsp/DinerAuth.jsp";
                                    }
                                    text6 = "acsRadio=payerAuth&sbmtBtn=Continue&xdeviceId=" + text5 + "&bTz=undefined";
                                    if (!_Request(string_91, text6, string_87, webProxy_3, ref cookieContainer_2, bool_63: true, bool_64: true, 60000, 60000, ref string_93, ref string_92, ref webException_0))
                                    {
                                        string_90 = "Failed after Payment, Check Status.";
                                        string text7 = "Second Hit Failed. err = ";
                                        string text8 = string_92;
                                        return false;
                                    }
                                    startIndex = string_93.IndexOf("ACTION=");
                                    startIndex = string_93.IndexOf("\"", startIndex) + 1;
                                    num = string_93.IndexOf("\"", startIndex) - startIndex;
                                    text9 = string_93.Substring(startIndex, num);
                                }
                                else
                                {
                                    num2 = 1;
                                    string text10 = string_93.Substring(string_93.IndexOf("function redirectUrlCancel(choiceType)"));
                                    startIndex = text10.IndexOf(".action =");
                                    startIndex = text10.IndexOf("\"", startIndex) + 1;
                                    num = text10.IndexOf("\"", startIndex) - startIndex;
                                    text9 = text10.Substring(startIndex, num);
                                    text9 = text9.Replace("DYNAMIC_AUTHENTICATION_IMPROVEMENT", "USER_AUTH_IMPROVEMENT");
                                }
                                startIndex = string_93.IndexOf("name=\"txtLogin\"", startIndex);
                                string text11 = string_93;
                                string value = "value";
                                startIndex = string_93.IndexOf("\"", startIndex) + 1;
                                int startIndex3 = startIndex;
                                startIndex = text11.IndexOf(value, startIndex3);
                                string text12 = string_93;
                                string value2 = "\"";
                                int startIndex4 = startIndex;
                                startIndex = text12.IndexOf(value2, startIndex4) + 1;
                                num = string_93.IndexOf("\"", startIndex) - startIndex;
                                string text13 = string_93.Substring(startIndex, num);
                                string[] array = new string[6]
                                {
                                "txtLogin=",
                                text13,
                                "&txtPassword=",
                                HttpUtility.UrlEncode(string_88),
                                null,
                                null
                                };
                                if (num2 == 0)
                                {
                                    array[4] = "&xdeviceId=";
                                    array[5] = text5;
                                }
                                text6 = string.Concat(array);
                                if (flag)
                                {
                                    text6 += "&cmdSubmit=Submit";
                                }
                                string_91 = text3 + text9.Replace("true", "false");
                                string salt = string_93.Substring(string_93.IndexOf("textSalt") + 17);
                                salt = salt.Substring(0, salt.IndexOf("\""));
                                string text1password = computeSHA_256(string_88);
                                String ppp = text1password + salt;
                                text1password = computeSHA_256(ppp);
                                text6 = "txtLogin=" + text13 + "&txtPassword=" + HttpUtility.UrlEncode(text1password) + "&textSalt=" + salt + "&cmdSubmit=Submit&";
                                if (!_Request(string_91, text6, string_87, webProxy_3, ref cookieContainer_2, bool_63: true, bool_64: true, 60000, 60000, ref string_93, ref string_92, ref webException_0))
                                {
                                    string_90 = "Third Hit Failed, Check Status.";
                                    return false;
                                }
                                if (string_93.IndexOf("perform\" value=\"USER_AUTH_IMPROVEMENT", StringComparison.CurrentCultureIgnoreCase) > 0)
                                {
                                    string string_94 = Method_SerialInp(string_93, ref string_91, bool_14: true);
                                    if (!_Request(string_91, string_94, string_87, webProxy_3, ref cookieContainer_2, bool_63: true, bool_64: true, 60000, 60000, ref string_93, ref string_92, ref webException_0))
                                    {
                                        string_90 = "Failed after Payment, Check Status.";
                                        string text14 = "Fourth Hit Failed. err = ";
                                        string text15 = string_92;
                                        return false;
                                    }
                                }
                                if (string_93.IndexOf("Enter OTP", StringComparison.CurrentCultureIgnoreCase) > 0)
                                {
                                    string_88 = "";
                                    continue;
                                }
                                if (string_93.IndexOf("com.enstage.entransact.servers.AccessControlServerSSL", StringComparison.CurrentCultureIgnoreCase) > 0)
                                {
                                    string_88 = "";
                                    string_86 = string_93;
                                    break;
                                }
                                if (string_93.IndexOf("form name=\"frmMerchantPost", StringComparison.CurrentCultureIgnoreCase) > 0)
                                {
                                    if (!flag)
                                    {
                                        string_87 = string_91;
                                        string string_95 = Method_SerialInp(string_93, ref string_91, bool_14: true);
                                        string value3 = "form name=\"frmMerchantPost";
                                        if (!string_93.Contains(value3))
                                        {
                                            if (!_Request(string_91, string_95, string_87, webProxy_3, ref cookieContainer_2, bool_63: true, bool_64: true, 60000, 60000, ref string_93, ref string_92, ref webException_0))
                                            {
                                                string_90 = "Failed after Payment, Check Status.";
                                                string text16 = "Fourth Hit Failed. err = ";
                                                string text17 = string_92;
                                                string string_96 = text16 + text17;
                                                return false;
                                            }
                                        }
                                    }
                                    string_89 = string_93;
                                    string_90 = string_87;
                                    return true;
                                }
                                string_88 = "";
                                continue;
                            }
                            int startIndex5 = string_93.IndexOf("randomDigit");
                            startIndex5 = string_93.IndexOf("\"", startIndex5) + 1;
                            int length2 = string_93.IndexOf("\"", startIndex5) - startIndex5;
                            string value4 = string_93.Substring(startIndex5, length2);
                            startIndex5 = string_93.IndexOf("Total Charge") + 5;
                            startIndex5 = string_93.IndexOf("</span>", startIndex5) + 7;
                            length2 = string_93.IndexOf("<", startIndex5) - startIndex5;
                            string_93.Substring(startIndex5, length2).Trim();
                            startIndex5 = string_93.IndexOf("<span>", startIndex5) + 6;
                            int num3 = string_93.IndexOf("<", startIndex5);
                            int num4 = startIndex5;
                            length2 = num3 - num4;
                            string text18 = string_93.Substring(startIndex5, length2).Trim();
                            Cookie cookie3 = new Cookie("enTrace", value4)
                            {
                                Domain = "netsafe.hdfcbank.com"
                            };
                            CookieContainer cookieContainer2 = cookieContainer_2;
                            Cookie cookie4 = cookie3;
                            cookieContainer2.Add(cookie4);
                            string string_97 = "";
                            if (method_163("Enter OTP For HDFC CC Card:" + text18, ref string_97, ref string_90))
                            {
                                string string_98 = "txtOtpPassword=" + string_97 + "&cmdSubmitDynamic=";
                                string text19 = string_93.Substring(string_93.IndexOf("function redirectUrlCancel(choiceType)"));
                                int startIndex6 = text19.IndexOf(".action =");
                                startIndex6 = text19.IndexOf("\"", startIndex6) + 1;
                                int length3 = text19.IndexOf("\"", startIndex6) - startIndex6;
                                string text20 = text19.Substring(startIndex6, length3);
                                string string_99 = text3 + text20.Replace("true", "false");
                                string string_100 = string_87;
                                _Request(string_99, string_98, string_100, webProxy_3, ref cookieContainer_2, bool_63: true, bool_64: true, 60000, 60000, ref string_93, ref string_92, ref webException_0);
                            }
                            result = false;
                            goto end_IL_0074;
                        }
                        continue;
                    end_IL_0074:;
                    }
                    catch (Exception ex)
                    {
                        result = false;
                    }
                    break;
                }
                return result;
            }
            text.IndexOf("window.location");
            if (text.IndexOf("hdfc-acs.wibmo.com") > 0)
            {
                text = Method_SerialInp(string_86, ref string_91, bool_14: true);
                if (!_Request(string_91, text, string_87, webProxy_3, ref cookieContainer_2, bool_63: true, bool_64: true, 60000, 60000, ref string_93, ref string_92, ref webException_0))
                {
                    result = false;
                }
                else
                {
                    text = Method_SerialInp(string_93, ref string_91, bool_14: true);
                    text += HttpUtility.UrlEncode(string_88);
                    string_91 = "https://hdfc-acs.wibmo.com" + string_91;
                    if (!_Request(string_91, text, string_87, webProxy_3, ref cookieContainer_2, bool_63: true, bool_64: true, 60000, 60000, ref string_93, ref string_92, ref webException_0))
                    {
                        result = false;
                    }
                    else
                    {
                        string_89 = string_93;
                        string_90 = string_87;
                        result = true;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static string computeSHA_256(string input)
        {
            HashAlgorithm hashAlgorithm = HashAlgorithm.Create("SHA-256");
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] array = hashAlgorithm.ComputeHash(bytes);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                stringBuilder.Append($"{array[i]:x2}");
            }
            return stringBuilder.ToString();
        }

        private bool method_163(string string_86, ref string string_87, ref string string_88)
        {
            bool result = false;
            try
            {
                result = false;
                return false;
            }
            catch
            {
                return result;
            }
        }


        public string Method_SerialInp(string string_87, ref string string_88, bool bool_14)
        {
            string string_89 = string_88;
            string result = smethod_4(string_87, ref string_89);
            string_88 = string_89;
            string_88 = string_88.Replace("&amp;", "&");
            return result;
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
            string result = "";
            try
            {
                int startIndex = str.IndexOf("\"" + what + "\"", StringComparison.CurrentCultureIgnoreCase);
                string text = str.Substring(startIndex);
                text = text.Substring(text.IndexOf(":\"") + 2);
                result = text.Substring(0, text.IndexOf("\""));
                return result;
            }
            catch
            {
            }
            return result;
        }


        private string method_103(string string_86, string string_87, string string_88, string string_89)
        {
            int startIndex = string_86.IndexOf(string_87);
            startIndex = string_86.IndexOf(string_88, startIndex) + string_88.Length;
            int length = string_86.IndexOf(string_89, startIndex) - startIndex;
            return string_86.Substring(startIndex, length);
        }

        public static string smethod_4(string string_87, ref string string_88)
        {
            string text = "";
            try
            {
                string text2 = string_87.Replace("'", "\"");
                int num = text2.IndexOf("<form", StringComparison.CurrentCultureIgnoreCase);
                if (num < 0)
                {
                    if (text2.IndexOf("http://") == 0 || text2.IndexOf("https://") == 0)
                    {
                        string_88 = text2;
                    }
                    return text;
                }
                try
                {
                    int startIndex = text2.IndexOf(" action", num, StringComparison.CurrentCultureIgnoreCase);
                    startIndex = text2.IndexOf("=", startIndex, StringComparison.CurrentCultureIgnoreCase);
                    startIndex = text2.IndexOf("\"", startIndex) + 1;
                    int num2 = text2.IndexOf("\"", startIndex);
                    string_88 = text2.Substring(startIndex, num2 - startIndex);
                    string_88 = string_88.Replace("&amp;", "&");
                }
                catch
                {
                }
                num = text2.IndexOf("<form", StringComparison.CurrentCultureIgnoreCase);
                int num3 = text2.IndexOf("</form", StringComparison.CurrentCultureIgnoreCase);
                while (num > -1)
                {
                    string text3 = "";
                    int num4 = text2.IndexOf("<input", num, StringComparison.CurrentCultureIgnoreCase);
                    int num5 = text2.IndexOf("<select", num, StringComparison.CurrentCultureIgnoreCase);
                    int num6 = -1;
                    if (num4 == -1 && num5 == -1 && num6 == -1)
                    {
                        return text;
                    }
                    int num7 = num4;
                    int[] array = new int[3] { num4, num5, num6 };
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (num7 > array[i] && array[i] != -1)
                        {
                            num7 = array[i];
                        }
                    }
                    if (num7 == num4)
                    {
                        num = num4;
                        text3 = "input";
                    }
                    else if (num7 == num5)
                    {
                        num = num5;
                        text3 = "select";
                    }
                    else if (num7 == num6)
                    {
                        num = num6;
                        text3 = "";
                    }
                    num = text2.IndexOf("<" + text3, num, StringComparison.CurrentCultureIgnoreCase);
                    if (num >= num3)
                    {
                        return text;
                    }
                    num = text2.IndexOf("<input", num, StringComparison.CurrentCultureIgnoreCase);
                    int num8 = text2.IndexOf(">", num) + 1;
                    string text4 = text2.Substring(num, num8 - num);
                    text4 = text4.Replace("\t", "").Replace("\n", "").Replace("\r", " ");
                    num = num8;
                    if (text4.Contains("type=\"submit\""))
                    {
                        continue;
                    }
                    int num9 = text4.IndexOf(" name", StringComparison.CurrentCultureIgnoreCase);
                    if (num9 == -1)
                    {
                        continue;
                    }
                    num9 = text4.IndexOf("\"", num9) + 1;
                    int num10 = text4.IndexOf("\"", num9);
                    string text5 = text4.Substring(num9, num10 - num9);
                    num9 = text4.IndexOf(" value", StringComparison.CurrentCultureIgnoreCase);
                    string text6 = "";
                    if (num9 > -1)
                    {
                        if (text4.IndexOf("\"", num9) > -1)
                        {
                            num9 = text4.IndexOf("\"", num9) + 1;
                            num10 = text4.IndexOf("\"", num9);
                        }
                        else if (text4.IndexOf("'", num9) > -1)
                        {
                            num9 = text4.IndexOf("'", num9) + 1;
                            num10 = text4.IndexOf("'", num9);
                        }
                        text6 = HttpUtility.UrlEncode(text4.Substring(num9, num10 - num9).Replace("&amp;", "&"));
                    }
                    text5 = text5 + "=" + text6;
                    text = (string.IsNullOrEmpty(text) ? text5 : (text + "&" + text5));
                }
                return text;
            }
            catch
            {
                return text;
            }
        }
        internal bool _Request(string string_86, string string_87, string string_88, WebProxy webProxy_5, ref CookieContainer cookieContainer_2, bool bool_63, bool bool_64, int int_28, int int_29, ref string string_89, ref string string_90, ref WebException webException_1)
        {
            int num = 0;
            int num2 = 0;
            bool flag = false;
            string text = "";
            if (!string.IsNullOrEmpty(string_71))
            {
                text = string_71;
            }
            if (string_87 == null)
            {
                string_87 = "";
            }
            int num3;
            while (true)
            {
                string_90 = "";
                string_89 = "";
                webException_1 = null;
                num3 = 0;
                HttpWebResponse httpWebResponse = null;
                string text2 = "";
                int num4 = ((string_86.IndexOf("https://www.irctc.co.in", StringComparison.CurrentCultureIgnoreCase) == 0 || string_86.IndexOf("http://www.irctc.co.in", StringComparison.CurrentCultureIgnoreCase) == 0) ? 1 : 0);
                try
                {
                    ServicePointManager.Expect100Continue = false;
                    HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_86);
                    httpWebRequest.ProtocolVersion = HttpVersion.Version11;
                    if (flag)
                    {
                        //httpWebRequest.Proxy = clsMain.webProxy_0;
                        flag = false;
                    }
                    string_52 = "Tls12";
                    ServicePointManager.ServerCertificateValidationCallback = (object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0) => true;
                    HttpRequestCachePolicy cachePolicy = new HttpRequestCachePolicy(HttpCacheAgeControl.MaxAge, TimeSpan.FromDays(0.0));
                    httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                    //httpWebRequest.ConnectionGroupName = clsMain.ConnectionGroupName_;
                    if ((string_52 == "Tls") | (string_52 == "Ssl3"))
                    {
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
                    }
                    else if (string_52 == "Tls12")
                    {
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                    }
                    if (int_28 > 0)
                    {
                        httpWebRequest.Timeout = int_28;
                    }
                    if (int_29 > 0)
                    {
                        httpWebRequest.ReadWriteTimeout = int_29;
                    }
                    byte[] bytes = Encoding.UTF8.GetBytes(string_87);
                    if (bool_63 && cookieContainer_2 == null)
                    {
                        cookieContainer_2 = new CookieContainer();
                    }
                    httpWebRequest.CookieContainer = cookieContainer_2;
                    bool flag2;
                    if (flag2 = string_87.Length > 0)
                    {
                        httpWebRequest.Method = "POST";
                    }
                    else if (bool_15)
                    {
                        httpWebRequest.Method = "POST";
                        bool_15 = false;
                    }
                    else
                    {
                        httpWebRequest.Method = "GET";
                    }
                    if (bool_40)
                    {
                        httpWebRequest.Method = "PUT";
                        bool_40 = false;
                    }
                    else if (bool_41)
                    {
                        httpWebRequest.Method = "DELETE";
                        bool_41 = false;
                    }
                    httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                    httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                    httpWebRequest.KeepAlive = true;
                    httpWebRequest.Connection = "keepalive";
                    httpWebRequest.ContentLength = bytes.Length;
                    httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36";
                    if (string_86.Contains(".paytm.in"))
                    {
                        ServicePointManager.Expect100Continue = false;
                        if (bool_13)
                        {
                            bool_13 = false;
                            if (string_86.Contains("https://securegw.paytm.in/instaproxy/bankresponse/ICICIPAY/DC"))
                            {
                                httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                            }
                            else if (bool_14)
                            {
                                bool_14 = false;
                                httpWebRequest.Headers.Add("sec-ch-ua-mobile", "?0");
                                httpWebRequest.Headers.Add("Cache-Control", "max-age=0");
                                httpWebRequest.Headers.Add("sec-ch-ua-platform", "\"Windows\"");
                                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                                httpWebRequest.Headers.Add("Sec-Fetch-User", "?1");
                                httpWebRequest.Headers.Add("Sec-Fetch-Dest", "document");
                                httpWebRequest.Headers.Add("Sec-Fetch-Site", "cross-site");
                                httpWebRequest.Headers.Add("Sec-Fetch-Mode", "navigate");
                                httpWebRequest.Headers.Add("sec-ch-ua", "\"Google Chrome\";v=\"95\", \"Chromium\";v=\"95\", \";Not A Brand\";v=\"99\"");
                                httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
                                httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                                httpWebRequest.Headers.Add("Accept-Language", "en-US,en;q=0.9");
                            }
                            else if (!string_86.Contains("https://securegw.paytm.in/instaproxy/direct/payment/payonbank/v2"))
                            {
                                httpWebRequest.ContentType = "application/json";
                                httpWebRequest.Accept = "*/*";
                            }
                            httpWebRequest.Headers.Add("Accept-Language", "en-US,en;q=0.9");
                        }
                        else
                        {
                            httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                            httpWebRequest.Headers.Add("Accept-Language", "en-IN,en-US;q=0.9,en;q=0.8");
                            httpWebRequest.Headers.Add("accept-encoding", "gzip, deflate");
                            httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
                            httpWebRequest.Headers.Add("Cache-Control", "max-age=0");
                        }
                    }
                    if (string_86.ToLower().Contains("irctc.co.in"))
                    {
                        httpWebRequest.AllowWriteStreamBuffering = false;
                    }
                    if (bool_27)
                    {
                        httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
                        httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
                    }
                    if (bool_51)
                    {
                        bool_51 = false;
                        httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
                        httpWebRequest.Headers.Add("Cache-Control", "max-age=0");
                        httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7";
                    }
                    else if (string_86.ToLower().Contains("irctc.co.in") && !bool_21)
                    {
                        httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
                    }
                    if (bool_21)
                    {
                        httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                        httpWebRequest.Headers.Add("faces-request", "partial/ajax");
                        if (webProxy_5 != null)
                        {
                            httpWebRequest.Headers.Add("Cache-Control", "no-cache");
                            httpWebRequest.Headers.Add("Pragma", "no-cache");
                        }
                        bool_21 = false;
                    }
                    if (bool_23)
                    {
                        //httpWebRequest.ServicePoint.BindIPEndPointDelegate = method_76;
                    }
                    if ((string_86.Contains("fss.co.in") || string_86.Contains("fssnet.co.in")) && !bool_28)
                    {
                        httpWebRequest.AllowAutoRedirect = false;
                    }
                    if (string_86.IndexOf("axisbiconnect", StringComparison.CurrentCultureIgnoreCase) > 0)
                    {
                        httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; MSIE 7.0; Windows NT 6.0; en-US)";
                    }
                    if (string_86.IndexOf("middleware/MWServlet", StringComparison.CurrentCultureIgnoreCase) > 0)
                    {
                        httpWebRequest.UserAgent = "Apache-HttpClient/android/" + string_88;
                        httpWebRequest.Connection = "keepalive";
                        httpWebRequest.Headers.Add("Cookie2", "$Version=" + 1);
                    }
                    if (bool_30)
                    {
                        httpWebRequest.AllowAutoRedirect = false;
                        bool_30 = false;
                    }
                    else if (num4 != 0)
                    {
                        httpWebRequest.AllowAutoRedirect = false;
                        httpWebRequest.Headers.Add("X-Priority", "5");
                        httpWebRequest.Headers.Add("x-msg-priority", "9");
                    }
                    if (bool_29)
                    {
                        bool_29 = false;
                        httpWebRequest.ContentType = "application/json;charset=UTF-8";
                        httpWebRequest.Accept = "application/json, text/plain, */*";
                        httpWebRequest.ContentType = "application/json";
                        httpWebRequest.Accept = "*/*";
                        httpWebRequest.Headers.Add("Accept-Language", "en-US,en;q=0.5");
                    }
                    if (bool_36)
                    {
                        httpWebRequest.ContentType = "application/json";
                        bool_36 = false;
                        if (bool_37)
                        {
                            bool_37 = false;
                            httpWebRequest.Headers.Add("browserName", "Chrome");
                            httpWebRequest.Headers.Add("internalIp", "192.168.1.2");
                            httpWebRequest.Headers.Add("assignedClientId", "null");
                            httpWebRequest.Headers.Add("osVersion", "Windows 7");
                            httpWebRequest.Headers.Add("clientId", "Web");
                            httpWebRequest.Headers.Add("deviceId", "null");
                            httpWebRequest.Headers.Add("browserVersion", "27.0.1453.116");
                            httpWebRequest.Headers.Add("userMachineIdentifier", "JNDF");
                            httpWebRequest.Headers.Add("appVersion", "null");
                        }
                        if (string_86.Contains("airtelmoney.in"))
                        {
                            httpWebRequest.Accept = "application/json";
                        }
                    }
                    if (bool_11)
                    {
                        httpWebRequest.AllowAutoRedirect = false;
                    }
                    if (bool_38)
                    {
                        httpWebRequest.ContentType = "application/json;charset=UTF-8";
                        httpWebRequest.UserAgent = "Dalvik/2.1.0 (Linux; U; Android 5.1; A1601 Build/LMY47I";
                        httpWebRequest.Accept = "";
                        bool_38 = false;
                    }
                    if (string_86.Contains("https://checkout.razorpay.com/integration/irctc"))
                    {
                        httpWebRequest.AllowAutoRedirect = true;
                    }
                    if (string_86.Contains("http://allpaypg.kotak.com/Genius/Kotak/cardSubmit"))
                    {
                        httpWebRequest.AllowAutoRedirect = true;
                    }
                    if (string_86.Contains("https://www.onlinesbiglobal.com/NPINB"))
                    {
                        if (Int32_0 == 1)
                        {
                            Int32_0 = 0;
                            httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
                            httpWebRequest.CachePolicy = new HttpRequestCachePolicy(HttpCacheAgeControl.MaxAge, TimeSpan.FromDays(0.0));
                            httpWebRequest.AllowAutoRedirect = true;
                        }
                        if (Int32_0 == 2)
                        {
                            httpWebRequest.Accept = "*/*";
                            httpWebRequest.Headers.Add("requestId", String_0);
                            httpWebRequest.Headers.Add("X-Requested-With", "XMLHttpRequest");
                            httpWebRequest.Headers.Add("IPTYPE", "XML");
                        }
                    }
                    if (string_86.Contains("merchant.onlinesbi.sbi"))
                    {
                        httpWebRequest.CachePolicy = cachePolicy;
                        httpWebRequest.Headers.Add("sec-ch-ua", "\"Google Chrome\";v=\"89\", \"Chromium\";v=\"89\", \";Not A Brand\";v=\"99\"");
                        httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
                        httpWebRequest.Headers.Add("Accept-Language", "en-US,en;q=0.9,hi;q=0.8");
                        httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
                    }
                    if (string_86.Contains("ecomVerifyOtp.action"))
                    {
                        httpWebRequest.ContentType = "application/json";
                        httpWebRequest.Accept = "application/json, text/plain, */*";
                    }
                    if (string_86.Contains("ecomSendOtp.action") || string_86.Contains("ecomDoTxn.action"))
                    {
                        httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                        httpWebRequest.Accept = "application/json, text/plain, */*";
                        httpWebRequest.Headers.Add("version", "4.0");
                    }
                    if (string_86.Contains("www.airtel.in/bank/api/v1/auth/login/mpin"))
                    {
                        httpWebRequest.ContentType = "application/json";
                        httpWebRequest.Accept = "application/json, text/plain, */*";
                        httpWebRequest.Headers.Add("version", "4.0");
                        httpWebRequest.Headers.Add("channel", "WEB");
                    }
                    if (string_86.Contains("https://api.payu.in/checkoutx/payments"))
                    {
                        httpWebRequest.ContentType = "application/json";
                        httpWebRequest.Accept = "application/json, text/plain, */*";
                    }
                    if (Boolean_0)
                    {
                        Boolean_0 = false;
                        ServicePointManager.Expect100Continue = true;
                    }
                    if (bool_501)
                    {
                        bool_501 = false;
                        httpWebRequest.Headers.Add("Upgrade-Insecure-Requests", "1");
                        httpWebRequest.Headers.Add("Cache-Control", "max-age=0");
                        httpWebRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7";
                    }
                    if (!string.IsNullOrEmpty(text))
                    {
                        string[] array = Strings.Split(text, "&");
                        int num5 = Information.UBound(array);
                        for (int i = 0; i <= num5; i++)
                        {
                            string[] array2 = Strings.Split(array[i], "=");
                            httpWebRequest.Headers.Set(array2[0], array2[1]);
                        }
                        string_71 = "";
                    }
                    if (!string.IsNullOrEmpty(string_88))
                    {
                        httpWebRequest.Referer = string_88;
                    }
                    if (flag2)
                    {
                        Stream stream = httpWebRequest.GetRequestStream();
                        stream.Write(bytes, 0, bytes.Length);
                    }
                    httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    if (num4 != 0 && (httpWebResponse.StatusCode == HttpStatusCode.Found || httpWebResponse.StatusCode == HttpStatusCode.MovedPermanently) && httpWebResponse.Headers["Location"].ToString().Contains("error") && num2 < 20)
                    {
                        Thread.Sleep(200);
                        num2++;
                        text2 = (string_5 = httpWebResponse.GetResponseHeader("Location"));
                        httpWebResponse.Close();
                        httpWebResponse = null;
                        continue;
                    }
                    string string_91 = "";
                    //method_96(httpWebResponse, ref string_91);
                    if (bool_11)
                    {
                        bool_11 = false;
                        string_16 = httpWebResponse.GetResponseHeader("Location");
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
                    string_89 = text2;
                    num3 = 1;
                    break;
                }
                catch (WebException ex)
                {
                    num3 = 0;
                    webException_1 = ex;
                    string message = ex.Message;
                    bool flag3 = ex.Response != null;
                    string text3 = "";
                    num++;
                    HttpStatusCode httpStatusCode = HttpStatusCode.OK;
                    if (flag3)
                    {
                        httpStatusCode = ((HttpWebResponse)ex.Response).StatusCode;
                        try
                        {
                            text3 = ":" + new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
                        }
                        catch
                        {
                        }
                    }
                    string_90 = "<StatusCode>" + httpStatusCode.ToString() + "</StatusCode>\t<ErrorCode>" + message + "</ErrorCode>\t<ResponseCode>" + text3 + "</ResponseCode>";
                    if (num >= 9)
                    {
                        break;
                    }
                    if (message.Contains("The remote name could not be resolved") | message.Contains("Unable to connect to the remote server"))
                    {
                        if (!message.ToUpper().Contains("SERVICEUNAVAILABLE"))
                        {
                            Thread.Sleep(1000);
                            break;
                        }
                        Thread.Sleep(2000);
                    }
                    else if (message.Contains("The underlying connection was closed:"))
                    {
                        if (!message.Contains("An unexpected error occurred on a send") && !message.Contains("A connection that was expected to be kept alive was closed by the server"))
                        {
                            message.Contains("An unexpected error occurred on a receive");
                        }
                        if (num % 2 == 0)
                        {
                            string_52 = "Tls12";
                        }
                        if (num == 3 || num == 4)
                        {
                            flag = true;
                        }
                        if (num >= 5)
                        {
                            break;
                        }
                    }
                    else if (message.Contains("The request was aborted: Could not create SSL/TLS secure channel."))
                    {
                        if (num % 2 == 0)
                        {
                            string_52 = "Tls12";
                        }
                        if (num == 3 || num == 4)
                        {
                            flag = true;
                        }
                        if (num >= 5)
                        {
                            break;
                        }
                    }
                    else if (message.Contains("The operation has timed out"))
                    {
                        if (num >= 5)
                        {
                            break;
                        }
                    }
                    else if (message.Contains("(406) Not Acceptable") || message.Contains("(401) Unauthorized") || message.Contains("(400) Bad Request") || (message.Contains("(404) Not Found") | message.Contains("(409) Conflict")) || (!message.Contains("(500) Internal Server Error") && !message.Contains("(502) Bad Gateway") && !message.Contains("(503) Server Unavailable") && !message.Contains("(504) Gateway Timeout")))
                    {
                        break;
                    }
                }
                catch (Exception ex2)
                {
                    num3 = 0;
                    string_90 = ex2.Message;
                    //clsMain.method_74("WebRequestPost Ex=", string_90 + "  hitUrl" + string_86 + "  Inp=" + string_87 + " Ref=" + string_88 + " reHitCount=" + num);
                    if (num < 3 && string_90.Contains("String reference not set to an instance"))
                    {
                        string_90 = "";
                        num++;
                        continue;
                    }
                    break;
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
            return num3 != 0;
        }      
    }
}
