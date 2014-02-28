using System.Collections.Concurrent;
using System.IO;
using log4net.Appender;
using log4net.Core;
using log4net.Util;
using System.Collections.Generic;

namespace log4net.Json.Test.UI.Appender
{
    public class TestAppender : ForwardingAppender
    {
        static ConcurrentQueue<LoggingEvent> Events = new ConcurrentQueue<LoggingEvent>();
        
        protected override void Append(LoggingEvent loggingEvent)
        {
            Append(new LoggingEvent[] { loggingEvent });
        }

        protected override void Append(LoggingEvent[] loggingEvents)
        {
            foreach (var loggingEvent in loggingEvents)
            {
                // do a formatting run which will be included in timings
                var writer = new StringWriter();
                Layout.Format(writer, loggingEvent);

                //mark the event
                loggingEvent.Properties["TestAppender"] = Name;
                loggingEvent.Properties["TestAppenderData"] = writer.ToString();

                // just make it available 
                Events.Enqueue(loggingEvent);
            }

            base.Append(loggingEvents);
        }

        public static IEnumerable<LoggingEvent> GetEvents()
        {
            LoggingEvent loggingEvent;
            while (Events.TryDequeue(out loggingEvent))
                yield return loggingEvent;
        }
    }
}
