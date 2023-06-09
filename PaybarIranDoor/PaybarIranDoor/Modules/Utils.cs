﻿using System;

namespace PaybarIranDoor.Modules
{
    static class Utils
    {
        public static string DateToString()
        {
            return DateTime.Now.ToString("yyyy’-‘MM’-‘dd’ ’HH’:’mm’:’ss");
        }

        public static void ValidateString(ref string message)
        {
            message = message.Replace('\'', ' ').Replace('"', ' ');
        }

        public static int PageItems
        {
            get { return 50; }
        }
    }
}
