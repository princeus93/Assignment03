
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("You win");
        Score.currentScore += 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
