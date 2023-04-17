using UnityEngine;

public class FPSCameraController : MonoBehaviour
{
    public Transform target;
    public float distance = 2.5f;
    public float height = 1.5f;
    public float rotationSpeed = 100f;
    public float minVerticalAngle = -90f;
    public float maxVerticalAngle = 90f;

    private float currentRotation = 0f;
    private float currentVerticalAngle = 0f;

    void LateUpdate()
    {
        // Calculate the desired camera position based on the player's position and rotation.
        Vector3 targetPosition = target.position - transform.forward * distance + Vector3.up * height;
        Quaternion targetRotation = Quaternion.Euler(currentVerticalAngle, currentRotation, 0f);

        // Smoothly move the camera towards the desired position and rotation.
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * rotationSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);

        // Update the current rotation based on the player's horizontal input.
        currentRotation += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;

        // Update the current vertical angle based on the player's vertical input.
        currentVerticalAngle -= Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        currentVerticalAngle = Mathf.Clamp(currentVerticalAngle, minVerticalAngle, maxVerticalAngle);
    }
}