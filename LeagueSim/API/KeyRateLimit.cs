﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace LeagueSim.API
{
    public static class KeyRateLimit
    {
        /// Rate Limit(s):
        /// 10 requests every 10 seconds 
        /// 500 requests every 10 minutes
        public static int requestsRemaining = 10;

        public static void Request()
        {
            if (CanRequest())
            {
                // execute request
                Interlocked.Decrement(ref requestsRemaining);
                updateRequestsRemaining();
            }
            else
            {
                Console.Write("Please try again in a few seconds.");
            }
        }

        public static void updateRequestsRemaining()
        {
            // THIS NEEDS TO BE ASYNCHRONOUS
            System.Timers.Timer timer = new System.Timers.Timer(1200);
            timer.Elapsed += OnTimedEvent;

            while (requestsRemaining < 10)
            {
                timer.Enabled = true;
            }
            timer.Enabled = false;
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (requestsRemaining < 10)
            {
                Interlocked.Increment(ref requestsRemaining);
            }
        }

        private static bool CanRequest()
        {
            if (requestsRemaining < 1)
            {
                return false;
            }

            return true;
        }
    }
}
