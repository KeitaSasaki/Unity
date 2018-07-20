using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JsonUtilty : MonoBehaviour
{
    //Textに貼り付ける
    public Text txtString;

    void Start()
    {
        //Resourcesファイルから"test1"(.txt)をロードする
        TextAsset txtData = Resources.Load("test1") as TextAsset;

        //エラーコード:Null Reference Exception:object reference not set to an instance of an object
        string textJson = txtData.text;

        users item = JsonUtility.FromJson<users>(textJson);

        txtString.text = item.name +"\r\n" + item.age;
    }
}