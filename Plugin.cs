using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace TooManyEmotesAdditionalEmotes;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
[BepInDependency("FlipMods.TooManyEmotes")]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;
    public static Plugin instance;
        
    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        instance = this;

        EmoteLoader.LoadAssets();

        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
    }
}
