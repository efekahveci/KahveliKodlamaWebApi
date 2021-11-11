using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;

namespace KahveliKodlama.Infrastructure.ContextEngine
{
    /// <summary>
    /// Classes implementing this interface can serve as a portal for the various services composing the TIntegration engine. 
    /// Edit functionality, modules and implementations access most TIntegration functionality through this interface.
    /// </summary>
    public interface IEngine
    {
        /// <summary>
        /// Configure HTTP request pipeline
        /// </summary>
        /// <param name="application">Builder for configuring an application's request pipeline</param>
        void ConfigureRequestPipeline(IApplicationBuilder application);

        /// <summary>
        /// Resolve dependency
        /// </summary>
        /// <typeparam name="T">Type of resolved service</typeparam>
        /// <returns>Resolved service</returns>
        T Resolve<T>() where T : class;

        /// <summary>
        /// Resolve dependency
        /// </summary>
        /// <param name="type">Type of resolved service</param>
        /// <returns>Resolved service</returns>
        object Resolve(Type type);

        /// <summary>
        /// Resolve dependencies
        /// </summary>
        /// <typeparam name="T">Type of resolved services</typeparam>
        /// <returns>Collection of resolved services</returns>
        IEnumerable<T> ResolveAll<T>();
    }
}
