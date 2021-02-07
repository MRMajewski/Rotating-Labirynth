using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocking : MonoBehaviour
{

    public Transform LevelPanel;
    public int allLevelsCount;

    public Button[] levelsButtons;

    public int numberOfActiveButtons ;

    public levelUnlockedData levelUnlockedData;

    [ContextMenu("setActiveButtons")]

    // Start is called before the first frame update
    void Start()

    
    {
        levelUnlockedData = FindObjectOfType<levelUnlockedData>();

        allLevelsCount = LevelPanel.transform.childCount;
        Debug.Log(allLevelsCount);

        levelsButtons = LevelPanel.GetComponentsInChildren<Button>();
        numberOfActiveButtons = levelUnlockedData.unlockedLevels;
        setActiveButtons(numberOfActiveButtons);
            }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void setActiveButtons(int numberOfActiveButtons)
    {
        for (int i = levelsButtons.Length-1; i > numberOfActiveButtons-1; i--)
        {
            levelsButtons[i].gameObject.SetActive(false);
        }
    }
}
