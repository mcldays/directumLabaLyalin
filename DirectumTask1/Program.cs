using System;

namespace DirectumTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            MeetReminder remind = new MeetReminder(new DateTime(2020, 6, 17, 15, 50, 00),
                                                    new DateTime(2020, 6, 17, 14, 55, 00),
                                                    new DateTime(2020, 6, 17, 15, 04, 00));

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
    /// <summary> 
    /// Класс "Диапазон дат". 
    /// </summary> 
    class Meeting
    {
        /// <summary> 
        /// Начальная дата диапазона. 
        /// </summary> 
        public System.DateTime StartDate { get; set; }

        /// <summary> 
        /// Конечная дата диапазона. 
        /// </summary> 
        public System.DateTime EndDate { get; set; }
        public System.DateTime SummaryTime { get; set; }

        
    }


}
