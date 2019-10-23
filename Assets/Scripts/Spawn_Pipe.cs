using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Pipe : MonoBehaviour
{
    public GameObject Pipe;
    public float SpawnTime = 1.6f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawnPipe");
    }

    // Update is called once per frame
    void Update()
    {

        
    }

   IEnumerator spawnPipe() 
    {
        while (true)
        {
            Vector3 position = new Vector3(0, Random.Range(-0.35f, 1.23f), 0);
            Instantiate(Pipe, transform.position + position, transform.rotation);
            yield return new WaitForSeconds(SpawnTime);
        }
    }
}
