﻿namespace BinaryPatrick.Prune
{
    internal interface IConsoleLogger
    {
        void LogWarning(string text);
        void LogCritical(string text);
        void LogInformation(string text);
        void LogVerbose(string text);
        void LogTrace(string text);
    }
}