
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("+100 points");
            Score.currentScore += 100;
            //PlayerPrefs.Save();
           // DontDestroyOnLoad(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }
}
