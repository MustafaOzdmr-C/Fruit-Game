using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private CreateObj create;
    public AudioSource source;
    public GameObject cutObjectOne;
    LeftScript leftMovie;
    public Text scoreText;
    public Text Score;
    public int scoreİnt;
   

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (gameObject.tag == "Blocked")
        {
            Debug.Log("+");
            source.Play();
            scoreİnt++;
            scoreText.text = scoreİnt.ToString();
            Instantiate(cutObjectOne, transform.position, transform.rotation);
            create.CreateSpawnObj();
            Score.text = scoreİnt.ToString();
            Destroy(collision.collider.gameObject);

        }
    }

    
}



