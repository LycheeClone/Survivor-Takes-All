using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody rb;
    public Camera playerCamera;

    private Vector3 moveDirection;

    void Update()
    {
        // Get the horizontal and vertical inputs.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the move direction based on the camera's forward vector and the input.
        Vector3 cameraForward = playerCamera.transform.forward;
        Vector3 cameraRight = playerCamera.transform.right;
        cameraForward.y = 0f;
        cameraRight.y = 0f;
        cameraForward.Normalize();
        cameraRight.Normalize();
        moveDirection = cameraForward * verticalInput + cameraRight * horizontalInput;

        // Normalize the move direction and apply it to the rigidbody.
        moveDirection.Normalize();
        rb.velocity = moveDirection * moveSpeed;
    }
}