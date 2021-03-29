using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpp : MonoBehaviour
{
    private CharacterController control;
    private float verticalVel;
    private float gravity;
    private float jumpforce = 10.0f;
    void Start()
    {
        control = GetComponent<CharacterController>();
        
    }

 
    void Update()
    {
        if (control.isGrounded)
        {
            verticalVel -= gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVel = jumpforce;
            }
           
        }
        else
        {
            verticalVel -= gravity * Time.deltaTime;

        }
        Vector3 vect = Vector3.zero;
        vect.x = Input.GetAxis("Horizontal") * 10.0f;
        vect.y = verticalVel;
        vect.z = Input.GetAxis("Vertical") * 10.0f;
        control.Move(vect * Time.deltaTime);
            }
}
