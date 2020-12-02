using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    float acceleration = 0.1f;
    [SerializeField]
    float currentSpeed;
    [SerializeField]
    float maxSpeed = 5f;
    [SerializeField]
    float turnSpeed = 5f;

    IInput input;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<IInput>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if acceleration not currently being pressed
        if(input.GetAcceleration() > -0.1f && input.GetAcceleration() < 0.1f){
            if(currentSpeed > 0.0f){
                currentSpeed = Mathf.Clamp(currentSpeed - (acceleration * Time.deltaTime), 0.0f, maxSpeed);
            }
            else if(currentSpeed < 0.0f){
                currentSpeed = Mathf.Clamp(currentSpeed + (acceleration * Time.deltaTime), -maxSpeed, 0.0f);
            }
        }

        currentSpeed = Mathf.Clamp(currentSpeed + (input.GetAcceleration() * acceleration * Time.deltaTime), -maxSpeed, maxSpeed);

        rb.angularVelocity = currentSpeed * -input.GetHorizontal() * turnSpeed;

        rb.velocity = transform.up * currentSpeed;
    }
}
