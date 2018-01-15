using CMMI.Logging.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMMI.Logging.Service
{
    public class EventViewerLogger : ILogger
    {
         public void LogInfo(string message)
        {
            //log the information in EventViewer
        }

        public void LogDebug(string message)
        {
            //log the message during debug mode in EventViewer
        }

        public void LogError(string message, Exception e)
        {
            //log the error message with exception in EventViewer
        }
    }
}
