using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SwitchCamera : MonoBehaviour
{

    public GameObject[] planets;
    public Camera[] cameras;

    void Start()
    {


    }

    void Update()
    {
        if (Input.GetKey("space"))
        {

            Debug.Log("space key was pressed");
        }
    }
}
