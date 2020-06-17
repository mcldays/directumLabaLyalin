namespace DirectumTask1
{
    using System;

    /// <summary>
    ///   Интерфейс для считывания или установки события
    /// </summary>
    public interface IRemind
    {
        /// <summary>
        /// Gets or sets the DateTime of the Meeting.
        /// </summary>
        DateTime MeetingEvent { get; set; }
    }
}
