
//checks if colliders are hit on tap and animates the circle images

using System.Collections;
using System.Diagnostics.Tracing;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.UI;

public class FindDifference : MonoBehaviour
{
    // Add any necessary variables here.
    Image radialImage;
    Image radialImage2;

    string parentImage;

    string Image2Name;

    public GameObject Image1;
    public GameObject Image2;

    public Button CheckClick;

    public ScoringManager scoringManager;
    public Pause_Popup_Manager popup;

    private RaycastHit2D hit;

    private int counter;


     void Start()
    {
        counter = 0;
        CheckClick.onClick.AddListener(checkClick);
    }

    void checkClick()
    {
        if (!Mainmenu.game_pause)
        {
            checkLifeLoss();
        }
       
    }


    void Update()
    {
        
        if (!Mainmenu.game_pause) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                // Perform raycasting to detect if the mouse click hit a difference object.
                hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

                if (hit.collider != null)
                {
                    string collidername = hit.collider.gameObject.name;
                    Debug.Log("collider name is "+collidername);
                  
                        // Handle the click on a difference.
                        HandleDifferenceClick(hit.collider.gameObject);
                    
                    
                }
                else
                {
                    
                    Debug.Log("nO cOLLIDER HIT");
                   // checkLifeLoss();
                    //scoringManager.LoseLife();

                }
            }
        }
        
    }

    void checkLifeLoss()
    {
        if (hit.collider == null)
        {
            scoringManager.LoseLife();
        }
    }
    void HandleDifferenceClick(GameObject differenceObject)
    {

        Debug.Log("Difference Hit");

        

        Image2Name = "Image_2";
        parentImage = differenceObject.transform.parent.name;

        if(parentImage == "Image_2")
        {
            Image2Name = "Image_1";
        }

        radialImage = differenceObject.transform.GetChild(0).GetComponent<Image>();

        if(radialImage.fillAmount == 0)
        {
            scoringManager.DifferenceFound();

            GameObject Image2 = GameObject.Find(Image2Name);
            if (Image2 != null)
            {
                Transform differenceObject2 = Image2.transform.Find(differenceObject.name);
                if (differenceObject2 != null)
                {
                    Debug.Log("second difference found " + Image2.name);
                    radialImage2 = differenceObject2.transform.GetChild(0).GetComponent<Image>();
                    StartCoroutine(AnimateRadialFill(radialImage2));
                }
                else
                {
                    Debug.Log("Second Difference Collider Not found");
                }
            }
            else
            {
                Debug.Log("Second Image Not found");
            }

            StartCoroutine(AnimateRadialFill(radialImage));
        }
        else
        {
            Debug.Log("Difference Already found");
        }
        
    }
    private IEnumerator AnimateRadialFill(Image imageToFIll)
    {
        float elapsedTime = 0f;
        float fillDuration = 0.5f;

        float targetFill = 1.0f;
        float initialFill = 0.0f;

        while (elapsedTime < fillDuration)
        {
            float fillAmount = Mathf.Lerp(initialFill, targetFill, elapsedTime / fillDuration);
            imageToFIll.fillAmount = fillAmount;
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the final fill is exactly the target fill
        imageToFIll.fillAmount = targetFill;
    }


}
