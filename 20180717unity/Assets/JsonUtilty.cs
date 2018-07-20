using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* public void OnClickToJSON() {
users item = new users();
item.name = "はるしおん";
        item.age = 4;

        string json = JsonUtility.ToJson(item);
Debug.Log(json);
    }*/

public class JsonUtilty : MonoBehaviour
{

    //Textに貼り付ける
    public Text txtString;
   
    //一つ追加0717

    void Start()
    {
        //Resourcesファイルから"test1"(.txt)をロードする
        TextAsset txtData = Resources.Load("test2") as TextAsset;

        //エラーコード:Null Reference Exception:object reference not set to an instance of an object
        string textJson = txtData.text;
    
        users item = JsonUtility.FromJson<users>(textJson);
        //txtString = GetComponent<Text>();
        //ここにも追加0717
        txtString.text = item.name + "\r\n" + item.age + "\r\n" + item.hp + "\r\n" + item.attack + "\r\n" + item.Deffence;

    }
}