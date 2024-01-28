

//sets up player data after retieving data from playerprefs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setup_player : MonoBehaviour
{
    public GameObject loader;
    public Animation animationComponent;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerDataController.DoesPlayerDataExist())
        {
            PlayerDataController.CreatePlayerData(0,0);

            Player.player_level = 0;
            Player.player_score = 0;

        }
        else
        {
            Player.player_level = PlayerDataController.GetLevel();
            Player.player_score = PlayerDataController.GetHighScore();

        }


        animationComponent = loader.GetComponent<Animation>();
        animationComponent.Play("loading_anim");

        // Start a coroutine to check when the animation is complete
        StartCoroutine(CheckAnimationCompletion("loading_anim"));
    }


    IEnumerator CheckAnimationCompletion(string clipName)
    {
        // Wait until the animation is not playing
        while (animationComponent.IsPlaying(clipName))
        {
            yield return null;
        }

        // The animation has completed
        Debug.Log("Animation complete!");

        ScenesManager.instance.LoadMainMenu();
    }
    // Update is called once per frame
}
