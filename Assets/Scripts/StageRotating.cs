using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageRotating : MonoBehaviour
{

    public float RotatingSpeed = 1f;

    public float RotatingParameter;

    
    public Transform verticalAxisTransform;

    [Header("InvertingParameters")]
    public float animSpeed;
    public float animTime;
    public float cooldownRate = 1f;
    private float coolingDownTime;

    public Rigidbody rigidbody;


    private void Awake()
    {
        RotatingSpeed = 300f;
    }

    private void Start()
    {
       
     //   rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(coolingDownTime>0)
        {
            coolingDownTime -= Time.deltaTime;
        }
        if(coolingDownTime<0)
        {
            coolingDownTime = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space) && coolingDownTime==0)         
        {

            if(verticalAxisTransform.rotation==Quaternion.Euler(0,0,0))
            {
                StartCoroutine(InvertingTest(Quaternion.Euler(180f, 0, 0),animSpeed,animTime));
            }
            else StartCoroutine(InvertingTest(Quaternion.Euler(0f, 0, 0),animSpeed,animTime));

            coolingDownTime = cooldownRate;
        }

        RotatingParameter = Input.GetAxis("Horizontal");

        UpdateRotation(RotatingParameter);


    }

    void UpdateRotationTest(float rotatingParameter)
    {
   //     LeanTween.rotateZ(this.gameObject,
    }

    void UpdateRotation(float tankRotate)
    {
        //    transform.Rotate(Vector3.forward * tankRotate * RotatingSpeed);
        rigidbody.AddTorque(new Vector3(1,1,1) * tankRotate * RotatingSpeed);

        
       // transform.Rotate(Vector3.forward, RotatingParameter);
        
      //  Vector3 newRotation = Quaternion.Euler(0,0,1)
      //  transform.rotation = 
    }


    void InvertingStage()
    {
        var targetPosition = Quaternion.Euler(180, 0, 0);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetPosition, Time.deltaTime*20f);
    }

    IEnumerator InvertingTest(Quaternion newRot,float animSpeed, float animTime)
    {

        //working parameteres : animSpeed =2f , progress<1f
       // var animSpeed = 2f; 

      //  Vector3 pos = transform.position;
        Quaternion rot = verticalAxisTransform.rotation; // inaczej zamień na transform.rotation
      //  Quaternion newRot = Quaternion.Euler(180, 0, 0);


        float progress = 0.0f;  //This value is used for LERP

        while (progress < animTime)
        {
            //    transform.position = Vector3.Lerp(pos, NewCameraPosition.transform.position, progress);
            verticalAxisTransform.rotation = Quaternion.Lerp(rot, newRot, progress);
            yield return new WaitForEndOfFrame();
            progress += Time.deltaTime * animSpeed;
        }

        //Set final transform
        //   transform.position = NewCameraPosition.transform.position;
        verticalAxisTransform.rotation = newRot;
    }
}
