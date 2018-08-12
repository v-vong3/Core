using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Globalization
{
    /// <summary>
    /// Provides standard UTC time zone enumerations based on ISO 8601 
    /// </summary>
    public sealed class TimeZoneClient
    {
        private static readonly object _lock = new object();
        private static volatile TimeZoneClient _instance = null;

        private static IDictionary<string, string> TimeZones { get; set; }

        private TimeZoneClient()
        {
            // TODO: Do performance and multi-thread tests if ConcurrentDictionary is best suited for this scenario
            TimeZones = new ConcurrentDictionary<string, string>();

            Parallel.ForEach(TimeZoneInfo.GetSystemTimeZones(), tz => TimeZones.Add(tz.Id, tz.DisplayName));
        }

        public static TimeZoneClient Instance
        {
            // TODO: Do performance test and multi-thread test on Lazy<T> approach vs explicit double-check approach
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if(_instance == null)
                        {
                            _instance = new TimeZoneClient();
                        }
                            
                    }
                }

                return _instance;
            }
        }

    }
}
