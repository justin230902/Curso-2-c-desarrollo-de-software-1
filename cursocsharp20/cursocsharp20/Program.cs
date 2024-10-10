using System;

class Alarm
{
    public event Action OnAlarmTriggered;

    public void TriggerAlarm()
    {
        Console.WriteLine("Alarm is triggered!");
        if (OnAlarmTriggered != null)
        {
            OnAlarmTriggered();
        }
    }
}

class Program
{
    static void Main()
    {
        Alarm alarm = new Alarm();
        alarm.OnAlarmTriggered += AlarmHandler;

        alarm.TriggerAlarm();
    }

    static void AlarmHandler()
    {
        Console.WriteLine("Alarm handler called!");
    }
}
