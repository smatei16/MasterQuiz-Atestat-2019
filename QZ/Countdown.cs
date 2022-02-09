using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace QZ
{
    class Countdown
    {
        DispatcherTimer timer = new DispatcherTimer();
        TimeSpan time;

        public void startFromTen(int count, TimeSpan interval, Action<int> ts)
        {
            // var dt = new DispatcherTimer();
            timer.Interval = interval;
            timer.Tick += (_, a) =>
            {
                if (count-- == 0) timer.Stop();
                else ts(count);
            };
            ts(count);
            timer.Start();
        }
        public void StopTimer()
        {
            timer.Stop();
        }
    }
}
