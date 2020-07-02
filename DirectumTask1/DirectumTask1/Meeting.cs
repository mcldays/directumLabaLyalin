namespace DirectumTask1
{
    using System;
    /// <summary> 
    /// Класс "Диапазон дат". 
    /// </summary> 
    public class Meeting
    {
        /// <summary> 
        /// Gets or sets the StartDate of the Meeting. 
        /// </summary> 
        public DateTime StartDate { get; set; }  // Если System указан в using'ах, здесь писать полное имя не требуется. Достаточно DateTime.

        /// <summary> 
        /// Gets or sets the EndDate of the Meeting. 
        /// </summary> 
        public DateTime EndDate { get; set; }  // Сейчас я могу задать EndDate раньше, чем StartDate и не получить ошибки.

        /// <summary>
        /// Gets or sets the SummaryTime of the Meeting.
        /// </summary>
        public int SummaryTime
        {
            get { return this.EndDate.Minute - this.StartDate.Minute; }
        }  // Продолжительность должна вычисляться автоматически.
                                                          // Здесь не должно быть set.
                                                          // В get должно быть вычисления на основе StartDate и EndDate.
    }
}
