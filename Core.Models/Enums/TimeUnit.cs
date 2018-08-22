namespace Core.Models.Enums
{
    /// <summary>
    /// Designates an order of magnitude for common units of time
    /// </summary>
    public enum TimeUnit
    {
        None = 0,
        Hourly,
        Daily,
        Weekly,
        Monthly,
        Quarterly,
        Annually,
        Custom
    }
}
