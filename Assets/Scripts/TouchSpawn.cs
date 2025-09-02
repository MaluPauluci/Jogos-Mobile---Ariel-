using UnityEngine;

public class TouchSpawn : MonoBehaviour
{
    public GameObject[] objects;
    private int index = 0; 

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == UnityEngine.TouchPhase.Began)
            {
                Vector2 position = Camera.main.ScreenToWorldPoint(touch.position);

                Collider2D hit = Physics2D.OverlapPoint(position);

                if (hit != null)
                {
                    Destroy(hit.gameObject);
                }

                Instantiate(objects[index], position, Quaternion.identity);

                index = (index + 1) % objects.Length;
            }
        }
    }
}
