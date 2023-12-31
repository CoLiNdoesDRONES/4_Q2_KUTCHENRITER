using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_follow : MonoBehaviour
{
    //allows us to target a specific game object to track its transform
    public Transform target;

    //creating a new vector3 to offset the camera from the player position.
    public Vector3 offset = new Vector3(0, 2, -10);
    
    public float smoothTime = 0.25f;

    Vector3 currentVelocity; 
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position + offset, ref currentVelocity, smoothTime);
    }
}
