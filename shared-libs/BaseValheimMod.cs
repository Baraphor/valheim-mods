using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using JotunnLib.Managers;
using System;
using System.Reflection;
using UnityEngine;

namespace BaraphorSharedLibs
{
    public class BaseValheimMod : BaseUnityPlugin
    {
        protected bool IsDebugging = false;

        protected AssetBundle AssetBundle;

        protected Harmony Harmony;

        public BaseValheimMod(string guid) : base()
        { 
            Harmony = new Harmony(guid);
        }

        public void LoadAssetBundle(string file, Assembly assembly)
        {
            AssetBundle = AssetBundleHelper.GetAssetBundleFromResources(file, assembly);
        }

        public void RegisterPrefab(string path, string name)
        {
            if (AssetBundle != null)
            {
                AccessTools.Method(typeof(PrefabManager), "RegisterPrefab", new Type[] { typeof(GameObject), typeof(string) }).Invoke(PrefabManager.Instance, 
                    new object[] {
                                    AssetBundle.LoadAsset<GameObject>(path),
                                    name
                                }
                );
            }
        }

        public void Log(object data, LogLevel level = LogLevel.Info)
        {
            if (IsDebugging)
            {
                switch (level)
                {
                    case LogLevel.None:
                        LogInfo(data);
                        break;
                    case LogLevel.Debug:
                        LogDebug(data);
                        break;
                    case LogLevel.Message:
                        LogMessage(data);
                        break;
                    case LogLevel.Info:
                        LogInfo(data);
                        break;
                    case LogLevel.Warning:
                        LogWarning(data);
                        break;
                    case LogLevel.Error:
                        LogError(data);
                        break;
                    case LogLevel.Fatal:
                        LogFatal(data);
                        break;
                    case LogLevel.All:
                        LogInfo(data);
                        break;
                    default:
                        LogInfo(data);
                        break;
                }
            }
        }

        private void LogDebug(object data)
        {
            if(!IsDebugging) { return; }
            this.Logger.LogDebug(data);
        }

        private void LogError(object data)
        {
            if (!IsDebugging) { return; }
            this.Logger.LogError(data);
        }

        private void LogFatal(object data)
        {
            if (!IsDebugging) { return; }
            this.Logger.LogFatal(data);
        }

        private void LogInfo(object data)
        {
            if (!IsDebugging) { return; }
            this.Logger.LogInfo(data);
        }

        private void LogMessage(object data)
        {
            if (!IsDebugging) { return; }
            this.Logger.LogMessage(data);
        }

        private void LogWarning(object data)
        {
            if (!IsDebugging) { return; }
            this.Logger.LogWarning(data);
        }
    }
}
