using System.Diagnostics;
using UnityEditor;


public static class EditorTest
{
    [MenuItem("Test/Test")]
    public static void Test()
    {
         UnityEngine.Debug.Log("test");
    }
 
}
