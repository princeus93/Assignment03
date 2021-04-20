using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
   // public Transform frog;
    public int playerLives;
    public GameObject player;
    public Text livesText;
    public Score score;
    //public PlayerLives pl;
    //public Lives lives;
    //public DropDownLiveSelect ddLiveSelect;


    private void Start()
    {
       playerLives = DropDownLiveSelect.livesSelected;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);

        livesText.text = playerLives.ToString();

        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.tag == "Car" && playerLives > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
            
        }
        else if (collision.tag == "Car" && playerLives == 0)
        {
            Score.currentScore = 0;
            Debug.Log("We Lost!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }*/

        /*if (collision.tag == "Car" && playerLives > 0)
        {
            playerLives--;
            SceneLoad.Destroy(player);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log("life lost, reset frog");
            

        }
        else //(Collision2D.Equals(collision.tag, "Car") && playerLives > 0)
        {
            SceneLoad.endScene();
            Debug.Log("Game Over");
        }*/

        if (Collision2D.Equals(collision.tag, "Car") && playerLives != 0)
        {
            playerLives--;
        }
        else
        {
            SceneLoad.Destroy(player);
            SceneLoad.endScene();
        }
        

    }



}
