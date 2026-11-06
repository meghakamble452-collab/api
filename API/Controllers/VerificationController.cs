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
    public class VerificationController : ApiController
    {
        [HttpPost]
        [Route("api/HitmanServer")]
        public cls02 VerifyUser(RequestBody requestBody)
        {
            String apiid = requestBody.data0;
            if (apiid == "ProcessBankipay")
            {
                Bank bnk1 = new Bank();
                cls02 cls021 = bnk1.VerifyResponse(requestBody);
                return cls021;
            }
            ConnectL bnk = new ConnectL();
            cls02 cls020 = bnk.VerifyResponse(requestBody);
            return cls020;
        }
    }
}
