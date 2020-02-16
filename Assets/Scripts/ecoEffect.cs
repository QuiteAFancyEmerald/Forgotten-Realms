using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ecoEffect : MonoBehaviour
{

    public float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public GameObject echo;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(timeBtwSpawns <= 0)
        {
            // spawn eco game object
            Instantiate(echo, spawnpoint.position, spawnpoint.rotation);
            Destroy(echo, 8f);
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
