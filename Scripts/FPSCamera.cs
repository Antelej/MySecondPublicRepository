using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public Transform playerBody;
    public Transform playerHead;

    //iniate 2 fields for body and head

    private float _xRotation = 0f;
    private float _yRotation = 0f;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        //fixing the center of screen
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        //user input
        
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        _yRotation -= mouseX;
        _yRotation = Mathf.Clamp(_yRotation, -90f, 90f);

        //restrictioin for user input



        playerHead.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX );
        playerHead.Rotate(Vector3.forward * mouseY);

        //use quaternion for rotation of body and head
         
         


    }
}
