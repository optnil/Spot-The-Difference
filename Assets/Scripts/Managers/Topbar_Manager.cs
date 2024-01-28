using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Topbar_Manager : MonoBehaviour
{
    public Button settings;
    public Button pause;
    public GameObject respectivePopup;
    public TMP_Text score;

    public void readyForMainMenu()
    {
        settings.enabled = true;
        pause.enabled = false;
        score.text = Player.player_score.ToString();
        settings.onClick.AddListener(openOrCloseRespectivePopup);

    }

    public void readyForInGame()
    {
        Debug.Log("ready for ingame");
        settings.enabled = false;
        pause.enabled = true;
        score.text = Player.player_score.ToString();
        pause.onClick.AddListener(openOrCloseRespectivePopup);
    }

    public void openOrCloseRespectivePopup()
    {
        //if popup is active then disable it and viseversa
        if (respectivePopup.activeSelf)
        {
            Mainmenu.game_pause = false;
            respectivePopup.SetActive(false);
        }
        else
        {
            Mainmenu.game_pause = true;
            respectivePopup.SetActive(true);
        }
    }
}
