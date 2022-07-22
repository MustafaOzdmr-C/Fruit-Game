using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnerSquare : MonoBehaviour
{
    
    [SerializeField] private CreateObj create;
    public AudioSource source;
    public Text SoldierText;
    public int Soldierİnt = 10;
    public GameObject FinishScreen;



    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (gameObject.tag == "Dont Blocked")
        {
            Debug.Log("-");
            PlaySoundDown();
            ScoreDown();
            create.CreateSpawnObj();
            Destroy(collision.collider.gameObject);
            if (Soldierİnt == 0)
            {
                Time.timeScale = 0;
                FinishScreen.SetActive(true);
            }

        }

    }
    public void ScoreDown()
    {
        Soldierİnt--;
        SoldierText.text = Soldierİnt.ToString();
    }
    public void PlaySoundDown()
    {
        source.Play();
    }
    public void Restart()
    {

        SceneManager.LoadScene(0);
    }
}
