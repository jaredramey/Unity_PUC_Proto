using UnityEngine;
using System.Collections;

public class MoonController : MonoBehaviour
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
    }

    void RotateAroundCenter()
    {
        gameObject.transform.RotateAround(rotationCenter.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
