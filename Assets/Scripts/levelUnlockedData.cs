using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelUnlockedData : MonoBehaviour
{

    public  int unlockedLevels=1;
    // Start is called before the first frame update

    public void SetUnlockedLevelsNumber(int levelUnlocked)
    {
        unlockedLevels = levelUnlocked;
    }

}
