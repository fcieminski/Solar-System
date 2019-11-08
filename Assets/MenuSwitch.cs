using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwitch : MonoBehaviour
{
    public Transform panel;

    public void switchMenu()
    {
        float value = 0;
        value = panel.position.x < 0 ? Mathf.Abs(panel.position.x) : -panel.position.x;

        transform.position = new Vector3(value, panel.position.y, panel.position.z);

    }
}
