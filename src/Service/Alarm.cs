using RadioactivityMonitor.src.Contract;

namespace RadioactivityMonitor.src.Service
{
    // We can use DI in future to inject different sensor implementations
    public class Alarm(ISensor sensor) : IAlarm
    {
        // In future we might want to make these thresholds configurable
        // so can keep in appsettings or fetch from db
        private const double LowThreshold = 17;
        private const double HighThreshold = 21;

        // To avoid tight coupling providing the dependencies from outside
        // Sensor _sensor = new Sensor();

        bool _alarmOn = false;
        // We are not using _alarmCount anywhere, so commenting it out
        // private long _alarmCount = 0;

        public void Check()
        {
            double value = sensor.NextMeasure();

            // if (value < LowThreshold | HighThreshold  < value)
            // {
            //     _alarmOn = true;
            //     _alarmCount += 1;
            // }

            // Used Logical OR instead of Bitwise OR
            // Swapped the comparison order in the second condition for clarity
            if (value < LowThreshold || value > HighThreshold)
            {
                _alarmOn = true;
            }
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }
    }
}
