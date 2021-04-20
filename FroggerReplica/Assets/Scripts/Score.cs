using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int currentScore = 0;

    public Text scoreText;

    private void Start()
    {
        scoreText.text = currentScore.ToString();

    }
    private void Update()
    {
        
    }

    private Save CreateSaveGameObject()
    {
        Save save = new Save();
        save.score = currentScore;
        return save;
    }

    public void SaveGame()
    {
        Save save = CreateSaveGameObject();

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();

        scoreText.text = "Score: " + currentScore;

        Debug.Log("Game Saved");

    }

    public void LoadGame()
    {
        if(File.Exists(Application.persistentDataPath + "/gamesave.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open);
            Save save = (Save)bf.Deserialize(file);
            file.Close();

            scoreText.text = "Score: " + save.score;
            currentScore = save.score;

            Debug.Log("game loaded");
        }
        else
        {
            Debug.Log("No game saved");
        }
    }

    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("saving to JSON: " + json);
    }
}
