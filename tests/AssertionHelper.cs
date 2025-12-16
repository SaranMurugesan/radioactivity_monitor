namespace RadioactivityMonitor.tests
{
    public static class AssertionHelper
    {
        /// <summary>
        /// Asserts that the given condition is true.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="methodName">The methodName to display if the assertion fails.</param>
        /// <exception cref="Exception"></exception>
        public static void AssertTrue(bool condition, string methodName)
        {
            if (!condition)
            {
                throw new Exception($"Failed: Test Method {methodName} - Expected true but was false");
            }
        }

        /// <summary>
        /// Asserts that the given condition is false.
        /// </summary>
        /// <param name="condition">The condition to check.</param>
        /// <param name="methodName">The methodName to display if the assertion fails.</param>
        /// <exception cref="Exception"></exception>
        public static void AssertFalse(bool condition, string methodName)
        {
            if (condition)
            {
                throw new Exception($"Failed: Test Method {methodName} - Expected false but was true.");
            }
        }
    }
}