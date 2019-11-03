using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Elipse : MonoBehaviour
{
    LineRenderer comp;

    [Range(3, 36)]
    public int segments;
    public float xAxis;
    public float yAxis;

    void Awake()
    {
        comp = GetComponent<LineRenderer>();
        CalculateElipses();
    }

    void CalculateElipses()
    {
        Vector3[] points = new Vector3[segments + 1];
        for (int i = 0; i < segments; i++)
        {
            float angle = ((float)i / (float)segments) * 360 * Mathf.Deg2Rad;
            float x = Mathf.Sin(angle) * xAxis;
            float y = Mathf.Cos(angle) * yAxis;
            points[i] = new Vector3(x, y, 0f);

        }
        points[segments] = points[0];
        comp.positionCount = segments + 1;
        comp.SetPositions(points);
    }
    void OnValidate()
    {
        CalculateElipses();
    }

}
