using CMMI.Logging.Contract;
using System;
using System.Collections.Generic;
using System.Text; 

namespace CMMI.Logger
{
    public class LoggerFactory
    {
        private LoggerType type;
        public LoggerFactory(LoggerType type)
        {
            this.type = type;

        }
        public ILogger GetLogger()
        {
            //ToDo: use DependencyInjection to resolve the appropriate logger
            return new Logging.Service.DBLogger();
        }
    }

    public enum LoggerType
    {
        File = 1,
        DB = 2,
        EventViewer =3
    }
}
