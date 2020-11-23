using UnityEditor;
using UnityEngine;

public class Script_03_04 : UnityEditor.AssetModificationProcessor
{
    [InitializeOnLoadMethod]
    static void InitializeOnLoadMethod()
    {
        // 全局监听Project视图下的资源是否发生变化(添加，删除和移动)
        EditorApplication.projectChanged += delegate ()
        {
            Debug.Log("project assets changed");
        };
    }

    /*
    // 监听“双击鼠标左键，打开资源”事件
    public static bool IsOpenForEdit(string assetPath, string message)
    {
        // message = null;
        Debug.LogFormat("asset path : {0}", assetPath);

        // true表示该资源可以打开， false表示不允许在Unity中打开该资源
        return true;
    }
    */

    // 监听 “资源即将被创建”事件 

    public static void OnWillCreateAsset(string path)
    {
        Debug.LogFormat("path : {0}", path);
    }
    
    // 监听“资源即将被保存”事件
    public static string[] OnWillSaveAssets(string[] paths)
    {
        if(paths != null)
        {
            Debug.LogFormat("path : {0}", string.Join(",", paths));
        }
        return paths;
    }

    // 监听 “资源即将被移动”事件
    public static AssetMoveResult OnWillMoveAsset(string oldPath, string newPath)
    {
        Debug.LogFormat("from : {0} to {1}", oldPath, newPath);

        // DidMove: 该资源可以移动
        return AssetMoveResult.DidMove;
    }

    // 监听“资源即将被删除”事件
    public static AssetDeleteResult OnWillDeleteAsset(string path, RemoveAssetOptions option)
    {
        Debug.LogFormat("delete : {0}", path);

        // DidDelete: 可以被删除
        return AssetDeleteResult.DidDelete;
    }
}
