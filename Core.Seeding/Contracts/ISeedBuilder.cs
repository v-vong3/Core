using Core.Interfaces;
using Core.Seeding.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Seeding.Contracts
{
    /// <summary>
    /// Contract for registering and unregistering seeding data sources
    /// </summary>
    public interface ISeedBuilder : IBuilderAsync<ISeedSource>
    {
        /// <summary>
        /// Registers <see cref="ISeedDatum"/> wrapped POCOs for data seed process  
        /// </summary>
        /// <remarks>
        /// The input will be boxed as an <see cref="ISeedDatum"/> for interface extensibility.  It is the
        /// responsibility of the concrete <see cref="ISeeder{T}"/> to unbox and process the raw data.
        /// </remarks>
        /// <param name="seedData">Collection of <see cref="ISeedDatum"/></param>
        /// <returns>The current builder instance to enable fluent API</returns>
        ISeedBuilder AddDatum(params ISeedDatum[] seedData);

        /// <summary>
        /// Registers the filenames of scripts for data seed process
        /// </summary>
        /// <param name="scriptFilenames">Fully-qualified filenames</param>
        /// <returns>The current builder instance to enable fluent API</returns>
        ISeedBuilder AddScript(params string[] scriptFilenames);


        /// <summary>
        /// Removes all <see cref="ISeedDatum"/> having matching <see cref="ISeedDatum.Type"/>
        /// </summary>
        /// <param name="type">The <see cref="Type"/> of the seed data</param>
        /// <returns>The current builder instance to enable fluent API</returns>
        ISeedBuilder RemoveDatum(Type type);

        /// <summary>
        /// Unregisters a script matching the provided argument value
        /// </summary>
        /// <param name="scriptFilename"></param>
        /// <returns>The current builder instance to enable fluent API</returns>
        ISeedBuilder RemoveScript(string scriptFilename);

        /// <summary>
        /// Unregisters all <see cref="ISeedDatum"/> by default.  
        /// If <c>includeScripts</c> flag is set to true, all scripts are unregistered as well 
        /// </summary>
        /// <param name="includeScripts">
        /// True, to unregister all scripts along with data objects.  
        /// False, to only unregister data objects. 
        /// </param>
        /// <returns>The current builder instance to enable fluent API</returns>
        ISeedBuilder Clear(bool includeScripts);

    }
}
