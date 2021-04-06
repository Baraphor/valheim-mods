using System.Linq;
using System.Reflection;
using UnityEngine;

namespace BaraphorSharedLibs
{
    public class AssetBundleHelper
    {
        public static AssetBundle GetAssetBundleFromResources(string fileName, Assembly assembly)
        {
            var resourceName = assembly.GetManifestResourceNames()
                .Single(str => str.EndsWith(fileName));

            AssetBundle assetBundle;
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                assetBundle = AssetBundle.LoadFromStream(stream);
            }

            return assetBundle;
        }
    }
}
