using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObj : MonoBehaviour

{
    public GameObject spawnOBJ; 
    float x;
    float y;
    Vector2 pos;
    private void Start() 
    {

    }

    public void CreateSpawnObj()
    {      
            x = Random.Range(-9.23f, 9.14f);
            y = Random.Range(10.04f, 10.06f);

            pos = new Vector2(x, y);

            Instantiate(spawnOBJ, pos, Quaternion.identity);
    }

   
}
