using UnityEngine;
using System.Collections;

public class Distance : MonoBehaviour
{
    public GameObject earth;
    public GameObject sun;
    public float Distance_;
    void Start()
    {

    }
    void Update()
    {
        Distance_ = Vector3.Distance(earth.transform.position, sun.transform.position);
    }
}