using System.Runtime.CompilerServices;

namespace KahveliKodlama.Infrastructure.ContextEngine;

/// <summary>
/// Provides access to the singleton instance of the TIntegration engine.
/// </summary>
public class EngineContext
{
    #region Methods

    /// <summary>
    /// Create a static instance of the TIntegration engine.
    /// </summary>
    [MethodImpl(MethodImplOptions.Synchronized)]
    public static IEngine Create()
    {
        //create TIntegration as engine
        return Singleton<IEngine>.Instance ?? (Singleton<IEngine>.Instance = new KahveliContextEngine());
    }

    /// <summary>
    /// Sets the static engine instance to the supplied engine. Use this method to supply your own engine implementation.
    /// </summary>
    /// <param name="engine">The engine to use.</param>
    /// <remarks>Only use this method if you know what you're doing.</remarks>
    public static void Replace(IEngine engine)
    {
        Singleton<IEngine>.Instance = engine;
    }

    #endregion

    #region Properties

    /// <summary>
    /// Gets the singleton TIntegration engine used to access TIntegration services.
    /// </summary>
    public static IEngine Current {
        get {
            if (Singleton<IEngine>.Instance == null)
            {
                Create();
            }

            return Singleton<IEngine>.Instance;
        }
    }

    #endregion
}
