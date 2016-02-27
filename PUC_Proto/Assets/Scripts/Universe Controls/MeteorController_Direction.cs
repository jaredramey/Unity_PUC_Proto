using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]

public class MeteorController_Direction : MonoBehaviour
{
    [SerializeField]
    public float speed;
    [SerializeField]
    public float maxX, maxZ;

    [SerializeField]
    private bool up = false, down = false, left = false, right = false;

    // Use this for initialization
    void Awake()
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
        if (gameObject.transform.position.z > maxZ || gameObject.transform.position.z < -maxZ)
        {
            Destroy(gameObject);
        }
    }

    void GetDirection()
    {
        int direction = 0;

        direction = Random.Range(1, 4);
        

        switch(direction)
        {
            case 1:
                up = true;
                Debug.Log("up");
                break;

            case 2:
                down = true;
                Debug.Log("down");
                break;

            case 3:
                left = true;
                Debug.Log("left");
                break;

            case 4:
                right = true;
                Debug.Log("right");
                break;

            default:
                break;
        }
    }

    void ContinueDirection()
    {
        if(up == true)
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(speed, 0, 0);
        }

        if (down == true)
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(-speed, 0, 0);
        }

        if (left == true)
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, speed);
        }

        if (right == true)
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -speed);
        }

    }
}
