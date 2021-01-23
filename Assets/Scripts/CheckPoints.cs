using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{

    public GameManager gameManager;

    private bool IsChecked = false;
    // Start is called before the first frame update


    public delegate void ValueChanged();
    public static event ValueChanged OnValueChanged;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (IsChecked) return;
        

        IsChecked = true;
        gameManager.UpdatePoints(1);
        
            
            Debug.Log("Działa");

        LeanTween.scale(gameObject, Vector3.zero, 1f);
        //  LeanTween.rotateY(this.gameObject, 360f, 1f);
        LeanTween.rotateAround(gameObject, Vector3.up, 360f, 1f);
        Destroy(this.gameObject,2f);


    }



}
