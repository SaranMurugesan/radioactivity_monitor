using RadioactivityMonitor.Service;
using RadioactivityMonitor.UnitTests;

Console.WriteLine("Press 1 to check the Radioactivity Monitor Alarm.");
Console.WriteLine("Press 2 to run the Radioactivity Monitor Alarm Tests.");
var selectedOption = Console.ReadLine() ?? string.Empty;
switch(selectedOption.Trim())
{
    case "1":
        CheckAlarm();
        break;
    case "2":
        RunAlarmTests();
        break;
    default:
        Console.WriteLine("Invalid input. Exiting Radioactivity Monitor Alarm.");
        break;
}

static void CheckAlarm()
{
    Console.WriteLine("<---- Checking Radioactivity Monitor Alarm  ---->");
    while (true)
    {
        var sensor = new Sensor();
        var alarm = new Alarm(sensor);
        alarm.Check();
        Console.WriteLine($"Radioactivity Monitor Alarm Status: {(alarm.AlarmOn ? "ON" : "OFF")}");
        Console.WriteLine("Do you want to check Radioactivity Monitor Alarm again? (y/n)");
        var input = Console.ReadLine();
        if (input == null || !input.Trim().Equals("y", StringComparison.InvariantCultureIgnoreCase))
        {
            Console.WriteLine("<---- Exiting Radioactivity Monitor Alarm ---->");
            break;
        }
        Console.WriteLine("<---- Re-running Radioactivity Monitor Alarm ---->");
    }
}

static void RunAlarmTests()
{
    Console.WriteLine("<---- Start Testing Radioactivity Monitor Alarm ---->");
    var alarmTests = new AlarmTests();
    alarmTests.RunTests();
    Console.WriteLine("<---- End Testing Radioactivity Monitor Alarm ---->");
}

