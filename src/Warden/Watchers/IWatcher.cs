﻿using System.Threading.Tasks;

namespace Warden.Watchers
{
    /// <summary>
    /// Common interface for all of the watchers. 
    /// Contains the configurable name of the watcher, and the ExecuteAsync() method that performs a single check.
    /// </summary>
    public interface IWatcher
    {
        /// <summary>
        /// Customizable name of the watcher.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Optional name of the group that watcher belongs to.
        /// </summary>
        string Group { get; }

        /// <summary>
        /// Performs a single check for the watcher.
        /// </summary>
        /// <returns>Instance of IWatcherCheckResult.</returns>
        Task<IWatcherCheckResult> ExecuteAsync();
    }
}