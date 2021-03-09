using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioJavan.Classes
{
    public class ResultInfo
    {
        public ResultInfo(string message)
        {
            Message = message;
            HandleMessages(message);
        }

        public ResultInfo(Exception exception)
        {
            Exception = exception;
            Message = exception?.Message;
            HandleMessages(Message);
        }
      
        public void HandleMessages(string errorMessage)
        {
            if (errorMessage.Contains("task was canceled"))
                Timeout = true;
        }

        public Exception Exception { get; }

        public string Message { get; }

        public bool Timeout { get; internal set; }
    }
}
