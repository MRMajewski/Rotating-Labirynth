using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovementBoundaries : MonoBehaviour
{

    public float force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //spherePos = transform.position;

        //spherePos.x = Mathf.Clamp(spherePos.x, minValue, maxValue);
        //spherePos.y = Mathf.Clamp(spherePos.y, minValue, maxValue);

        //transform.position = spherePos;

    }

    private void OnTriggerExit(Collider other)
    {
        Vector3 dir = Vector3.zero- other.transform.position;


        Debug.Log("Trigger działa");

        Rigidbody rg = other.GetComponent<Rigidbody>();
        rg.AddForce(dir * force);
    }
}
