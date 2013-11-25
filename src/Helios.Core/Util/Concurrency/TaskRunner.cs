﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Helios.Core.Util.Concurrency
{
    /// <summary>
    /// Internal factory class for spawning Task instances
    /// </summary>
    internal class TaskRunner
    {
        public static Task Run(Action a)
        {
            return Task.Run(a);
        }

        public static Task Run(Action a, CancellationToken c)
        {
            return Task.Run(a, c);
        }

        public static Task<T> Run<T>(Func<T> f)
        {
            return Task.Run(f);
        }

        public static Task<T> Run<T>(Func<T> f, CancellationToken c)
        {
            return Task.Run(f, c);
        }
    }
}
