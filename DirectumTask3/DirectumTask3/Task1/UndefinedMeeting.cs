namespace DirectumTask3.Task1
{
    using System;
    using System.Globalization;   // Лишний using.

    /// <summary>
    /// Defines the <see cref="UndefinedMeeting" />.
    /// </summary>
    internal class UndefinedMeeting : Meeting   // Неопределённая встреча? Не лучшее название.
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UndefinedMeeting"/> class.
        /// </summary>
        /// <param name="startDate">The startDate<see cref="DateTime"/>.</param>
        /// <param name="endDate">The endDate<see cref="DateTime"/>.</param>
        public UndefinedMeeting(DateTime startDate, DateTime endDate) // Если это встреча без конца, то и endDate в нём быть не должно.
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
                if (string.IsNullOrEmpty(this.EndDate.ToString()))  // Проверять приведение к строке - плохое решение.
                {
                    return 0;
                }

                return this.EndDate.Minute - this.StartDate.Minute;
            }
        }
    }
}
