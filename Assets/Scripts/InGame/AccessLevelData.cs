
// Gets collider data for any level


using UnityEngine;

public class AccessLevelData
{
     LevelDataScript levelDataScript = new LevelDataScript();

 /*   void Start()
    {
        if (levelDataScript != null)
        {
            // Access data for Level 1
            LevelData level1Data = levelDataScript.levels[0];
            Debug.Log("Level 1 Name: " + level1Data.levelName);

            // Access data for Level 2
            LevelData level2Data = levelDataScript.levels[1];
            Debug.Log("Level 2 Name: " + level2Data.levelName);

            // Access collider data for Level 1
            foreach (var colliderInfo in level1Data.colliders)
            {
                Debug.Log("Level 1 Collider Position: " + colliderInfo.position);
                Debug.Log("Level 1 Collider Radius: " + colliderInfo.radius);
            }

            // Access collider data for Level 2
            foreach (var colliderInfo in level2Data.colliders)
            {
                Debug.Log("Level 2 Collider Position: " + colliderInfo.position);
                Debug.Log("Level 2 Collider Radius: " + colliderInfo.radius);
            }
        }
        else
        {
            Debug.LogError("LevelDataScript is not assigned.");
        }
    }*/

    public ColliderInfo[] getColliderDetails(int level) 
    {
        Level level1Data = levelDataScript.levels[level - 1];
        Debug.Log("Level 1 Name: " + level1Data.levelName);

        return level1Data.colliders;
    }
}

