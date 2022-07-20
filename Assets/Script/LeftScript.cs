using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftScript : MonoBehaviour
{
    public Rigidbody2D rb;
    SpawnController spawnController;
    public float speedObject = 25;

    void Update()
    {
       SendJavelin();
    }

    public void SendJavelin()
    {
        rb.MovePosition(rb.position + Vector2.down * speedObject * Time.deltaTime);

    }

   

}
