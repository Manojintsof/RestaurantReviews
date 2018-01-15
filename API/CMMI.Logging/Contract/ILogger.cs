using System;
using System.Collections.Generic;
using System.Text;

namespace CMMI.Logging.Contract
{
    public interface ILogger
    {
        void LogInfo (string message);

        void LogDebug (string message);

        void LogError(string message, Exception e);
    }
}
