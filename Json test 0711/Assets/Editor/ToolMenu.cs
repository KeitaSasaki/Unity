using UnityEditor;
using UnityEngine;

public class ToolMenu
{

    #region JSONの動作テスト
    [MenuItem("Tool/Json Test")]
    static void JsonTest()
    {//別JSONで
        PlayerInfo pi = PlayerInfo.CreateFromJSON("{\"name\":\"あああああああ\", \"lives\":999,\"health\":11.1}");
        //ksokso
        Debug.Log("pi.name = " + pi.name);
        Debug.Log("pi.lives = " + pi.lives);
        Debug.Log("pi.health = " + pi.health);
    }
    #endregion

}