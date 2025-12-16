using RadioactivityMonitor.src.Service;

namespace RadioactivityMonitor.tests
{
    public class AlarmTests
    {
        private readonly List<string> FailedAssertions = [];
        private int TestCount = 0;
        private int PassedTestCount = 0;
        private int FailedTestCount = 0;

        ///<summary>
        /// Tests that the alarm is off when the measurement is within the valid range.
        /// </summary>
        private void Test_Alarm_Should_Be_Off_When_Measurement_Is_Within_Range()
        {
            // Arrange
            var alarm = CreateAlarmWithMockSensor(19.0); // Between 17 and 21
            // Act
            alarm.Check();
            // Assert
            Assert(() => AssertionHelper.AssertFalse(alarm.AlarmOn, nameof(Test_Alarm_Should_Be_Off_When_Measurement_Is_Within_Range)));
        }

        ///<summary>
        /// Tests that the alarm is on when the measurement is below the low threshold.
        /// </summary>
        private void Test_Alarm_Should_Be_On_When_Measurement_Is_Below_Low_Threshold()
        {
            // Arrange
            var alarm = CreateAlarmWithMockSensor(16.5); // Below 17
            // Act
            alarm.Check();
            // Assert
            Assert(() => AssertionHelper.AssertTrue(alarm.AlarmOn, nameof(Test_Alarm_Should_Be_On_When_Measurement_Is_Below_Low_Threshold)));

        }

        ///<summary>
        /// Tests that the alarm is on when the measurement is above the high threshold.
        /// </summary>
        private void Test_Alarm_Should_Be_On_When_Measurement_Is_Above_High_Threshold()
        {
            // Arrange
            var alarm = CreateAlarmWithMockSensor(21.5);
            // Act
            alarm.Check();
            // Assert
            Assert(() => AssertionHelper.AssertTrue(alarm.AlarmOn, nameof(Test_Alarm_Should_Be_On_When_Measurement_Is_Above_High_Threshold)));
        }

        ///<summary>
        /// Tests that the alarm is on when the measurement is equal to the low threshold.
        /// </summary>
        private void Test_Alarm_Should_Be_On_When_Measurement_Is_Equal_Low_Threshold()
        {
            // Arrange
            var alarm = CreateAlarmWithMockSensor(17);// Equal to Low Threshold 17
            // Act
            alarm.Check();
            // Assert
            Assert(() => AssertionHelper.AssertFalse(alarm.AlarmOn, nameof(Test_Alarm_Should_Be_On_When_Measurement_Is_Equal_Low_Threshold)));
        }

        ///<summary>
        /// Tests that the alarm is on when the measurement is equal to the high threshold.
        /// </summary>
        private void Test_Alarm_Should_Be_On_When_Measurement_Is_Equal_High_Threshold()
        {
            // Arrange
            var alarm = CreateAlarmWithMockSensor(21); // Equal to High Threshold 21
            // Act
            alarm.Check();
            // Assert
            Assert(() => AssertionHelper.AssertFalse(alarm.AlarmOn, nameof(Test_Alarm_Should_Be_On_When_Measurement_Is_Equal_High_Threshold)));
        }

        private static Alarm CreateAlarmWithMockSensor(double measurement)
        {
            var mockSensor = new MockSensor(measurement);
            return new Alarm(mockSensor);
        }

        private void Assert(Action action)
        {
            TestCount++;
            try
            {
                action.Invoke();
                PassedTestCount++;
            }
            catch (Exception ex)
            {
                FailedAssertions.Add(ex.Message);
                FailedTestCount++;
            }
        }

        ///<summary>
        /// Runs all the alarm tests.
        /// </summary>
        public void RunTests()
        {
            Test_Alarm_Should_Be_Off_When_Measurement_Is_Within_Range();
            Test_Alarm_Should_Be_On_When_Measurement_Is_Below_Low_Threshold();
            Test_Alarm_Should_Be_On_When_Measurement_Is_Above_High_Threshold();
            Test_Alarm_Should_Be_On_When_Measurement_Is_Equal_Low_Threshold();
            Test_Alarm_Should_Be_On_When_Measurement_Is_Equal_High_Threshold();

            if (FailedAssertions.Count > 0)
            {
                Console.WriteLine("There are some test failures:");
                foreach (var failure in FailedAssertions)
                {
                    Console.WriteLine(failure);
                }
            }
            Console.WriteLine($"Total Tests: {TestCount}, Passed: {PassedTestCount}, Failed: {FailedTestCount}");
        }

    }

}