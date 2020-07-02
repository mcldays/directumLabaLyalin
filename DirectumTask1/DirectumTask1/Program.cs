namespace DirectumTask1
{
    using System;

    /// <summary>
    /// Основной класс для ининциализации логики
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program initialization
        /// </summary>
        /// <param name="args">Аргументы входа</param>
        public static void Main(string[] args)
        {
            MeetReminder remind = new MeetReminder(
                new DateTime(2020, 6, 17, 15, 50, 00),
                new DateTime(2020, 6, 17, 14, 55, 00),
                new DateTime(2020, 6, 17, 15, 04, 00)); // Не ошибка: Здесь можно было использовать DateTime.Now, чтобы было легче тестировать.

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
