using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alarm
{
    enum Days { Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday };

    [TestClass]
    public class UnitTest1 
    {
      // enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        [TestMethod]
        public void TestMethod1()
        {
            int[] alarm={(int)Days.Monday,(int)Days.Tuesday, (int)Days.Wednesday,(int)Days.Thursday,(int)Days.Friday,(int)Days.Saturday, (int)Days.Sunday};
           // Assert.AreEqual("yes",TriggeredAlarm((int)Days.Monday, 9));
            Assert.AreEqual("yes", TriggeredAlarm(alarm,8));
        }

            
       string TriggeredAlarm(int[] days ,int hour)
       {
           int counter=days.Length;
           for(int i=0;i<days.legth;i++)
           {
               if()
           }
         
           //return "yes";
       }

    }
}
