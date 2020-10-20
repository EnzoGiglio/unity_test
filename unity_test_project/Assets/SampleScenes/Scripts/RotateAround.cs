using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Target;
    public float Speed;  
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Target.position, Vector3.up, 20 * Time.deltaTime);
        
    }
}
