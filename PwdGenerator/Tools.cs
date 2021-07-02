using System;

namespace PwdGenerator
{
    public class Tools
    {
        public static string lower = "abcdefghijklmnopqrstuvwxyz";
        public static string upper = lower.ToUpper();
        public static string integers = "0123456789";
        public static string specials = "!*$-&_^";
        public enum Difficulty
        {
            low = 1,
            medium = 2,
            hard = 3
        }
    }
}
