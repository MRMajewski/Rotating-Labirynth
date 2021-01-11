using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemsCounter : MonoBehaviour
{
    public TextMeshProUGUI itemsCounter;
    public GameManager gameManager;
    public int checkPointsGot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        checkPointsGot = gameManager.checkPointsGot;
        itemsCounter.text = checkPointsGot.ToString() + "/4";
    }
}
