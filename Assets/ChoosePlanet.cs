using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePlanet : MonoBehaviour
{
    public Camera camera;
    public GameObject planet;
    public void GoToPlanet()
    {
        if (Camera.main)
        {
            Camera.main.enabled = false;
        }
        // current = Camera.current;
        camera.enabled = true;
    }
}
