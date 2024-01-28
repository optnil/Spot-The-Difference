
//Loads Mainmenu based on current level and loaded levels

using UnityEngine;

public class Level_Selector : MonoBehaviour
{
    public GameObject levelGrid;
    public Level_Element levelButton;
    public int current_levels = 1;
    public int loaded_levels = 15;

    string thumbnail_path = "Sprites/Levels";

    // Start is called before the first frame update
    void Start()
    {
        
        current_levels = Player.player_level +  1;
        LoadLevels(loaded_levels,levelGrid);

    }

    //creating multiple variants of the level_element
    void LoadLevels(int numberOfLevels, GameObject levelGrid)
    {
        if (numberOfLevels >= current_levels)
        {
            Debug.Log("Hello");
            for (int i = 1; i <= numberOfLevels; i++)
            {
                Debug.Log("Hello2");
                Level_Element level = Instantiate(levelButton);
                level.level = i;
                // level.leveltext.text = (i).ToString();
                level.enabled = true;
                level.transform.SetParent(transform, false);
                level.transform.SetParent(levelGrid.transform);
                level.transform.localScale = Vector3.one;

                //Loading Thumbnails
                if (i <= loaded_levels)
                {
                    string current_thumbnail_path = thumbnail_path + "/" + i + "/IMG_1";

                    Sprite current_thumbnail = Resources.Load<Sprite>(current_thumbnail_path);
                    level.level_thumbnail.sprite = current_thumbnail;
                }

                //when no level is solved
                if (current_levels == 0 && i == 1)
                {
                    level.level_lock.enabled = false;
                    level.start_button.enabled = true;
                    level.level_stars.SetActive(false);

                }
                else
                {
                    //checking if the level is open or locked
                    if (i < current_levels)
                    {
                        level.level_lock.enabled = false;
                        level.level_stars.SetActive(true);
                        level.start_button.enabled = false;

                    }
                    else
                    {
                        level.start_button.enabled = false;

                        level.levelButton.enabled = false;
                        //level.levelButton.enabled = true;

                        level.level_lock.enabled = true;
                        level.level_stars.SetActive(false);

                    }
                    if (i == current_levels)
                    {
                        level.levelButton.enabled = true;
                        level.level_lock.enabled = false;
                        level.start_button.enabled = true;
                        level.level_stars.SetActive(false);
                    }
                }
            }
        }
        else
        {
            Debug.Log(numberOfLevels);
        }
        
    }
}
