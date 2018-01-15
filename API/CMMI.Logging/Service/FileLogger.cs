using System;
using System.Collections.Generic;
using System.Text;
using CMMI.Logging.Contract;

namespace CMMI.Logging.Service
{
    public class FileLogger: ILogger
    {
        public void LogInfo(string message)
        {
            //log the information in File
        }

        public void LogDebug(string message)
        {
            //log the message during debug mode in File
        }

        public void LogError(string message, Exception e)
        {
            //log the error message with exception in File
        }
    }
}
