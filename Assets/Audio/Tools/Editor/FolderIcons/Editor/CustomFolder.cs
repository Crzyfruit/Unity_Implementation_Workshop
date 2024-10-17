using System.IO;
using UnityEditor;
using UnityEngine;

namespace FolderIcon.Editor
{
    [InitializeOnLoad]
    public class CustomFolder
    {
        static CustomFolder()
        {
            IconDictionaryCreator.BuildDictionary();
            EditorApplication.projectWindowItemOnGUI += DrawFolderIcon;
        }

        public static void DrawFolderIcon(string guid, Rect rect)
        {
            var path = AssetDatabase.GUIDToAssetPath(guid);
            var iconDictionary = IconDictionaryCreator.IconDictionary;

            if (string.IsNullOrEmpty(path) ||
                Event.current.type != EventType.Repaint ||
                !File.GetAttributes(path).HasFlag(FileAttributes.Directory))
            {
                return;
            }

            var folderName = Path.GetFileName(path);


            if (!iconDictionary.ContainsKey(folderName))
            {
                string parentPath = Directory.GetParent(path)?.FullName;
                if (!string.IsNullOrEmpty(parentPath))
                {
                    var parentFolderName = Path.GetFileName(parentPath);
                    if (iconDictionary.ContainsKey(parentFolderName))
                    {
                        iconDictionary[folderName] = iconDictionary[parentFolderName];
                    }
                }
            }

            if (!iconDictionary.ContainsKey(folderName))
            {
                return;
            }

            var texture = iconDictionary[folderName];
            if (texture == null)
            {
                return;
            }

            Rect imageRect;

            if (rect.height > 20)
            {
                imageRect = new Rect(rect.x - 1, rect.y - 1, rect.width + 2, rect.width + 2);
            }
            else if (rect.x > 20)
            {
                imageRect = new Rect(rect.x - 1, rect.y - 1, rect.height + 2, rect.height + 2);
            }
            else
            {
                imageRect = new Rect(rect.x + 2, rect.y - 1, rect.height + 2, rect.height + 2);
            }

            GUI.DrawTexture(imageRect, texture);
        }
    }
}
