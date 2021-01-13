using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIGameManager : MonoBehaviour
{
    public GameObject GamePanel;
    public GameObject ExitPanel;


    void Start()
    {  
        GamePanel.SetActive(true);
        ExitPanel.SetActive(false);
    }

    public void endGame()
    {
        LeanTween.alphaCanvas(GamePanel.GetComponent<CanvasGroup>(), 0, 1f);
        StartCoroutine(WaitCoroutineEnd(1f));
        ExitPanel.SetActive(true);
        ExitPanel.GetComponent<CanvasGroup>().alpha = 0f;
        LeanTween.alphaCanvas(ExitPanel.GetComponent<CanvasGroup>(), 1f, 2f);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    protected IEnumerator WaitCoroutineEnd(float time)
    {
        yield return new WaitForSeconds(time);

        GamePanel.SetActive(false);
        ExitPanel.SetActive(true);
    }

    public void ReturnToMenu()
    {

        SceneManager.LoadScene(0);
    }
}

