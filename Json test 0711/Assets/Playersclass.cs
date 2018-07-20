using UnityEngine;

[System.Serializable]
public class PlayerInfo
{
    public string name;
    public int lives;
    public float health;
    

    public static PlayerInfo CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<PlayerInfo>(jsonString);
    }

}