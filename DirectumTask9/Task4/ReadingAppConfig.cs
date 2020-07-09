namespace Task4
{
    using System.Configuration;

    /// <summary>
    /// Defines the <see cref="ReadingAppConfig" />.
    /// </summary>
    internal class ReadingAppConfig       // Вообще в задании подразумевался класс с кастомными секциями, коллекциями и свойствами.
    {                                     // Но т.к. время финального задания начинает поджимать, пускай так.
        /// <summary>
        /// The GetCommonParameterFromConfig.
        /// </summary>
        /// <param name="parameterName">The parameterName<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetCommonParameterFromConfig(string parameterName) =>
            ConfigurationManager.AppSettings.GetValues(parameterName)?[0];
    }
}
