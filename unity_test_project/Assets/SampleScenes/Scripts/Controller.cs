﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Animator maincharacterAnimator;

    float axisH, axisV;

    [SerializeField]
    float walkSpeed = 2f, runSpeed = 8f, rotSpeed = 150f, jumpForce = 350;
    Rigidbody rb;


    private void Awake()
    {
        maincharacterAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    } 



    void Update()
    {
        axisH = Input.GetAxis("Horizontal");
        axisV = Input.GetAxis("Vertical");

        if(axisV>0)
        {
            if (Input.GetKey(KeyCode.Keypad1))
            {
                transform.Translate(Vector3.forward * runSpeed * axisV * Time.deltaTime);
                maincharacterAnimator.SetFloat("run", axisV);
            }
            else
            {
                transform.Translate(Vector3.forward * walkSpeed * axisV * Time.deltaTime);
                maincharacterAnimator.SetBool("walk", true);
                maincharacterAnimator.SetFloat("run", 0);
            }
        }
        else
        {
            maincharacterAnimator.SetBool("walk", false);
        }

        if(axisV !=0)
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime * axisH);
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
            maincharacterAnimator.SetTrigger("jump");
        }
    }
}
