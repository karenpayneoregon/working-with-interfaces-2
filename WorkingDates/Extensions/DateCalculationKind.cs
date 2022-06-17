namespace WorkingDates.Extensions
{
    public enum DateCalculationKind
    {
        /// <summary>
        /// Will uniquely calculate the next day of the
        /// week. This will perform a `distinct` on the
        /// collection of days, and give back a unique result
        /// set with each calculation performed with
        /// the `from` parameter.
        /// </summary>
        And,
        /// <summary>
        /// Will use the previous result to calculate the
        /// next date. This allows for duplicate days of
        /// the week and will be calculated in the order
        /// of the days passed in.
        /// </summary>
        AndThen
    }
}