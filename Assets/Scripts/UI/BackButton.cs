using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{

    //[SerializeField] Button _backButton;
    // Start is called before the first frame update
    void Start()
    {
        //_backButton.onClick.AddListener(loadMainmenu);
    }

    public static void loadMainmenu()
    {
        //text = _startGame.level;
        ScenesManager.instance.LoadMainMenu();
    }
}
