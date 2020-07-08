namespace Task4
{
    using System.Configuration;

    /// <summary>
    /// Defines the <see cref="ReadingAppConfig" />.
    /// </summary>
    internal class ReadingAppConfig
    {
        /// <summary>
        /// The GetCommonParameterFromConfig.
        /// </summary>
        /// <param name="parameterName">The parameterName<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetCommonParameterFromConfig(string parameterName) =>
            ConfigurationManager.AppSettings.GetValues(parameterName)?[0];
    }
}
