using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SwitchCamera : MonoBehaviour
{

    public GameObject[] planets;
    public Camera[] cameras;
    int current = 0;


    void Start()
    {


    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (current == cameras.Length - 1)
            {
                current = 0;
            }
            else
            {
                current++;
            }
            foreach (Camera camera in cameras)
            {
                camera.enabled = false;
                if (!cameras[current].enabled)
                {
                    cameras[current].enabled = true;
                }

            }
        }
    }

}
