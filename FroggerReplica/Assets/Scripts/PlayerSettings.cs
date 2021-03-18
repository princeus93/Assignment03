
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : MonoBehaviour
{
    [SerializeField]
    private int lives;
    [SerializeField] 
    private Text livesText;
    [SerializeField]
    private Frog frog;
    [SerializeField]
    private int currentScore;
    [SerializeField]
    private Text scoreText;

    

    private void Update()
    {
        lives = frog.playerLives;
        currentScore = Score.currentScore;
        livesText.text = lives.ToString();
        scoreText.text = currentScore.ToString();
    }
    public void Awake()
    {

        
    }

}
