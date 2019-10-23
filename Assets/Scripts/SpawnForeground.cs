using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnForeground : MonoBehaviour
{
    public GameObject foreGround;
    public float spawnTime = 1.5f;
    void Start()
    {
        StartCoroutine(spawnForeGround());
    }

    IEnumerator spawnForeGround()
    {
        while (true)
        {
            Instantiate(foreGround, transform.position + new Vector3(0.5f, -1.002f, 0), transform.rotation);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
