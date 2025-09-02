using UnityEngine;
using TMPro;
using System.Collections;

public class TouchPhase : MonoBehaviour
{
    public Vector2 startPos;
    public Vector2 direction;

    public TextMeshProUGUI textMeshPro;
    public string message; 

    void Update()
    {
        textMeshPro.text = "Touch: " + message + " in direction " + direction;

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case UnityEngine.TouchPhase.Began:
                    startPos = touch.position;
                    message = "Began";
                    break;
                case UnityEngine.TouchPhase.Moved:
                    direction = touch.position - startPos;
                    message = "Moving";
                    break;
                case UnityEngine.TouchPhase.Ended:
                    message = "Ending";
                    break;
                case UnityEngine.TouchPhase.Stationary:
                    Debug.Log("Touch Stationary at: " + touch.position);
                    //message = "Stationary";
                    break;
                case UnityEngine.TouchPhase.Canceled:
                    message = "Canceled";
                    break;
            }
        }


    }
}
