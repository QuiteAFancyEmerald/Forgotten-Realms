using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private float xMax;

    [SerializeField]
    private float yMax;

    [SerializeField]
    private float xMin;

    [SerializeField]
    private float yMin;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        //target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        transform.position = new Vector3(Mathf.Clamp(target.transform.position.x, xMin, xMax), Mathf.Clamp(target.transform.position.y, yMin, yMax), transform.position.z);
    }
}