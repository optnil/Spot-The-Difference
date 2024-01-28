using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderGenerator : MonoBehaviour
{
    public GameObject colliderPrefab; // Reference to a prefab with a collider component.
    public Transform parentTransform; // Optional parent transform for organization.



    void Start()
    {
        /* if (colliderRadii.Length != colliderPositions.Length)
         {
             Debug.LogError("The colliderRadii and colliderPositions arrays must have the same length.");
             return;
         }*/
        int level = Mainmenu.text;
        if (level > 0) 
        {
            AccessLevelData accessLevelData = new AccessLevelData();
            ColliderInfo[] colliders = accessLevelData.getColliderDetails(level);


            int i = 0;

            foreach (var colliderInfo in colliders)
            {
                Debug.Log("Level 1 Collider Position: " + colliderInfo.position);
                Debug.Log("Level 1 Collider Radius: " + colliderInfo.radius);

                float radius = colliderInfo.radius;
                Vector2 position = colliderInfo.position;

                // Instantiate a collider object.
                GameObject colliderObject = Instantiate(colliderPrefab, position, Quaternion.identity);

                // Optionally, set the parent transform for organization.
                if (parentTransform != null)
                {

                    colliderObject.transform.SetParent(parentTransform, false);
                    colliderObject.name = "Collider" + (i + 1);
                }

                // Modify the collider's size.
                ModifyColliderSize(colliderObject, radius);
                RectTransform differenceCircle = colliderObject.transform.GetChild(0).GetComponent<RectTransform>();
                differenceCircle.sizeDelta = new Vector2(radius*2, radius*2);

                i++;
            }
        }
        else
        {
            Debug.Log("Wrong Level");
        }
        
    }

    void ModifyColliderSize(GameObject colliderObject, float radius)
    {
        // Get the CircleCollider2D component.
        CircleCollider2D circleCollider = colliderObject.GetComponent<CircleCollider2D>();

        // Ensure that the object has a CircleCollider2D component.
        if (circleCollider != null)
        {
            // Set the radius of the circle collider.
            circleCollider.radius = radius;
        }
    }
}
