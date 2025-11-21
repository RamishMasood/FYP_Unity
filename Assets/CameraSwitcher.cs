using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public List<Camera> cameras;
    private int currentCameraIndex = 0;

    void Start()
    {
        // Ensure the initial camera is active, and the others are inactive
        for (int i = 0; i < cameras.Count; i++)
        {
            cameras[i].gameObject.SetActive(i == 0);
        }
    }

    public void SwitchCamera(int direction)
    {
        // Disable the current camera
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // Calculate the new camera index
        currentCameraIndex += direction;

        // Wrap around the camera index
        if (currentCameraIndex < 0)
        {
            currentCameraIndex = cameras.Count - 1;
        }
        else if (currentCameraIndex >= cameras.Count)
        {
            currentCameraIndex = 0;
        }

        // Enable the new camera
        cameras[currentCameraIndex].gameObject.SetActive(true);
    }

    public void SwitchToNextCamera()
    {
        SwitchCamera(1);
    }

    public void SwitchToPreviousCamera()
    {
        SwitchCamera(-1);
    }
}