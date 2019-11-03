using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitMove : MonoBehaviour
{
    public Transform movingPlanet;
    public Ellipse orbit;
    [Range(0f, 1f)]
    public float orbitProgress;
    public float orbitPeriod;
    public bool orbitActive = true;
    void Start()
    {
        if (movingPlanet == null)
        {
            orbitActive = false;
            return;
        }
        else
        {
            SetPlanetPosition();
        }
        StartCoroutine(AnimateOrbit());

    }

    void SetPlanetPosition()
    {
        Vector2 orbitPos = orbit.Evaluate(orbitProgress);
        movingPlanet.localPosition = new Vector3(orbitPos.x, 0, orbitPos.y);
    }

    IEnumerator AnimateOrbit()
    {
        if (orbitPeriod < 0.1f)
        {
            orbitPeriod = 0.1f;
        }
        float planetSpeed = 1f / orbitPeriod;
        while (orbitActive == true)
        {
            orbitProgress += Time.deltaTime * planetSpeed;
            orbitProgress %= 1f;
            SetPlanetPosition();
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
