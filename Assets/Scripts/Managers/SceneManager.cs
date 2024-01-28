using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesManager : MonoBehaviour
{
    public static ScenesManager instance;

    private void Awake()
    {
        instance = this;
    }
    public enum Scene
    {
        MainMenu,
        Gameplay
    }
    //public void LoadScene(Scene scene)
    //{
    //    SceneManager.LoadScene(scene.ToString());
    //}
    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.Gameplay.ToString());
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.MainMenu.ToString());
    }

    public void LoadLevel(int level)
    {
        Mainmenu.text = level;
        LoadNewGame();
    }

}
