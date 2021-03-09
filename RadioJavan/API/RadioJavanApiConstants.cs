using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioJavan.API
{
    internal static class RadioJavanApiConstants
    {
        public const string HOST_URI = "r-j-app-desk.com";
        public const string HOST = "Host";
        public const string API = "/api";
        public const string API_SUFFIX_V2 = API + API_VERSION_V2;
        public const string API_VERSION_V2 = "2";
        public const string RADIOJAVAN_URL = "https://r-j-app-desk.com";

        public const string HEADER_ACCEPT_ENCODING = "gzip, deflate, br";
        public const string HEADER_ACCEPT_LANGUAGE = "Accept-Language";
        public static string ACCEPT_LANGUAGE = "en-US";
        public const string HEADER_USER_AGENT = "User-Agent";
        public const string USER_AGENT = "Radio Javan/3.7.7 (Windows_NT 10.0.19042) com.RadioJavan.RJ.desktop";

        public const string LOGIN = API_SUFFIX_V2 + "/login";
        public const string FORGOT = API_SUFFIX_V2 + "/forgot";

    }
}
