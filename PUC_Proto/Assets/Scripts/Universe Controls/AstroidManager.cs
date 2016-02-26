using UnityEngine;
using System.Collections;

public class AstroidManager : MonoBehaviour
{

    [SerializeField]
    public GameObject astroid;
    [SerializeField]
    private Vector3 spawnPoint = new Vector3();


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
        SpawnMeteor();
    }

    void SpawnMeteor()
    {
        spawnPoint = new Vector3(Random.Range(800, 900), 0, Random.Range(800, 900));
        Instantiate(astroid, spawnPoint, Quaternion.identity);
    }
}
