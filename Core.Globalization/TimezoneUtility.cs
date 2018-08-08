using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Core.Globalization
{
    /// <summary>
    /// Standard UTC time zone slots as defined by ISO 8601 
    /// </summary>
    public sealed class TimeZoneUtility
    {
        private static readonly object _lock = new object();
        private static volatile TimeZoneUtility _instance = null;

        private static IDictionary<string, string> _timeZones;

        // TODO: Performance test and thread test Lazy<T> approach vs explicit double-check approach

        private TimeZoneUtility()
        {
            // TODO: Decide if data structure is best as a dictionary or a collection of key-value pairs
            TimeZoneInfo.GetSystemTimeZones()
                                     .Select(tz => new KeyValuePair<string, string>(tz.Id, tz.DisplayName));

        }

        public TimeZoneUtility Instance
        {
            get
            {

                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if(_instance == null)
                        {
                            _instance = new TimeZoneUtility();
                        }
                            
                    }
                        
                }

                return _instance;
                
                
            }
        }

    }
}
