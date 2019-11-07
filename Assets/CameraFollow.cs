using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform sun;
    public Transform planet;
    void Start()
    {

    }

    void Update()
    {
        transform.LookAt(sun);
        transform.localPosition = new Vector3(transform.localPosition.x, 0.72f, -2f);
        transform.eulerAngles = new Vector3(16f, transform.eulerAngles.y, transform.eulerAngles.z);
    }

}

