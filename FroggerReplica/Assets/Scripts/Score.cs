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
}
