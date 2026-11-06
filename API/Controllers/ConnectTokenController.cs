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
    public class ConnectTokenController : ApiController
    {
        [HttpPost]
        [Route("api/Sharp/Tokens")]
        public cls02 VerifyUser(RequestBody requestBody)
        {
            ConnectL bnk = new ConnectL();
            cls02 cls020 = bnk.TokensReponse(requestBody);
            return cls020;
        }
    }
}
