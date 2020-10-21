using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    //Enonciation des variables

    public Transform target;
    public float vitesse = 1.0f;
    private Vector3 randomTargetPos;
    public float randomTargetDistMin = 2;
    public float randomTargetDistMax = 10;
    public bool useRandomTarget = false;

    //Setup avant 1ière frame

    void Start()
    {
        SetRandomTargetPos();
        
    }

    void SetRandomTargetPos()
    {
        randomTargetPos = Random.onUnitSphere;
        randomTargetPos.y = 0;
        randomTargetPos = randomTargetPos.normalized * Random.Range(randomTargetDistMin, randomTargetDistMax);
    }

    //Update 1 fois / frame

    void Update()
    {
        //Mise a jout du comportement

        if (target == null)
            useRandomTarget = true;

        //Calcul du point de destination

        Vector3 targetPos;
        if (useRandomTarget || target == null)
            targetPos = randomTargetPos;
        else
            targetPos = target.position;

        //Deplacement

        Vector3 deplacement = target.position - transform.position;
        deplacement = deplacement.normalized * vitesse * Time.deltaTime;
        transform.position += deplacement;
    }
}
