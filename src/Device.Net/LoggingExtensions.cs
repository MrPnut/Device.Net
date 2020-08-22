﻿using Microsoft.Extensions.Logging;
using System;

namespace Device.Net
{
    public static class LoggingExtensions
    {
        public static void LogTrace<T>(this ILogger logger, T state)
        {
            if (logger == null) throw new ArgumentNullException(nameof(logger));

            logger.Log(LogLevel.Trace, default, state, null, (s, e) => $"Trace\r\nState: {state}");
        }
    }
}