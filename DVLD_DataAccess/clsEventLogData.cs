using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsEventLogData
    {
        public static void CheckError(string SourceName, string ErrorMessage,
            string ErrorCategory = "Application")
        {

            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, ErrorCategory);
            }
            EventLog.WriteEntry(SourceName, ErrorMessage, EventLogEntryType.Information);
        }
    }
}
