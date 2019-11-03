using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class EllipseRender : MonoBehaviour
{
    LineRenderer comp;

    [Range(3, 36)]
    public int segments;
    public Ellipse ellipse;
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
            Vector3 position = ellipse.Evaluate((float)i / (float)segments);
            points[i] = new Vector3(position.x, position.y, position.z);

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
