using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 120.0f;

    // initiate public variable the sensivity of speed

    private Rigidbody _rigidbody;

    

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        // user input

        Vector3 move = transform.right * x + transform.forward * z;
        _rigidbody.MovePosition(transform.position + move.normalized * speed * Time.deltaTime);

        // the elementary code for transformation
    }
}
