namespace DirectumTask3.Task1
{
    using System;

    /// <summary>
    /// Defines the <see cref="UndefinedMeeting" />.
    /// </summary>
    internal class UndefinedMeeting : Meeting
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UndefinedMeeting"/> class.
        /// </summary>
        /// <param name="startDate">The startDate<see cref="DateTime"/>.</param>
        /// <param name="endDate">The endDate<see cref="DateTime"/>.</param>
        public UndefinedMeeting(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Gets the SummaryTime.
        /// </summary>
        public override int SummaryTime
        {
            get
            {
                if (String.IsNullOrEmpty(this.EndDate.ToString()))  // StyleCop.
                {
                    return 0;
                }

                return this.EndDate.Minute - this.StartDate.Minute;
            }
        }
    }
}
