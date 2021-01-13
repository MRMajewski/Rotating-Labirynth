using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChoose : MonoBehaviour
{


    public Stage stage;

    private void Awake()
    {
        stage = FindObjectOfType<Stage>();
    }

    public void StartLevel(int levelIndex)
    {
        stage.SetLevelIndex(levelIndex);
        SceneManager.LoadScene(1);
    }
}
