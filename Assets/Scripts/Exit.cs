using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{ 
    public GameManager gameManager;
    public UIGameManager uiManager;
    public GameObject door;

    public bool areDoorOpen = false;


    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        uiManager = FindObjectOfType<UIGameManager>();
    }

    [ContextMenu("OpenDoor")]
    public void OpenDoor()
    {
        LeanTween.scale(door, Vector3.zero, 2f);
        LeanTween.moveLocalZ(door, 1f, 2f);
        areDoorOpen = true;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (areDoorOpen)
        {
            Debug.Log("Przechodzisz do kolejnego levelu");
            gameManager.ExitLevel();
            uiManager.endGame();
        }
         
    }
}
