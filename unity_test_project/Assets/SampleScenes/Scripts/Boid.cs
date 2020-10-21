using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boid : MonoBehaviour
{
    public float zoneRepulsion = 5;
    public float zoneAlignement = 9;
    public float zoneAttraction = 50;

    public float forceRepulsion = 15;
    public float forceAlignement = 3;
    public float forceAttraction = 20;

    public Vector3 velocity = new Vector3();
    public float maxSpeed = 20;
    public float minSpeed = 12;

    public bool drawGizmos = true;


    // Update is called once per frame
    void Update()
    {

    }

    void OnDrawGizmosSelected()
    {
        if (drawGizmos)
        {
            // Répulsion

            Gizmos.color = new Color(1, 0, 0, 1.0f);
            Gizmos.DrawWireSphere(transform.position, zoneRepulsion);

            // Alignement

            Gizmos.color = new Color(0, 1, 0, 1.0f);
            Gizmos.DrawWireSphere(transform.position, zoneAlignement);

            // Attraction

            Gizmos.color = new Color(0, 0, 1, 1.0f);
            Gizmos.DrawWireSphere(transform.position, zoneAttraction);
        }
    }
}