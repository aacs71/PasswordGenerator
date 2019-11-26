using System;

namespace Virtual.Password.Console.Commons
{
    public static class Guard
    {
        public static void Against(bool assertion, string message)
        {
            if (!assertion) return;

            throw new InvalidOperationException(message);
        }
    }
}