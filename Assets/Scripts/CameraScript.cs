using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;
    public Rigidbody sphere;
    public new Camera camera;

    public float smoothSpeed = 5f;
    public float smoothSpeedFieldOfView = 5;

    // Update is called once per frame
  //  void LateUpdate()
  void Update()
    {

        UpdatePosition();
     //   UpdateFieldOfView();

    }

    private void UpdatePosition()
    {
        Vector3 targetPosition = target.position + offset;
        // Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime* smoothSpeed);

        // transform.position = smoothPosition;
        //   }
        // transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothSpeed);
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smoothSpeed);
        // transform.position = targetPosition;
    }

    private void UpdateFieldOfView()
    {
        var speed = sphere.velocity.magnitude;


        var targetViewSize = 80 + (speed * 12f);

        camera.fieldOfView = Mathf.Lerp(
            80,
            targetViewSize, Time.deltaTime*
            smoothSpeedFieldOfView);

    }
}

