using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    
    
    public float Speed = 1;
    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
        if(transform.position.x < -2f)
        {
            Destroy(this.gameObject);
        }
    }
}
