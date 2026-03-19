// FlightController.cs
// CENG 454 - HW1: Sky-High Prototype
// Author: Mehmet Efe Binicioglu | Student ID: 230446046

using UnityEngine;

public class FlightController : MonoBehaviour
{
    [SerializeField] private float pitchSpeed = 45f;  // degrees/second
    [SerializeField] private float yawSpeed   = 45f;  // degrees/second
    [SerializeField] private float rollSpeed  = 45f;  // degrees/second
    [SerializeField] private float thrustSpeed = 5f;  // units/second

    // TODO (Task 3-A): Declare a private Rigidbody field named 'rb'.
    private Rigidbody rb;

    void Start()
    {
        // TODO (Task 3-B): Cache GetComponent<Rigidbody>() into 'rb'.
        rb = GetComponent<Rigidbody>();
        //Then set rb.freezeRotation = true
        rb.freezeRotation = true;
    }

    void Update()
    {
        HandleRotation();
        HandleThrust();
    }

    private void HandleRotation()
    {
        // TODO (Task 3-C): Get input for pitch and roll.

        // Pitch: W/S Keys or Up/Down Arrow Keys (Vertical Axis).
        float pitchInput = Input.GetAxis("Vertical");
        float pitchAmount = pitchInput * pitchSpeed * Time.deltaTime;

        // Roll: A/D Keys or Left/Right Arrow Keys (Horizontal Axis).
        float rollInput = Input.GetAxis("Horizontal");
        float rollAmount = rollInput * rollSpeed * Time.deltaTime;

        transform.Rotate(Vector3.left*pitchAmount); // Pitch
        transform.Rotate(Vector3.back*rollAmount); // Roll
    }

    private void HandleThrust()
    {
        // TODO (Task 3-D): Get input for thrust.
        // Thrust: Spacebar.
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * thrustSpeed * Time.deltaTime);
        }
    }
}