using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class UnitTest1
{
    [Flags]
    public enum Days
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64
    }
    struct Alarm
    {
        public Days day;
        public int hour;
        public Alarm(Days day, int hour)
        {
            this.day = day;
            this.hour = hour;
        }
    }

    [TestMethod]
    public void CheckAlarm()
    {
        var alarm = new Alarm[] {   new Alarm (Days.Monday,6),
                                       new Alarm (Days.Tuesday,6),
                                       new Alarm (Days.Wednesday,6),
                                       new Alarm (Days.Thursday,6),
                                       new Alarm (Days.Friday,6),
                                       new Alarm (Days.Saturday,8),
                                       new Alarm (Days.Sunday,8),
           };
        Assert.IsTrue(TriggeredAlarm(alarm, Days.Saturday, 8));
        Assert.IsFalse(TriggeredAlarm(alarm, Days.Saturday, 6));
        Assert.IsTrue(TriggeredAlarm(alarm, Days.Tuesday, 6));
        Assert.IsFalse(TriggeredAlarm(alarm, Days.Tuesday, 8));
    }
    [TestMethod]
    public void CheckAlarmWithFlags()
    {
            var alarm = new Alarm[] {  
                new Alarm (Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday,6),
                new Alarm (Days.Saturday | Days.Sunday, 8 )
               };
        Assert.IsTrue(TriggeredAlarm(alarm, Days.Saturday, 8));
        Assert.IsTrue(TriggeredAlarm(alarm, Days.Tuesday, 6));
        Assert.IsFalse(TriggeredAlarm(alarm, Days.Saturday, 6));
        Assert.IsFalse(TriggeredAlarm(alarm, Days.Tuesday, 8));
    }

    bool TriggeredAlarm(Alarm[] alarm, Days day, int hour)
    {
        for (int i = 0; i < alarm.Length; i++)
        {
            if ((alarm[i].day & day)!=0  && (alarm[i].hour == hour))
                return true;
        }
        return false;
    }
}
