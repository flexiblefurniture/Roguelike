using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject objectToSpawn;
    private int time;
    private int timeToSpawn = 200;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        time += 1;
        if(time == timeToSpawn)
        {
            for (int i = Random.Range(20, 60); 1 < i; i--)
            {
                Instantiate(objectToSpawn, transform.position, Quaternion.identity);
            }
            time = 0;
            transform.position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-2.0f, 2.0f));
            timeToSpawn -= 5;
        }
    }
}
