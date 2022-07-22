using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpawnController : MonoBehaviour
{
    [SerializeField] private CreateObj create;
    public AudioSource source;
    public GameObject cutObjectOne;
    public GameObject cutObjectTwo;
    LeftScript leftMovie;
    public Text scoreText;
    public Text Score;
    public int scoreİnt;
  

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (gameObject.tag == "Blocked")
        {
            Debug.Log("+");
            PlaySound();
            ScoreUp();
            CutObjectControl();
            create.CreateSpawnObj(); 
            Destroy(collision.collider.gameObject);
        }
    }

    public void CutObjectControl()
    {
        
        GameObject go1 = Instantiate(cutObjectOne, transform.position, transform.rotation); //1.Kesilen Parça
        GameObject go2 = Instantiate(cutObjectTwo, transform.position, transform.rotation); //2.Kesilen Parça
        Rigidbody2D rb1 = go1.GetComponent<Rigidbody2D>();
        Rigidbody2D rb2 = go2.GetComponent<Rigidbody2D>();
        rb1.AddForce((Vector2.up + Vector2.left) * 1200 * Time.deltaTime, ForceMode2D.Impulse);  //Impulse : patlama efekt
        rb2.AddForce((Vector2.up + Vector2.right) * 1200 * Time.deltaTime, ForceMode2D.Impulse); //Impulse : patlama efekt
    }

    public void ScoreUp()
    {
        scoreİnt++;
        scoreText.text = scoreİnt.ToString();
    }

    public void PlaySound()
    {
        source.Play();
    }
}



