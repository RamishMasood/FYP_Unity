using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARObjectController : MonoBehaviour
{
    public float zoomSensitivity = 0.1f;
    public float moveSensitivity = 0.1f;

    // Update is called once per frame
    void Update()
    {
        // Zoom in and out using scroll wheel
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        transform.localScale += new Vector3(scroll * zoomSensitivity, scroll * zoomSensitivity, scroll * zoomSensitivity);

        // Move right and left using A and D keys
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontalInput * moveSensitivity, 0, 0);
    }
}
