using UnityEngine;
using System.Collections;

public class PlanetController : MonoBehaviour
{
    [SerializeField]
    public float rotationSpeed;
    [SerializeField]
    public Transform rotationCenter;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        RotateAroundCenter();
        PlanetRotation();
    }

    void RotateAroundCenter()
    {
        gameObject.transform.RotateAround(rotationCenter.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void PlanetRotation()
    {
        gameObject.transform.RotateAround(gameObject.transform.position, Vector3.left, (rotationSpeed * 4) * Time.deltaTime);
    }
}
