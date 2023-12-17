namespace BytesConverter
{
    /// <summary>
    /// Specifies rounding options for use in the <see cref="Converter"/> class.
    /// </summary>
    public enum Round
    {
        /// <summary>
        /// No rounding will be applied (default).
        /// </summary>
        NONE,

        /// <summary>
        /// Rounds down to the nearest number at the specified decimal place.
        /// </summary>
        ROUNDDOWN,

        /// <summary>
        /// Rounds up to the nearest number at the specified decimal place.
        /// </summary>
        ROUNDUP,

        /// <summary>
        /// Truncates the value to the specified decimal place without rounding.
        /// </summary>
        TRUNCATE
    }
}
