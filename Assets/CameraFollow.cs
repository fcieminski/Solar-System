﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform sun;
    [Range(0, -100)]
    public float distance;
    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(sun);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, distance);
    }

}
