using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI highScoreText;
    public int scoreValue;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
      //  DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        LoadData();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void OnStartClick()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("on start click");
    }

    public void SaveHighScoreData(int value)
    {
        // LoadColor();
        UnityEngine.Debug.Log("savedata called");
        string path = Application.persistentDataPath + "/savefile.json";
        int tmpPoint = 0;
        if (File.Exists(path))
        {
            string jsonValue = File.ReadAllText(path);
            SaveData tempData = JsonUtility.FromJson<SaveData>(jsonValue);
            tmpPoint = tempData.scorePoint;
        }
        if (tmpPoint <= value)
        {

            SaveData data = new SaveData();
            data.scorePoint = value;

            string json = JsonUtility.ToJson(data);

            File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        }
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            int point = data.scorePoint;
            highScoreText.text = point.ToString();
        }
    }

}

[System.Serializable]
class SaveData
{
    public int scorePoint;
}