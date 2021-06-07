using UnityEditor;

namespace Geekbrains
{
    public class MenuItems
    {
        [MenuItem("Geekbrains/RadiusSpam ")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(RadiusSpam), false, "RadiusSpam");
        }
        
        [MenuItem("Geekbrains/Logger ")]
        private static void MenuOption1()
        {
            EditorWindow.GetWindow(typeof(Logger), false, "Logger");
        }
    }
}