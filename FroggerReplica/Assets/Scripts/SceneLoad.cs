using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{


    // Start is called before the first frame update
    public static void loadStart()
    {
        
        SceneManager.LoadScene(1);
    }

    public static void loadStartMenu()
    {
        
        SceneManager.LoadScene(0);
    }

    public static void endScene()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
