using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public static string nameOfPlayer;
    public static float minCarSpeed;
    public static float maxCarSpeed;

    public string saveName;
    public float saveMinCarSpeed;
    public float saveMaxCarSpeed;

    public Text playerName;
    public Text loadedName;
    public Text minCarSpeedText;
    public Text maxCarSpeedText;

    public Slider minSlider;
    public Slider maxSlider;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

    }
    

    // Update is called once per frame
    void Update()
    {
        nameOfPlayer = PlayerPrefs.GetString("name", "none");
        loadedName.text = nameOfPlayer;

        minCarSpeed = PlayerPrefs.GetFloat("minSpeed");
        minSlider.value = minCarSpeed;

        maxCarSpeed = PlayerPrefs.GetFloat("maxSpeed");
        maxSlider.value = maxCarSpeed;
    }

    public void SetName()
    {
        saveName = playerName.text;
        PlayerPrefs.SetString("name", saveName);

    }

    public void SetMinSpeed()
    {
        saveMinCarSpeed = minCarSpeed;
        PlayerPrefs.SetFloat("minSpeed", saveMinCarSpeed);
    }

    public void SetMaxSpeed()
    {
        saveMaxCarSpeed = maxCarSpeed;
        PlayerPrefs.SetFloat("maxSpeed", saveMaxCarSpeed);
    }
}
