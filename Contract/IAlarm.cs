namespace RadioactivityMonitor.Contract
{
    public interface IAlarm
    {
        void Check();
        bool AlarmOn { get; }
    }
}