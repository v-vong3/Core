namespace Core.Models.Geographies
{
    public class GeographyHierarchyInfo
    {
        /// <summary>
        /// System assigned key
        /// </summary>
        public long Id { get; set; }

        public GeographyInfo ParentGeography { get; set; }

        public GeographyInfo ChildGeography { get; set; }

        public Coordinate Coordinate { get; set; }


    }
}
