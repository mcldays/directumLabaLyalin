namespace DirectumTask3.Task1
{
    using System;

    /// <summary>
    /// Defines the <see cref="Meeting" />.
    /// </summary>
    public class Meeting
    {
        /// <summary>
        /// Gets or sets the StartDate of the Meeting......
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the EndDate of the Meeting......
        /// </summary>
        public virtual DateTime EndDate { get; set; }

        /// <summary>
        /// Gets the SummaryTime
        /// Gets or sets the SummaryTime of the Meeting......
        /// </summary>
        public virtual int SummaryTime
        {
            get { return this.EndDate.Minute - this.StartDate.Minute; }
        }
    }
}
