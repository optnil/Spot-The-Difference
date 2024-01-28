using UnityEngine;
using UnityEngine.UI;

public class SetUpGame : MonoBehaviour
{
    public Image image_1;
    public Image image_2;
    public GameObject gameendpopup;
    public Topbar_Manager topbar;

    string newImagePath = "Sprites/Levels"; // Path to the new sprite

    void Start()
    {
        Mainmenu.game_pause = false;
        Debug.Log("ingame start");
        topbar.readyForInGame();
        gameendpopup.SetActive(false);
        // Load the sprite from the Resources folder using the provided path
        int level = Mainmenu.text;
        string image1Path = newImagePath + "/" + level + "/IMG_1";
        string image2Path = newImagePath + "/" + level + "/IMG_2";

        Sprite image1Sprite = Resources.Load<Sprite>(image1Path);
        Sprite image2Sprite = Resources.Load<Sprite>(image2Path);

        if (image1Sprite != null && image2Sprite != null)
        {
            // Change the sprite of the Image component
            image_1.sprite = image1Sprite;
            image_2.sprite = image2Sprite;
        }
        else
        {
            Debug.Log(image1Path);
            Debug.Log(image2Path);
            Debug.LogError("Failed to load the sprite. Check the path: " + newImagePath);
        }
    }
}
