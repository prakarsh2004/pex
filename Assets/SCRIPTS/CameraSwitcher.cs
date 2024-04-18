using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;
    public Camera secondaryCamera;

    private void Start()
    {
        // Ensure main camera is enabled and secondary camera is disabled at the start
        mainCamera.enabled = true;
        secondaryCamera.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider is the cube
        if (other.CompareTag("Cube"))
        {
            // Switch between cameras
            mainCamera.enabled = !mainCamera.enabled;
            secondaryCamera.enabled = !secondaryCamera.enabled;
        }
    }
}
