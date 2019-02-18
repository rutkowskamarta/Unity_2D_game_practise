using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {

    [SerializeField] private GameObject target;
    [SerializeField] private float smoothSpeed = 0.1f;
    [SerializeField] private Vector3 offset;

    [SerializeField] private Transform LeftLowerBound;
    [SerializeField] private Transform RightUpperBound;

    private float cameraWidth;
    private float cameraHeight;

    private void Start()
    {
        SetCameraProperties();        
    }

    private void SetCameraProperties()
    {
        cameraHeight = 2 * Camera.main.orthographicSize;
        cameraWidth = cameraHeight * Camera.main.aspect;
    }

    void FixedUpdate ()
    {
        SmoothCameraMovement();
	}

    private void SmoothCameraMovement()
    { 


        Vector3 desiredPosition = target.transform.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        transform.position = new Vector3(Mathf.Clamp(smoothPosition.x, LeftLowerBound.position.x+cameraWidth/2, RightUpperBound.position.x -cameraWidth/2),
            Mathf.Clamp(smoothPosition.y, LeftLowerBound.position.y + cameraHeight/2, RightUpperBound.position.y - cameraHeight/2), smoothPosition.z);
        
    }
}
