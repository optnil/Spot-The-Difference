using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameEndManager : MonoBehaviour
{
    //public TMP_Text scoreText;
    public GameObject gameEndPopup;
    public Button main_menu_button;
    public Button continue_button;

    public GameObject gameLostPopup;
    public Button gl_main_menu;
    public Button restart;

    public void ShowPopup(int finalScore)
    {
        // Display the final score.
        //scoreText.text = "Final Score: " + finalScore;

        // Show the popup.
        gameEndPopup.SetActive(true);
        Mainmenu.game_pause = true;

        if (Mainmenu.text >= Player.player_level)
        {
            Player.player_score = Player.player_score + 3;
            Player.player_level = Player.player_level + 1;

            PlayerDataController.UpdateHighScore(Player.player_score);
            PlayerDataController.UpdateLevel(Player.player_level);

            
        }

        Animation animation = gameEndPopup.GetComponent<Animation>();
            animation.Play();

        main_menu_button.onClick.AddListener(ReturnToMainMenu);
        continue_button.onClick.AddListener(Continue);
    }

    public void Game_lost_popup()
    {
        gameLostPopup.SetActive(true);
        Mainmenu.game_pause = true;

        Animation animation = gameLostPopup.GetComponent<Animation>();
        animation.Play();

        gl_main_menu.onClick.AddListener(ReturnToMainMenu);
        restart.onClick.AddListener(Restart);
    }

    public void ReturnToMainMenu()
    {
        
        ScenesManager.instance.LoadMainMenu();
    }

    public void Continue()
    {
        int level = Mainmenu.text;
        level++;
        ScenesManager.instance.LoadLevel(level);
    }

    public void Restart()
    {
        int level = Mainmenu.text;
        ScenesManager.instance.LoadLevel(level);
    }
}
