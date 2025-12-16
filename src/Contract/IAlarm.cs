namespace RadioactivityMonitor.src.Contract
{
    public interface IAlarm
    {
        void Check();
        bool AlarmOn { get; }
    }
}