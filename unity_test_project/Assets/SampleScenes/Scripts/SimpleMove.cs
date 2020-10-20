using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    //Attributs

    public static float GlobalSpeed = 1.0f;
    public float Speed = 1.0f;
    public Vector3 Direction = new Vector3(0, 0, 1);

    [System.Serializable]

    public class Etape
    {
        public Vector3 Position;
        public float TimetoReach;
    }

    public Etape[] Chemin;

    //Méthodes

    public void Start()
    {
        //AvanceCube(10, Vector3.up);
    }

    void Update()
    {
        transform.Rotate(Speed * Time.deltaTime, 0, 0);
    }


    private void AvanceCube(float distance, Vector3 direction)
    {
        this.transform.position = this.transform.position + (direction.normalized * distance);
    }


    private void OnDrawGizmosSelected()
    {
        for (int i = 0; i < Chemin.Length; i++)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawSphere(Chemin[i].Position, 0.3f);
        }
        /*
        Gizmos.color = Color.blue;
        foreach (Etape e in Chemin)
        {
            Gizmos.DrawSphere(e.Position, 0.3f);
        }
        */
    }
}
