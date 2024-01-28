using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause_Popup_Manager : MonoBehaviour
{
    public GameObject popup;
    public GameObject popup_container;

    public Button close;
    public Button resume;
    public Button home;
    // Start is called before the first frame update
    void Start()
    {
        close.onClick.AddListener(closePopup);
        resume.onClick.AddListener(closePopup);
        home.onClick.AddListener(returnToMainMenu);
    }

    public Boolean isActive()
    {
        return popup_container.activeSelf;
    }
    // Update is called once per frame
    void Update()
    {
        
        
    }
    void closePopup()
    {
        Mainmenu.game_pause = false;
        popup_container.SetActive(false);
    }
    void returnToMainMenu()
    {
        ScenesManager.instance.LoadMainMenu();
    }
}
