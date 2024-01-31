namespace Cutulu
{
    public static class Debug
    {
        #region Logging
        /// <summary>
        /// Logs an error message.
        /// </summary>
        public static void LogError(this object? obj) => LogError(obj == null ? default : obj.ToString());

        /// <summary>
        /// Logs an error message.
        /// </summary>
        public static void LogError(this string? message) => Console.WriteLine(message);

        /// <summary>
        /// Logs a warning console message.
        /// </summary>
        public static void LogWarning(this string? message) => Console.WriteLine(message);

        /// <summary>
        /// Logs a default console message.
        /// </summary>
        public static void Log(this object? obj) => Log(obj == null ? default : obj.ToString());

        /// <summary>
        /// Logs a default console message.
        /// </summary>
        public static void Log(this string? message) => Console.WriteLine(message);

        /// <summary>
        /// Logs a default console message.
        /// </summary>
        public static void Log<T>(this T[] array, string name = "array")
        {
            string result = $"{name}: {'{'} ";

            if (array != null)
                for (int i = 0; i < array.Length; i++)
                {
                    if (i > 0) result += ',';
                    result += $" {array[i]}";
                }

            Log(result + " }");
        }

        /// <summary>
        /// Throws an error message and stop code from continuing.
        /// </summary>
        public static void Throw(this string message) => throw new System.Exception(message);
        #endregion
    }
}