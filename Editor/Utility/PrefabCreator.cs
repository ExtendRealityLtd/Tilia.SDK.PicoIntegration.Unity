namespace Tilia.SDK.PicoIntegration.Utility
{
    using System.IO;
    using UnityEditor;
    using Zinnia.Utility;

    public class PrefabCreator : BasePrefabCreator
    {
        private const string group = "Tilia/";
        private const string menuItemRoot = topLevelMenuLocation + group + subLevelMenuLocation;

        private const string package = "io.extendreality.tilia.sdk.picointegration.unity";
        private const string baseDirectory = "Runtime";
        private const string prefabDirectory = "Prefabs";
        private const string prefabSuffix = ".prefab";

        private const string prefabCameraRigsPicoIntegration = "CameraRigs.PicoIntegration";

        [MenuItem(menuItemRoot + "CameraRigs/" + prefabCameraRigsPicoIntegration, false, priority)]
        private static void AddCameraRigsPicoIntegration()
        {
            string prefab = prefabCameraRigsPicoIntegration + prefabSuffix;
            string packageLocation = Path.Combine(packageRoot, package, baseDirectory, prefabDirectory, prefab);
            CreatePrefab(packageLocation);
        }
    }
}