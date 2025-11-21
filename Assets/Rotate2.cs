using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR;
using UnityEngine;

public class Rotate2 : MonoBehaviour
{
    public float rotateSpeed = 1f; // Rotation speed in degrees per second

    private Vector2 touchStart; // Starting position of touch

    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Single finger drag to rotate the object on Android
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            float rotationX = -touchDeltaPosition.y * rotateSpeed * Time.deltaTime; // Invert y-axis for natural rotation
            float rotationY = touchDeltaPosition.x * rotateSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up, rotationY, Space.World); // Rotate around world y-axis
            transform.Rotate(Vector3.right, rotationX, Space.Self); // Rotate around local x-axis
        }
        else if (Input.GetMouseButton(0))
        {
            // Mouse drag to rotate the object on PC
            float rotationX = -Input.GetAxis("Mouse Y") * rotateSpeed;
            float rotationY = Input.GetAxis("Mouse X") * rotateSpeed;
            transform.Rotate(Vector3.up, rotationY, Space.World); // Rotate around world y-axis
            transform.Rotate(Vector3.right, rotationX, Space.Self); // Rotate around local x-axis
        }
    }
}