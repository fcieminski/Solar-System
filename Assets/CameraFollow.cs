using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform sun;
    public Transform planet;
    [Range(0, -100)]
    public float distance;
    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(sun);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, -planet.localScale.x * 2);
    }

}

