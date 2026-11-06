using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Common
{
    public class ReadyPost
    {
        internal string string_9 = "E_TICKET";
        internal long Book_Time;
        internal int num9, TrDayDiff, Paxnum;
        internal DateTime jjdate;
        internal string BRD_STN, TKT_CLASS, TKT_QUOTA;
        internal string SRC_STN, DEST_STN, TrainNo, fareTotal, Cookieklist;
        internal int avlSuccessTime = 0, frmStIndx, toStIndx, BnkTry;
        internal string TKT_DAY, TKT_MONTH, TKT_YEAR, jdate, TrPassingDay, RunsOnDay;
        internal bool bool_ISADVV, bool_ISSpecialTrain;
        internal bool bool_ISBEDROLL;
        internal DateTime dateTime_0 = DateTime.Now;
        internal string IRC_EMID, IRC_EMPWD, IRC_MOBILE;
        internal string[] Station_list, Station_listWithDay;
        internal bool bool_4, bool_6, bool_7, bool_8, bool_9, RtrnJrny;
        internal bool bool_ISCONFIRM, bool_ISAUTOUPGRD, loyaltyRedemption;
        internal string TKT_IRPWD, TKT_IRCTCID, TKT_MOBILE, BNK_MOBILE, string_12;
        internal string TKT_TRNTYPE = "", Trday = "", string_21 = "", string_10, string_101 = "";
        internal string TKT_PAYMENT, AvalResponse, BokResponse, PaxResponse, PaymentRespose = "", LastTransactionId;
        internal string TKT_BANKSAVEAS = "", TKT_BANKDETAILS = "", getwayBankId = "", txnType = "", text33 = "", text34 = "";
        internal string string_233 = "", clientTransactionId, BankWithGetway = "", GetwayName = "";
        internal string string_24, string_244, string_25, string_26, string_27, string_28, string_29, string_30;
        internal string string_31, string_32, string_33, string_34, string_35, string_36, string_37;
        internal string string_40;
        internal string string_41;
        internal string string_42;
        internal string string_43;
        internal string string_44;
        internal string string_45;
        internal string string_46;
        public static object object_0;
        public static byte[] byte_0;
        public static byte[] byte_1;
        public string Profile, ipproxylist;
        private static Func<char, bool> func_0;

        internal Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();
        private static Predicate<string> predicate_0, predicate_00, predicate_1, predicate_10, predicate_2, predicate_20;
        public bool CurBooking, GNBooking, ACBooking, SLBooking;
        public string string_13 = "https://www.irctc.co.in/eticketing/javax.faces.resource/irctc_logo_en_IN.gif.jsf?ln=images";
        public string string_14 = "https://www.irctc.co.in/eticketing/captchaImage";
        public string string_15 = "https://www.irctc.co.in/eticketing/home";
        public string string_16 = "https://www.irctc.co.in/eticketing/trainbetweenstns.jsf";
        public string string_17 = "https://www.irctc.co.in/eticketing/mainpage.jsf";
        public string string_18 = "https://www.irctc.co.in/eticketing/journeySummary.jsf?cid=1";
        public string string_19 = "https://www.irctc.co.in/eticketing/jpInput.jsf?cid=1";
        internal string string_20 = "";

        internal dynamic randomGeneratedKey = null;
        internal string keyFromServer = null;
        internal string X_Request_For = "";
        internal string greq = "";
        internal string bearer = "";
        internal string token = "";
        internal string MUP = "";

        internal string otptoken = "";
        internal string otpmobile = "";
        internal string otpserial = "";
        internal string otpid = "";
        internal string mobileotp = "";
        internal string string_63Ai = "";

        internal string fullemail = "";
        internal string email = "";
        internal string domain = "";
        internal string _greq;
        internal string string_61;
        internal string _Authorization;
        internal bool bool_13;

        public string LoginType { get; internal set; }
    }
}