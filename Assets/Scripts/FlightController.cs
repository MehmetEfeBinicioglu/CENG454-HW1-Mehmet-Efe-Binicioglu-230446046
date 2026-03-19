using UnityEngine;

public class FlightController : MonoBehaviour
{
    [Header("Flight Settings")]
    public float rotationSpeed = 100f;

void Update()
    {
        float pitchInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.left * pitchInput * rotationSpeed * Time.deltaTime);
    }

}