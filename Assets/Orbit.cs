using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float time;
    public float speed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform target = transform.parent;

        if (target != null)
        {
            transform.RotateAround(target.position, Vector3.up, speed * Time.deltaTime);
        }
    }
}
