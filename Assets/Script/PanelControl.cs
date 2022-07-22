using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelControl : MonoBehaviour
{
    public GameObject settingPanel;
    public GameObject gamePanel;
    public GameObject menuPanel;
    public GameObject pausePanel;
    public Text katText;
    public Text anaText;
    public string katStr;
    public string anaStr;

    [SerializeField] private CreateObj createOBJ;
    
    public void Start()
    {
     
    }

    public void GameOpen()
    {
        gamePanel.SetActive(true);
        menuPanel.SetActive(false);

        katText.enabled = false;
        anaText.enabled = false;


        createOBJ.CreateSpawnObj();
    }

    public void SettingsOpen()
    {
        settingPanel.SetActive(true);
    }
    public void SettinsClose()
    {
        settingPanel.SetActive(false);
    }

    public void pause()
    {
        pausePanel.SetActive(true);
    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Ready()
    {
        pausePanel.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        GameOpen();


    }

}
