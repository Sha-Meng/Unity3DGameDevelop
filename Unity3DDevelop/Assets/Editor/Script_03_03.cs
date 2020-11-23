using UnityEngine;
using UnityEditor;

public class Script_03_03
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
        // 为project窗口的每个可视列表项委派OnGUI事件
        // Delegate for OnGUI events for every visible list item in the ProjectWindow.
        EditorApplication.projectWindowItemOnGUI = delegate (string guid, Rect selectionRect)
        {
            // 在Project试图中选中一个资源
            if (Selection.activeObject &&
            guid == AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(Selection.activeObject)))
            {
                // 设置扩展按钮区域
                float width = 50f;
                selectionRect.x += (selectionRect.width - width);
                selectionRect.y += 2f;
                selectionRect.width = width;
                GUI.color = Color.red;

                // 点击事件
                if (GUI.Button(selectionRect, "click"))
                {
                    Debug.LogFormat("click: {0}", Selection.activeObject.name);
                }
                GUI.color = Color.white;
            }
        };
    }
}

