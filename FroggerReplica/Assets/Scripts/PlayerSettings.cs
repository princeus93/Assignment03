
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettings : MonoBehaviour
{
    [SerializeField]
    private Toggle toggle;
    [SerializeField]
    private AudioSource myAudio;
    [SerializeField]
    private Slider minSlider;
    [SerializeField]
    private Slider maxSlider;
    [SerializeField]
    public  float minSpeed;
    [SerializeField]
    public float maxSpeed;
    [SerializeField]
    private Text minSpeedText;
    [SerializeField]
    private Text maxSpeedText;

    public void Awake()
    {
        if (!PlayerPrefs.HasKey("music"))
        {
            PlayerPrefs.SetInt("music", 1);
            toggle.isOn = true;
            myAudio.enabled = true;
            PlayerPrefs.Save();
        }
        else
        {
            if(PlayerPrefs.GetInt("music") == 0)
            {
                myAudio.enabled = false;
                toggle.isOn = false;
            }
            else
            {
                myAudio.enabled = true;
                toggle.isOn = true;
            }
        }
    }

    public void ToggleMusic()
    {
        if (toggle.isOn)
        {
            PlayerPrefs.SetInt("music", 1);
            myAudio.enabled = true; 
        }
        else
        {
            PlayerPrefs.SetInt("music", 0);
            myAudio.enabled = false;
        }
        PlayerPrefs.Save();
    }

    public void SetMinSpeed()
    {
        string i;
        minSpeed = minSlider.value;
        PlayerPrefs.SetFloat("minSpeed", minSpeed);
        
        i = minSpeed.ToString();
        minSpeedText.text = i ;

        PlayerPrefs.Save();
    }

    public void SetMaxSpeed()
    {
        string i;
        maxSpeed = maxSlider.value;
        PlayerPrefs.SetFloat("maxSpeed", maxSpeed);

        i = maxSpeed.ToString();
        maxSpeedText.text = i;

        PlayerPrefs.Save();
    }
}
