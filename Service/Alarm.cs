using RadioactivityMonitor.Contract;

namespace RadioactivityMonitor.Service
{
    public class Alarm(ISensor sensor) : IAlarm
    {
        private const double LowThreshold = 17;
        private const double HighThreshold = 21;

        bool _alarmOn = false;
        private long _alarmCount = 0;

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
                _alarmCount += 1;
            }
            else // Reset alarm if within range
            {
                _alarmOn = false;
            }
        }

        public bool AlarmOn
        {
            get { return _alarmOn; }
        }
    }
}
