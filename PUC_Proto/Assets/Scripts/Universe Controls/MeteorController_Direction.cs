using UnityEngine;
using System.Collections;

public class MeteorController_Direction : MonoBehaviour
{
    [SerializeField]
    public float speed;
    [SerializeField]
    public float maxX, maxY;

    [SerializeField]
    private bool up = false, down = false, left = false, right = false;

    // Use this for initialization
    void Start()
    {
        GetDirection();
    }

    // Update is called once per frame
    void Update()
    {
        ContinueDirection();

        if (gameObject.transform.position.x > maxX || gameObject.transform.position.x < -maxX)
        {
            Destroy(gameObject);
        }
        if (gameObject.transform.position.y > maxY || gameObject.transform.position.y < -maxY)
        {
            Destroy(gameObject);
        }

        Debug.Log("HOTDOOOOG");
    }

    void GetDirection()
    {
        int direction = 0;

        direction = Random.Range(1, 4);

        switch(direction)
        {
            case 1:
                up = true;
                break;

            case 2:
                down = true;
                break;

            case 3:
                left = true;
                break;

            case 4:
                right = true;
                break;

            default:
                break;
        }
    }

    void ContinueDirection()
    {
        if(up == true)
        {
            
        }
    }
}
