using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{

    public GameManager gameManager;
    // Start is called before the first frame update

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
            gameManager.checkPointsGot++;
            Debug.Log("Działa");

        LeanTween.scale(gameObject, Vector3.zero, 1f);
        //  LeanTween.rotateY(this.gameObject, 360f, 1f);
        LeanTween.rotateAround(gameObject, Vector3.up, 360f, 1f);
            Destroy(this.gameObject,1f);


    }



}
