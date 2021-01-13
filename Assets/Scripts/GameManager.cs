using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int checkPointsGot;
    public int checkPointToFinish;
    public GameObject player;
    public UIGameManager uiManager;
    public Stage stage;
    public GameObject levelStage;


    public Exit exit;

    public int levelIndex;

    [Header("Level Settings")]
    public LevelSettings[] levelSettings;


    private void Awake()
    {
        stage = FindObjectOfType<Stage>();
      

    }

    // Start is called before the first frame update
    void Start()
    {
        stage.gameObject.SetActive(true);
        stage.PrepareStage();
        exit = FindObjectOfType<Exit>();
        levelStage = GameObject.FindGameObjectWithTag("STAGE");

        checkPointsGot = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(checkPointsGot==checkPointToFinish)
        {
            finishGame();
        }
    }

    private void finishGame()
    {
        exit.OpenDoor();



    }

    public void ExitLevel()
    {
        LeanTween.scale(player, Vector3.zero, 1f);
        LeanTween.rotateAround(player, Vector3.up, 360f, 1f);
        Destroy(levelStage, 2f);
    }

    public void PrepareGame(int levelIndex)
    {
        Instantiate(levelSettings[levelIndex].level);
    }

}
