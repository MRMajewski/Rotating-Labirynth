using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemsCounter : MonoBehaviour
{
    public TextMeshProUGUI itemsCounter;
    public GameManager gameManager;
    public int checkPointsGot;
    public int checkPointsToFinish;

    // Start is called before the first frame update
    void Start()
    {
        checkPointsToFinish = gameManager.checkPointToFinish;

    }

    // Update is called once per frame
    void Update()
    {
     //   checkPointsGot = gameManager.checkPointsGot;
    //    itemsCounter.text = checkPointsGot.ToString() + "/4";

    }

    public void UpdatePointsUI(int checkPointsGot)
    {
        LeanTween.scaleY(this.gameObject, 0f, 1f).setEasePunch();
        //  checkPointsGot = gameManager.checkPointsGot;
        itemsCounter.text = checkPointsGot.ToString() + "/"+checkPointsToFinish.ToString();

      
     //   LeanTween.scaleY(this.gameObject,1f, 1f).setEasePunch();





    }
}
