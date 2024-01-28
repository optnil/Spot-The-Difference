using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameplaySceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text text;
    //[SerializeField] Button mainMenu;
    void Start()
    {
        Debug.Log("gameplaye level is-> " + Mainmenu.text);
        text.text = Mainmenu.text.ToString();
       // mainMenu.onClick.AddListener(toMainMenu);
    }

    private void toMainMenu()
    {
        ScenesManager.instance.LoadMainMenu();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
