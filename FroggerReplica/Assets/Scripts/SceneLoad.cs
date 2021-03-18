using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{


    // Start is called before the first frame update
    public static void Start()
    {
        
        SceneManager.LoadScene(1);
    }

    public static void loadStartMenu()
    {
        SceneManager.LoadScene(0);
    }
}
