using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangedcombat : MonoBehaviour
{

    public float offset;
    private float timeBtwShots;
    public float startTimeBtwShots;
    public float rangeMultiplier = 5.0f;

    public GameObject projectile;
    public Transform shotPoint;
    public Transform spawnpoint;
    private LineRenderer shotIndicator;
    public Transform target;
    public Transform turn;

    public AudioSource shootSound;

    // Start is called before the first frame update
    void Start()
    {
        shotIndicator = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target, Vector3.left);

        //Vector3 differnce = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //shotIndicator.SetPositions(new Vector3[] { transform.position, new Vector3(transform.position.x + differnce.normalized.x * rangeMultiplier, transform.position.y + differnce.normalized.y * rangeMultiplier, 0) });
        //float rotZ = Mathf.Atan2(differnce.y, differnce.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0)
        {
            if (Input.GetButtonDown("Fire3"))
            {
                Instantiate(projectile, spawnpoint.position, spawnpoint.rotation);
                timeBtwShots = startTimeBtwShots;

                shootSound.Play();
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
