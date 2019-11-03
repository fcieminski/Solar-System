using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Ellipse
{
    public float xAxis;
    public float zAxis;
    public Ellipse(float xAxis, float zAxis)
    {
        this.xAxis = xAxis;
        this.zAxis = zAxis;
    }

    public Vector3 Evaluate(float t)
    {
        float angle = Mathf.Deg2Rad * 360f * t;
        float x = Mathf.Cos(angle) * xAxis;
        float z = Mathf.Sin(angle) * zAxis;

        return new Vector3(x, 0f, z);
    }
}
