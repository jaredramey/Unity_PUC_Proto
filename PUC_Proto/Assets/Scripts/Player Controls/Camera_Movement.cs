using UnityEngine;
using System.Collections;


/*
* CameraMovement script:
* http://bit.ly/22bGQHB
*/

    [System.Serializable]
    public class Boundry
    {
        public float xMin, xMax, zMin, zMax;
    }

public class Camera_Movement : MonoBehaviour
{
    public float speed;
    public float tilt;
    public Boundry boundary;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVerticle = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVerticle);
        
    }

    //Saving this for possible later use
    /*void SmoothLookAt()
    {
        Vector3 relPlayerPosition = player.position - transform.position;

        Quaternion lookAtRoation = Quaternion.LookRotation(relPlayerPosition, Vector3.up);

        transform.rotation = Quaternion.Lerp(transform.rotation, lookAtRoation, smooth * Time.deltaTime);
    }*/

}
