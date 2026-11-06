using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using API.Common;

namespace API.Controllers
{
    public class ConnectController : ApiController
    {
        [HttpPost]
        [Route("api/irctc.co.in/eticketing/mbi/MobileBankResponse")]
        public cls02 VerifyUser(RequestBody requestBody)
        {
            string certName = @"irctc.p12";
            string password = @"mobile";
            string fl2 = @"API.Common." + certName;
            string postdata = fl2;
            X509Certificate2Collection TvJeboisorCertificate = new X509Certificate2Collection();
            try
            {
                Assembly Asm = Assembly.GetExecutingAssembly();
                Stream CertStream = Asm.GetManifestResourceStream(fl2);
                if (CertStream != null)
                {
                    byte[] RawBytes = new byte[CertStream.Length];
                    for (int Index = 0; Index < CertStream.Length; Index++)
                    {
                        RawBytes[Index] = (byte)CertStream.ReadByte();
                    }
                    TvJeboisorCertificate.Import(RawBytes, password, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.PersistKeySet);
                    postdata = "Success";
                }
            }
            catch (Exception erp)
            {
                postdata = "Failed-" + erp.Message.ToString();
            }
            ConnectL bnk = new ConnectL();
            cls02 cls020 = bnk.IrctcReponse(requestBody, TvJeboisorCertificate);
            return cls020;
        }
    }
    public class cls02
    {
        public string RequestToken { get; set; }
        public string status { get; set; }
    }
    public class RequestBody
    {
        public string AdminIP = "";
        public string RequestToken;
        public string id;
        public string user;
        public string amount;
        public string enc;
        public string card;
        public string bank;
        public string url;
        public string referal;
        public string mac;
        public string greq;
        public string token;
        public string authorization;
        public string BankID;
        public string Fare;
        public string TransactionID;
        public string Data;
        public string cookie0;
        public string cookie1;
        public string ip;
        public string irctcID;
        public string irctcPass;
        public string Action;
        public string SRC;
        public string DEST;
        public string QUOTA;
        public string CLASS;
        public string DOJ;
        public string TrainNo;
        public string serial;
        public string otpid;
        public string otptoken;
        public string Serverid;
        public string data0;
        public string data1;
        public string data2;
        public string data3;
        public string data4;

    }
}
