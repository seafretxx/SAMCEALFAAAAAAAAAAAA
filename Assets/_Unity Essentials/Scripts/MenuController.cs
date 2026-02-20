using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public AudioMixer audioMixer;
    private bool musicMuted = false;
    private bool sfxMuted = false;
    public GameObject menu;
    private bool menuActive = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuActive = !menuActive;
            menu.SetActive(menuActive);
        }
    }
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene("PaulinaSa³ek_Scene");
    }

    public void QuitScene()
    {
        Application.Quit();
    }


    public void ButtonMuteAll()
    {
        musicMuted = !musicMuted;
        if (musicMuted)
        {
            audioMixer.SetFloat("MusicVolume", -80f);
        }
        else
        {
            audioMixer.SetFloat("MusicVolume", 0f);
        }

        sfxMuted = !sfxMuted;
        if (sfxMuted)
        {
            audioMixer.SetFloat("SFXVolume", -80f);
        }
        else
        {
            audioMixer.SetFloat("SFXVolume", 0f);
        }
    }

    public void SetMusicVolume(float sliderValue)
    {
        float db = Mathf.Lerp(-80f,0,sliderValue);
        audioMixer.SetFloat("MusicVolume", db);
    }

    public void SetSFXVolume(float sliderValue)
    {
        float db = Mathf.Lerp(-80f, 0, sliderValue);
        audioMixer.SetFloat("SFXVolume", db);
    }
   
}
