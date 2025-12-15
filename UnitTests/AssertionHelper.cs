namespace RadioactivityMonitor.UnitTests
{
    public static class AssertionHelper
    {
        /// <summary>
        /// Asserts that the given condition is true.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="message">The message to display if the assertion fails.</param>
        /// <exception cref="Exception"></exception>
        public static void AssertTrue(bool condition, string message)
        {
            if (!condition)
            {
                throw new Exception($"Expected true but was false. {message}");
            }
        }

        /// <summary>
        /// Asserts that the given condition is false.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="message">The message to display if the assertion fails.</param>
        /// <exception cref="Exception"></exception>
        public static void AssertFalse(bool condition, string message)
        {
            if (condition)
            {
                throw new Exception($"Expected false but was true. {message}");
            }
        }
    }
}