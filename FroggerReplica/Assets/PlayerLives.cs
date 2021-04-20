using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public static int livesOfPlayer;
    public string saveLives;


    public Text playerLives;
    public Text loadedLives;

    public Frog frog;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

    }
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        livesOfPlayer = frog.playerLives;
        loadedLives.text = livesOfPlayer.ToString();
        playerLives.text = livesOfPlayer.ToString();
   
    }

    public void SetLives()
    {
        saveLives = playerLives.text;
        PlayerPrefs.SetString("lives", saveLives);

    } 
}

