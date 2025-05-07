using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.IO;
[System.Serializable]
public class PlayData
{
    public int HP;

    public string Name;
    public float Stamina;
    public List<string> Items = new List<string>();
    public Sprite PlayerFace;

}
public class Manager : MonoBehaviour
{
    [SerializeField]
    private int HP;

    public string Name;
    public float Stamina;

    PlayData play1Data = new PlayData();
    string savepath;

    void Start()
    {
        savepath = Application.persistentDataPath + "/player1data.json";

        play1Data.Name = "Simon";
        play1Data.HP = 100;
        play1Data.Stamina = 20;
        play1Data.Items.Add("Pocion");
        play1Data.Items.Add("Espada");
        play1Data.Items.Add("Escudo");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveGame()
    {
        PlayerPrefs.SetString("NameKey", Name);
        PlayerPrefs.SetInt("HPKey", HP);
        PlayerPrefs.SetFloat("StaminaKey", Stamina);

        PlayerPrefs.Save();

        //jaso
        string json = JsonUtility.ToJson(play1Data);
        File.WriteAllText(savepath, json);
    }

    public void LoadGameData()
    {
        Name = PlayerPrefs.GetString("NameKey");
        HP = PlayerPrefs.GetInt("HPKey");
        Stamina = PlayerPrefs.GetFloat("StaminaKey");

        //json
        string loadjson  = File.ReadAllText(savepath);
        play1Data = JsonUtility.FromJson<PlayData>(loadjson);

        Debug.Log("Name" + play1Data.Name);
    }

    public void DeleteGameData()
    {
        if (PlayerPrefs.HasKey("StaminaKey"))
        {
           
        }
    }
    public void OnApplicationQuit()
    {
        
    }
}
