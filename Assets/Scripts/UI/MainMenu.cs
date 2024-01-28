

using System;
using UnityEngine;


public class Mainmenu : MonoBehaviour
{
    public Topbar_Manager topbar;
    public static int text;
    public static Boolean game_pause = false;
    void Start()
    {
        topbar.readyForMainMenu();
    }

    public static void startNewGame()
    {
        //text = _startGame.level;
        ScenesManager.instance.LoadNewGame();
    }

}
