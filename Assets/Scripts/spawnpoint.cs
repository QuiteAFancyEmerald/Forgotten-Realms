using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour {
    internal static Vector3 position;
    internal static Quaternion rotation;
    public GameObject obstacle;

    void start () {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
