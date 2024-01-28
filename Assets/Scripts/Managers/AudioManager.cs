using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource musicSource;
    public AudioSource sfxSource;

    public Toggle musicToggle; // UI toggle for music
    public Toggle sfxToggle;   // UI toggle for sound effects

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Initialize();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Initialize()
    {
        // Load saved preferences or set defaults
        musicToggle.isOn = PlayerPrefs.GetInt("MusicOn", 1) == 1;
        sfxToggle.isOn = PlayerPrefs.GetInt("SFXOn", 1) == 1;

        SetMusicVolume(musicToggle.isOn ? 1f : 0f);
        SetSFXVolume(sfxToggle.isOn ? 1f : 0f);
    }

    // Play background music with fade-in
    public void PlayMusic(AudioClip musicClip, float fadeDuration = 1f)
    {
        StartCoroutine(FadeInMusic(musicClip, fadeDuration));
    }

    // Stop background music with fade-out
    public void StopMusic(float fadeDuration = 1f)
    {
        StartCoroutine(FadeOutMusic(fadeDuration));
    }

    // Play sound effect
    public void PlaySFX(AudioClip sfxClip, float volume = 1f)
    {
        if (sfxToggle.isOn)
        {
            sfxSource.PlayOneShot(sfxClip, volume);
        }
    }

    // Set music volume
    public void SetMusicVolume(float volume)
    {
        musicSource.volume = Mathf.Clamp01(volume);
        PlayerPrefs.SetInt("MusicOn", volume > 0 ? 1 : 0);
    }

    // Set sound effects volume
    public void SetSFXVolume(float volume)
    {
        sfxSource.volume = Mathf.Clamp01(volume);
        PlayerPrefs.SetInt("SFXOn", volume > 0 ? 1 : 0);
    }

    // Coroutine for fading in music
    private IEnumerator FadeInMusic(AudioClip newClip, float fadeDuration)
    {
        float startTime = Time.time;
        float startVolume = musicSource.volume;

        musicSource.clip = newClip;
        musicSource.Play();

        while (Time.time < startTime + fadeDuration)
        {
            musicSource.volume = Mathf.Lerp(startVolume, 1f, (Time.time - startTime) / fadeDuration);
            yield return null;
        }
        musicSource.volume = 1f;
    }

    // Coroutine for fading out music
    private IEnumerator FadeOutMusic(float fadeDuration)
    {
        float startTime = Time.time;
        float startVolume = musicSource.volume;

        while (Time.time < startTime + fadeDuration)
        {
            musicSource.volume = Mathf.Lerp(startVolume, 0f, (Time.time - startTime) / fadeDuration);
            yield return null;
        }
        musicSource.Stop();
        musicSource.volume = 1f;
    }
}
