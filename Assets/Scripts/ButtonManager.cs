using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is quitting");
    }
    public void GoToStartScreen()
    {
        SceneManager.LoadScene("StartScene");
    }
    
    public void GoToLvl1()
    {
        SceneManager.LoadScene("Lvl1");
    }

    public void GoToTips()
    {
               SceneManager.LoadScene("Tips");
    }
    public void GoToCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void GoToWinScene()
    {
               SceneManager.LoadScene("WinScene");
    }

}
