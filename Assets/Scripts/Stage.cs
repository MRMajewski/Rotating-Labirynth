using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    private static Stage instance = null;

    [Header("Level Settings")]
    [SerializeField]
    public LevelSettings[] levelSettings;

    [SerializeField]
    private int levelIndex;

    private void Awake()
    {
            if (instance == null)
                instance = this;
            else
            {
                Destroy(gameObject);
                return;
            }
            DontDestroyOnLoad(this);
    }

    public void SetLevelIndex(int index)
    {
        this.levelIndex = index;
    }

    public void PrepareStage()
    {
        Instantiate(levelSettings[levelIndex].level);
    }
}
