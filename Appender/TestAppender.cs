using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.Appender;
using System.IO;
using log4net.Core;
using log4net.Util;

namespace log4net.Json.Test.UI.Appender
{
    public class TestAppender : AppenderSkeleton
    {
        public static event AppendedEventCall Appended;

        public delegate void AppendedEventCall(IAppender appender, LoggingEvent loggingEvent, string entry);

        protected override void Append(LoggingEvent loggingEvent)
        {
            var call = Appended;
            if (call == null)
            {
                LogLog.Error(GetType(), "No handlers added to TestAppender.Appended event.");
            }
            else
            {
                var writer = new StringWriter();
                Layout.Format(writer, loggingEvent);
                call(this, loggingEvent, writer.ToString());
            }
        }
    }
}
