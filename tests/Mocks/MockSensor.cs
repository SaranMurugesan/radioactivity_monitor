using RadioactivityMonitor.src.Contract;

namespace RadioactivityMonitor.tests.Mocks
{
    /// <summary>
    /// A mock sensor that always returns the passed measurement.
    /// </summary>
    /// <param name="mockMeasurement">Measurement to return on each call.</param>
    public class MockSensor(double mockMeasurement) : ISensor
    {
        public double NextMeasure()
        {
            return mockMeasurement;
        }
    }
}