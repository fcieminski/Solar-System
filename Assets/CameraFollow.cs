using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject planet;
    public GameObject sun;
    private Vector3 offset;
    public float cameraDistance;
    void Start()
    {
        // offset = transform.position - planet.transform.position;

        // distance = offset.magnitude;
        // planetPrevPos = planet.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = planet.transform.position - planet.transform.forward;
        transform.LookAt(sun.transform.position);
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.75f, transform.position.z);
        transform.eulerAngles = new Vector3(8f, 0, 0);
        Camera.main.fieldOfView = 33.98741f;
    }
}

