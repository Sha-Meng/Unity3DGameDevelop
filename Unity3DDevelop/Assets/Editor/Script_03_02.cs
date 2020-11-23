using UnityEngine;
using UnityEditor;

public class Script_03_02 : MonoBehaviour
{
    [MenuItem("Assets/Create/My Create/Cube",false, 2)]
    static void CreateCube()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    [MenuItem("Assets/Create/My Create/Sphere",false,1)]
    static void CreateSphere()
    {
        GameObject.CreatePrimitive(PrimitiveType.Sphere);
    }
}
