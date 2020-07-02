namespace DirectumTask1
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using Timer = System.Threading.Timer; // Это зачем? Без этого всё и так работает.

    /// <summary>
    /// Реализация интерфейса Iremind
    /// Класс реализует напоминание в указанное время
    /// </summary>
    public class MeetReminder : Meeting, IRemind
    {
        private Timer timer;
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

            TimerCallback callback = new TimerCallback(this.CheckTime); // Плохое название для переменной. Можно было бы назвать callback или handler.
            timer = new Timer(callback, null, 0, 60000);  // Лучше поместить таймер в приватное поле.
        }

        /// <summary>
        /// Gets or sets the DateTime of the Meeting.
        /// </summary>
        public DateTime MeetingEvent { get; }  // Либо убрать set, либо сделать проверку, что время напоминания меньше времени окончания.

        /// <summary>
        /// Meeting notification event
        /// </summary>
        /// <param name="obj">Empty param</param>
        public void CheckTime(object obj)
        {
            if (DateTime.Now.Minute > this.MeetingEvent.Minute)  // Неправильное условие. Нужно проверить что текущее время больше времени события.
            {
                Console.WriteLine("Пора на встречу!");  // Помимо напоминания в задании сказано "отключить таймер".
                timer.Dispose();
            }
        }
    }
}
