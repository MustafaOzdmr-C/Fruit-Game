using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObj : MonoBehaviour

{
    public List<GameObject> gameFruitSprite = new List<GameObject>();
    public GameObject spawnOBJ;
    public float fruitCount = 2;
    float x;
    float y;
    Vector2 pos;
    private void Start()
    {
        CreateSpawnObj();
    }

    public void CreateSpawnObj()
    {
     
        
            x = Random.Range(-9.77f, 9.87f);
            y = Random.Range(6.20339f, 6.20339f);

            pos = new Vector2(x, y);

            Instantiate(spawnOBJ, pos, Quaternion.identity);
       
       
    }

   
}
