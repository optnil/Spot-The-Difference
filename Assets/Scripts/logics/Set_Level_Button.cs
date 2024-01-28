using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Loading;
using UnityEngine;
using UnityEngine.UI;

public class Set_Level_Button : MonoBehaviour
{
    public Button levelButton;
    public Level_Element cell_element;
    public int level;
    public TMP_Text leveltext;
    void Start()
    {
        if(levelButton != null)
        {
            ///Debug.Log("Level button not empty");
            levelButton.onClick.AddListener(startNewGame);
            level = cell_element.level;
            leveltext.text = level.ToString();
        }
        else
        {
            Debug.Log("levelButton is empty");
        }
       
    }

    public void startNewGame()
    {
        Debug.Log("level is ->" + level);
        Mainmenu.text = level;
        Mainmenu.startNewGame();
    }
}
