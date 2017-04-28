using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LeagueSim.API
{
    public static class KeyRateLimit
    {
        /// Rate Limit(s):
        /// 10 requests every 10 seconds 
        /// 500 requests every 10 minutes
        public static int RequestCount = 0;

        public static bool CanRequest()
        {
            //Timer timer = new Timer(1000);
            //timer.Elapsed += async (sender, e) => await HandleTimer();
            //timer.Start();

            return true;
        }

    }
}
