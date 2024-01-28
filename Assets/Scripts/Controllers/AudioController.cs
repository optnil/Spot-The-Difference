using TMPro;
using UnityEngine; 
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioClip backgroundMusic;
    public AudioClip buttonClickSound;

    public Toggle musicToggle; // UI toggle for music
    public Toggle sfxToggle;   // UI toggle for sound effects

    void Start()
    {
        musicToggle = musicToggle.GetComponent<Toggle>();
        sfxToggle = sfxToggle.GetComponent<Toggle>();

        musicToggle.onValueChanged.AddListener(ToggleMusic);
        sfxToggle.onValueChanged.AddListener(ToggleSFX);
       
        AudioManager.instance.PlayMusic(backgroundMusic);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
           AudioManager.instance.PlaySFX(buttonClickSound);
        }
    }

    // Example function to toggle music
    public void ToggleMusic(bool on)
    {
        if (!on)
        {
            Image toggleImage = musicToggle.GetComponent<Image>();
            toggleImage.color = Color.red;
            
            AudioManager.instance.StopMusic(1f);

            TMP_Text lable = musicToggle.GetComponentInChildren<TMP_Text>();
            lable.text = "OFF";
        }
        else
        {
            Image toggleImage = musicToggle.GetComponent<Image>();
            toggleImage.color = Color.green;

            AudioManager.instance.PlayMusic(backgroundMusic, 1f);

            TMP_Text lable = musicToggle.GetComponentInChildren<TMP_Text>();
            lable.text = "ON";
        }
    }

    // Example function to toggle sound effects
    public void ToggleSFX(bool on)
    {
        if (!on)
        {
            Image toggleImage = sfxToggle.GetComponent<Image>();
            toggleImage.color = Color.red;

            TMP_Text lable = sfxToggle.GetComponentInChildren<TMP_Text>();
            lable.text = "OFF";
        }
        else
        {
            Image toggleImage = sfxToggle.GetComponent<Image>();
            toggleImage.color = Color.green;

            TMP_Text lable = sfxToggle.GetComponentInChildren<TMP_Text>();
            lable.text = "ON";
        }

        AudioManager.instance.SetSFXVolume(on ? 1f : 0f);
    }
}
