using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerMainMenu : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject LevelSelectPanel;

    private void Awake()
    {
        MainMenuPanel.SetActive(true);
        LevelSelectPanel.SetActive(false);
    }

    public void StartLevelSelectMenu()
    {
        var seq = LeanTween.sequence();

        LeanTween.scale(MainMenuPanel, Vector3.zero, 2f).setEaseInOutCirc();
        LeanTween.alphaCanvas(MainMenuPanel.GetComponent<CanvasGroup>(), 0, 2f).setEaseInOutCirc();
        StartCoroutine(WaitCoroutine(2.5f));
     







    }

    public void Dupa()
    {
        Debug.Log("Coś");
    }


    public void ExitGame()
    {
        Application.Quit();
    }

    public IEnumerator WaitCoroutine(float time)
    {

        yield return new WaitForSeconds(time);
        MainMenuPanel.SetActive(false);
        LevelSelectPanel.SetActive(true);
        LeanTween.scale(LevelSelectPanel, Vector3.zero, 0f).setEaseInOutCirc();
        LeanTween.scale(LevelSelectPanel, new Vector3(1, 1, 1), 1f).setEaseInOutCirc();

    }
}
