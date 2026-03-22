using UnityEditor;
using UnityEngine;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEditor.AssetDatabase;

namespace BlackMageZerafTools {
    public static class ProjectSetup {

        [MenuItem("Tools/BlackMageZeraf/Create Default Directories")]
        public static void CreateDefaultDirectories() {
            Directories.CreateDefault("_Project", "Animations", "Art", "Materials", "Models", "Prefabs", "Scenes", "ScriptableObjects", "Scripts", "Settings", "Sounds");
            Refresh();
        }

        static class Directories {
            public static void CreateDefault(string root, params string[] directories) {
                string full_path = Combine(Application.dataPath, root);
                foreach (string directory in directories) {
                    string path = Combine(full_path, directory);
                    if (!Exists(path)) {
                        CreateDirectory(path);
                    }
                }
            }
        }
    }
}