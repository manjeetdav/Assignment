using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraFollow : MonoBehaviour
{
    public Transform target; 
    public float distance = 5.0f;
    public float zoomSpeed = 2.0f;
    public float rotationSpeed = 100.0f;
    public float minDistance = 2.0f;
    public float maxDistance = 10.0f;
    public float smoothTime = 0.3f;

    private Vector3 velocity = Vector3.zero;
    private float currentDistance;

    void Start()
    {
        currentDistance = distance;
        UpdateCameraPosition(true);
    }

    void Update()
    {
        if (Input.GetMouseButton(1)) // Right mouse button
        {
            float horizontal = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float vertical = -Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

            transform.RotateAround(target.position, Vector3.up, horizontal);
            transform.RotateAround(target.position, transform.right, vertical);
        }

        // Zoom in/out
        float scroll = Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentDistance = Mathf.Clamp(currentDistance - scroll, minDistance, maxDistance);

        // Update the camera position
        UpdateCameraPosition();
    }

    void UpdateCameraPosition(bool instant = false)
    {
        Vector3 targetPosition = target.position - transform.forward * currentDistance;

        if (instant)
        {
            transform.position = targetPosition;
        }
        else
        {
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }

        transform.LookAt(target);
    }
}
