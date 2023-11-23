using UnityEngine;

public class FollowCameraX : MonoBehaviour
{
    // The camera that we will be following
    private Camera camera;

    // This function is called when the game starts or when the object is enabled
    void Start()
    {
        // Get the camera
        camera = Camera.main;
    }

    // This function is called every frame
    void Update()
    {
        // Get the camera's rotation
        Quaternion cameraRotation = camera.transform.rotation;

        // Set the plane's rotation to match the camera's X-axis rotation
        transform.rotation = Quaternion.Euler(0, cameraRotation.x , 0);
    }
}