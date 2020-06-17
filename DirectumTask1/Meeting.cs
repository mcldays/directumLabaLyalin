namespace DirectumTask1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary> 
    /// Класс "Диапазон дат". 
    /// </summary> 
    public class Meeting
    {
        /// <summary> 
        /// Gets or sets the StartDate of the Meeting. 
        /// </summary> 
        public System.DateTime StartDate { get; set; }

        /// <summary> 
        /// Gets or sets the EndDate of the Meeting. 
        /// </summary> 
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the SummaryTime of the Meeting.
        /// </summary>
        public System.DateTime SummaryTime { get; set; }
    }
}
