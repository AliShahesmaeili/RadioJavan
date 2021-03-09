using RadioJavan.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioJavan.Classes.Helpers
{
    internal class UriCreator
    {
        private static readonly Uri BaseRadioJavanUri = new Uri(RadioJavanApiConstants.RADIOJAVAN_URL);

        public static Uri GetLoginUri()
        {
            if (!Uri.TryCreate(BaseRadioJavanUri, RadioJavanApiConstants.LOGIN, out var uri))
                throw new Exception("Cant create URI for user login");
            return uri;
        }

        public static Uri GetForgotPasswordUri()
        {
            if (!Uri.TryCreate(BaseRadioJavanUri, RadioJavanApiConstants.FORGOT, out var uri))
                throw new Exception("Cant create URI for Forgot Password");
            return uri;
        }
    }
}
