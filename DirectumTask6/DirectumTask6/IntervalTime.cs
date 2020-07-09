namespace DirectumTask5
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Defines the <see cref="IntervalTime" />.
    /// </summary>
    internal class IntervalTime
    {
        /// <summary>
        /// The RecordsCount.
        /// </summary>
        /// <param name="path">The path<see cref="string"/>.</param>
        /// <param name="start">The start<see cref="DateTime"/>.</param>
        /// <param name="end">The end<see cref="DateTime"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int RecordsCount(string path, DateTime start, DateTime end)
        {
            int result = 0;
            Regex regular = new Regex(@"\A\d{2}\.\d{2}\.\d{4}");

            using (StreamReader reader = new StreamReader(path))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    if (regular.Match(line).Success)
                    {
                        DateTime parseDate = DateTime.ParseExact(regular.Match(line).Value, "dd.MM.yyyy", null);

                        if (parseDate >= start && parseDate <= end)
                        {
                            result++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
