namespace Core.Models.Enums
{
    /// <summary>
    /// Designates common ordinal ranks
    /// </summary>
    public enum OrdinalRank
    {
        Neutral = 0,  // DESIGN: None/null & Neutral are treated the same
        Primary,
        Secondary,
        Tertiary,
        Quarternary,
        Quinary
    }
}
