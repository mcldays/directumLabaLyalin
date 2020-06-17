namespace DirectumTask1
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using Timer = System.Threading.Timer;

    /// <summary>
    /// Реализация интерфейса Iremind
    /// Класс реализует напоминание в указанное время
    /// </summary>
    public class MeetReminder : Meeting, IRemind
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetReminder"/> class.
        /// </summary>
        /// <param name="startDate">Дата начала</param>
        /// <param name="endDate">Дата окончания</param>
        /// <param name="meetingTime">Дата напоминания</param>
        [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1126: PrefixCallsCorrectly", Justification = "Reviewed.")]
        public MeetReminder(DateTime startDate, DateTime endDate, DateTime meetingTime)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.MeetingEvent = meetingTime;

            TimerCallback tm = new TimerCallback(this.CheckTime);
            Timer timer = new Timer(tm, null, 0, 60000);
        }

        /// <summary>
        /// Gets or sets the DateTime of the Meeting.
        /// </summary>
        public DateTime MeetingEvent { get; set; }

        /// <summary>
        /// Meeting notification event
        /// </summary>
        /// <param name="obj">Empty param</param>
        public void CheckTime(object obj)
        {
            if (this.MeetingEvent.Minute == DateTime.Now.Minute)
            {
                Console.WriteLine("Пора на встречу!");
            }
        }
    }
}
