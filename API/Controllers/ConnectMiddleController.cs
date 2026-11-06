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
    public class ConnectMiddleController : ApiController
    {
        [HttpPost]
        [Route("api/irctc.co.in/eticketing/pri/BankRedirect")]
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
}
