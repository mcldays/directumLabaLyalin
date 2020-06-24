namespace DirectumTask3.Task1
{
    /// <summary>
    /// Defines the <see cref="MeetingType" />.
    /// </summary>
    internal class MeetingType : Meeting
    {
        /// <summary>
        /// Defines the MeetType.
        /// </summary>
       public enum MeetType
        {
            /// <summary>
            /// Defines the Meeting.
            /// </summary>
            Meeting = 1,

            /// <summary>
            /// Defines the BirthDay.
            /// </summary>
            BirthDay,

            /// <summary>
            /// Defines the Call.
            /// </summary>
            Call,

            /// <summary>
            /// Defines the Mission.
            /// </summary>
            Mission
        }
    }
}
