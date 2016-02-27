using UnityEngine;
using System.Collections;

public class AstroidManager : MonoBehaviour
{
    [SerializeField]
    public float astroidTimer = 0;
    [SerializeField]
    public GameObject astroid;
    [SerializeField]
    private Vector3 spawnPoint = new Vector3();


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnMeteor", astroidTimer, astroidTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnMeteor()
    {
        float randX = Random.Range(-900, 900);
        float randZ = Random.Range(-900, 900);

        while((randX > -800 && randX < 800) && (randZ > -800 && randZ < 800) )
        {
            randX = Random.Range(-900, 900);
            randZ = Random.Range(-900, 900);
        }

        Debug.Log(randX + "   " + randZ);

        spawnPoint = new Vector3(randX, 0, randZ);
        Instantiate(astroid, spawnPoint, Quaternion.identity);
    }
}
