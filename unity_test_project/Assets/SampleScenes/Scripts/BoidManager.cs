using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;


public class BoidManager : MonoBehaviour
{
    private static BoidManager instance = null;
    public static BoidManager sharedInstance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<BoidManager>();
            }
            return instance;
        }
    }


    public Boid prefabBoid;
    public float nbBoids = 30;
    public float startSpeed = 1;
    public float startSpread = 10;

    private List<Boid> boids = new List<Boid>();

    void Start()
    {
        for (int i = 0; i < nbBoids; i++)
        {
            Boid b = GameObject.Instantiate<Boid>(prefabBoid);
            Vector3 positionBoid = Random.insideUnitSphere * startSpread;
            positionBoid.y = Mathf.Abs(positionBoid.y); //Ne pas créer des oiseaux sous 0, on imagine que ce sera le sol.
            b.transform.position = positionBoid;
            b.velocity = (positionBoid - transform.position).normalized * startSpeed;
            b.transform.parent = this.transform;
            boids.Add(b);
        }
    }
}