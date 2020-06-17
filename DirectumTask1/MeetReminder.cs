using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Timers;
using Timer = System.Threading.Timer;


namespace DirectumTask1
{
   class MeetReminder : Meeting, IRemind
    {
        public DateTime MeetingEvent { get; set; }


        public MeetReminder(DateTime startDate, DateTime endDate, DateTime meetingTime)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.MeetingEvent = meetingTime;

            TimerCallback tm = new TimerCallback(CheckTime);
            Timer timer = new Timer(tm, null, 0, 60000);


        }

        public void CheckTime(object obj)
        {
            if (MeetingEvent.Minute == DateTime.Now.Minute)
            {
                Console.WriteLine("Пора на встречу!");
            }

        }

    }
}
