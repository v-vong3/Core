using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.Geographies
{
    public class GeographyInfo
    {
        /// <summary>
        /// System assigned key
        /// </summary>
        public long Id { get; set; }

        public string Name { get; set; }

        public string UniqueCode { get; set; }
    }
}
