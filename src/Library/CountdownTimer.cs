using System;
using System.Threading;

/* el patron utilizado es adapter, el adaptador el timerclient, quien hace que recipe 
sea viable para el uso de countdowntimer. Cuando recipe implementa timerclient, se adapta
a countdowntimer. */
namespace Full_GRASP_And_SOLID
{
    public interface TimerClient
    {
        void TimeOut();
    }

    public class CountdownTimer
    {
        private TimerClient client;

        private Timer timer;

        public void Register(int timeOut, TimerClient client)
        {
            this.client = client;
            this.timer = new Timer(this.OnTimedEvent, null, timeOut, Timeout.Infinite);
        }

        private void OnTimedEvent(object state)
        {
            this.client.TimeOut();
            this.timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}