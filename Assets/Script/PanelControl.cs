using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelControl : MonoBehaviour
{
    public GameObject settingPanel;
    public GameObject gamePanel;
    public GameObject menuPanel;
 
    [SerializeField] private CreateObj createOBJ;
    
    public void Start()
    {
     
    }

    public void GameOpen()
    {
        gamePanel.SetActive(true);
        menuPanel.SetActive(false);

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



}
