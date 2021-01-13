using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject GamePanel;
    public GameObject ExitPanel;


    private void Awake()
    {

    }
  
    void Start()
    {

        MenuPanel.SetActive(true);
        GamePanel.SetActive(false);
        ExitPanel.SetActive(false);



    }

    public virtual void StartGame()
    {
        LeanTween.alphaCanvas(MenuPanel.GetComponent<CanvasGroup>(), 0, 1f);

        StartCoroutine(WaitCoroutine(1f));

        GamePanel.SetActive(true);
      
        GamePanel.GetComponent<CanvasGroup>().alpha = 0f;
        LeanTween.alphaCanvas(GamePanel.GetComponent<CanvasGroup>(), 1f, 2f);

    }

    public void endGame()
    {
        // ExitPanel.SetActive(true);
        LeanTween.alphaCanvas(MenuPanel.GetComponent<CanvasGroup>(), 0, 1f);
        StartCoroutine(WaitCoroutineEnd(1f));
        ExitPanel.SetActive(true);
        ExitPanel.GetComponent<CanvasGroup>().alpha = 0f;
        LeanTween.alphaCanvas(ExitPanel.GetComponent<CanvasGroup>(), 1f, 2f);

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    protected IEnumerator WaitCoroutine(float time)
    {

        yield return new WaitForSeconds(time);
        MenuPanel.SetActive(false);
        GamePanel.SetActive(true);


        Debug.Log("done");
   
    }
    protected IEnumerator WaitCoroutineEnd(float time)
    {

        yield return new WaitForSeconds(time);
     
        GamePanel.SetActive(false);
        ExitPanel.SetActive(true);

        Debug.Log("done");

    }

    public void returnToMenu()
    {
        SceneManager.LoadScene(0);
    }

}
