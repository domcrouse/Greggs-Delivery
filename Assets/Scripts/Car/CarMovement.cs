using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    float acceleration = 0.1f;
    [SerializeField]
    float currentSpeed;
    [SerializeField]
    float maxSpeed = 5f;
    float MaxSpeed {get{
        return maxSpeed * terrain.SpeedMultiplier();
    }}
    [SerializeField]
    float turnSpeed = 5f;

    IInput input;
    CarTerrain terrain;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<IInput>();
        terrain = (CarTerrain)gameObject.AddComponent<CarTerrain>();
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // Check if acceleration not currently being pressed
        if(input.GetAcceleration() > -0.1f && input.GetAcceleration() < 0.1f){
            if(currentSpeed > 0.0f){
                currentSpeed = Mathf.Clamp(currentSpeed - (acceleration * Time.deltaTime), 0.0f, MaxSpeed);
            }
            else if(currentSpeed < 0.0f){
                currentSpeed = Mathf.Clamp(currentSpeed + (acceleration * Time.deltaTime), -MaxSpeed, 0.0f);
            }
        }

        currentSpeed = Mathf.Clamp(currentSpeed + (input.GetAcceleration() * acceleration * Time.deltaTime), -MaxSpeed, MaxSpeed);

        rb.angularVelocity = currentSpeed * -input.GetHorizontal() * turnSpeed;

        rb.velocity = transform.up * currentSpeed;
    }
}
