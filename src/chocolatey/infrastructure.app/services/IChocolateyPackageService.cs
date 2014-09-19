﻿namespace chocolatey.infrastructure.app.services
{
    using System.Collections.Concurrent;
    using configuration;
    using results;

    /// <summary>
    ///   The packaging service
    /// </summary>
    public interface IChocolateyPackageService
    {
        /// <summary>
        ///   Run list in noop mode
        /// </summary>
        /// <param name="config">The configuration.</param>
        void list_noop(ChocolateyConfiguration config);

        /// <summary>
        ///   Lists/searches for packages that meet a search criteria
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="logResults">Should results be logged?</param>
        /// <returns></returns>
        void list_run(ChocolateyConfiguration config, bool logResults);

        /// <summary>
        ///   Run pack in noop mode
        /// </summary>
        /// <param name="config">The configuration.</param>
        void pack_noop(ChocolateyConfiguration config);

        /// <summary>
        ///   Compiles a package
        /// </summary>
        /// <param name="config">The configuration.</param>
        void pack_run(ChocolateyConfiguration config);

        /// <summary>
        /// Run push in noop mode
        /// </summary>
        /// <param name="config">The configuration.</param>
        void push_noop(ChocolateyConfiguration config);

        /// <summary>
        ///  Pushes packages to remote feeds.
        /// </summary>
        /// <param name="config">The configuration.</param>
        void push_run(ChocolateyConfiguration config);

        /// <summary>
        ///   Run install in noop mode
        /// </summary>
        /// <param name="config">The configuration.</param>
        void install_noop(ChocolateyConfiguration config);

        /// <summary>
        ///   Installs packages
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns>results of installs</returns>
        ConcurrentDictionary<string, PackageResult> install_run(ChocolateyConfiguration config);

        /// <summary>
        ///   Run upgrade in noop mode
        /// </summary>
        /// <param name="config">The configuration.</param>
        void upgrade_noop(ChocolateyConfiguration config);

        /// <summary>
        ///   Upgrades packages
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns>results of upgrades</returns>
        ConcurrentDictionary<string, PackageResult> upgrade_run(ChocolateyConfiguration config);

        /// <summary>
        ///   Run uninstall in noop mode
        /// </summary>
        /// <param name="config">The configuration.</param>
        void uninstall_noop(ChocolateyConfiguration config);

        /// <summary>
        ///   Uninstalls packages
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns>results of upgrades</returns>
        ConcurrentDictionary<string, PackageResult> uninstall_run(ChocolateyConfiguration config);
    }
}