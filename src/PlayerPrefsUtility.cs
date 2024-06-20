using UnityEngine;
using UnityEditor;

public class PlayerPrefsUtility
{
    [MenuItem("Tools/Clear PlayerPrefs")]
    private static void ClearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save();
        Debug.Log("PlayerPrefs have been cleared!");
    }
}
