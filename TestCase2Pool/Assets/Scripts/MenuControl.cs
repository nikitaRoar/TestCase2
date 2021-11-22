using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{

    public GameObject PauseButton;
    public GameObject Menu;
    public bool IfPause = false;

    public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
    }
    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
    private void Update()
    {
        if (IfPause)
        {
            StartPause();
        }
        else if (!IfPause) 
        {
            StartResume();
        }
    }
    public void StartPause()
    {
        PauseButton.SetActive(false);
        Menu.SetActive(true);
        IfPause = true;
        Time.timeScale = 0f;
    }
    public void StartResume()
    {
        PauseButton.SetActive(true);
        Menu.SetActive(false);
        IfPause = false;
        Time.timeScale = 1f;
    }
   
}

