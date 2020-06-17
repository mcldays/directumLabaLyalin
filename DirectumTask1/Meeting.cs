namespace DirectumTask1
{
    using System;
    using System.Collections.Generic;  // Даже если StyleCop не поругался на это(хотя должен был), не следует оставлять неиспольземые using'и.
    using System.Text;

    /// <summary> 
    /// Класс "Диапазон дат". 
    /// </summary> 
    public class Meeting
    {
        /// <summary> 
        /// Gets or sets the StartDate of the Meeting. 
        /// </summary> 
        public System.DateTime StartDate { get; set; }  // Если System указан в using'ах, здесь писать полное имя не требуется. Достаточно DateTime.

        /// <summary> 
        /// Gets or sets the EndDate of the Meeting. 
        /// </summary> 
        public System.DateTime EndDate { get; set; }  // Сейчас я могу задать EndDate раньше, чем StartDate и не получить ошибки.

        /// <summary>
        /// Gets or sets the SummaryTime of the Meeting.
        /// </summary>
        public System.DateTime SummaryTime { get; set; }  // Продолжительность должна вычисляться автоматически.
                                                          // Здесь не должно быть set.
                                                          // В get должно быть вычисления на основе StartDate и EndDate.
    }
}
