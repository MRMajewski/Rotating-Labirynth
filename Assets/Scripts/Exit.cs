using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{ 
    public GameManager gameManager;
    public UIGameManager uiManager;
    public GameObject door;

    public bool areDoorOpen = false;

    public levelUnlockedData levelUnlockedData;
    public int levelUnlocked;


    private bool isLevelComplete = false;


    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        uiManager = FindObjectOfType<UIGameManager>();
        levelUnlockedData = FindObjectOfType<levelUnlockedData>();
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
            if(!isLevelComplete)
             {
                levelUnlockedData.SetUnlockedLevelsNumber(levelUnlocked);
                isLevelComplete = true;
            }

            
            Debug.Log("levelUnlockedData.unlockedLevels");
            gameManager.ExitLevel();
            uiManager.endGame();
    
        }
         
    }
}
