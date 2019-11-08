using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwitch : MonoBehaviour
{
    public Transform panel;
    private Vector3 newPos;
    float value = 0;
    float speed = 10;

    void Start()
    {
        newPos = new Vector3(panel.position.x, panel.position.y, panel.position.z);
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * speed);
    }
    public void switchMenu()
    {
        value = panel.position.x < 0 ? Mathf.Abs(panel.position.x) : -panel.position.x;
        newPos = new Vector3(value, panel.position.y, panel.position.z);
    }
}
