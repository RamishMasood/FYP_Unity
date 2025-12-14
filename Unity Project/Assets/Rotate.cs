using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 1f; // Rotation speed in degrees per second

    private Vector2 touchStart; // Starting position of touch

    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            float rotationX = -Input.GetTouch(0).deltaPosition.y * rotateSpeed * Time.deltaTime; // Rotate around local x-axis
            float rotationZ = -Input.GetTouch(0).deltaPosition.x * rotateSpeed * Time.deltaTime; // Rotate around local z-axis
            transform.Rotate(Vector3.left, rotationX, Space.Self); // Rotate around local x-axis
            transform.Rotate(Vector3.forward, rotationZ, Space.Self); // Rotate around local z-axis
        }
        else if (Input.GetMouseButton(0))
        {
            float rotationX = Input.GetAxis("Mouse Y") * rotateSpeed; // Rotate around local x-axis
            float rotationZ = Input.GetAxis("Mouse X") * rotateSpeed; // Rotate around local z-axis
            transform.Rotate(Vector3.right, rotationX, Space.Self); // Rotate around local x-axis
            transform.Rotate(-Vector3.forward, rotationZ, Space.Self); // Rotate around local z-axis
        }
    }
}