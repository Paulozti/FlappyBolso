using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 1;
    
    public GameObject GameOverPanel;
    public GameObject Points;
    
    public int pontos = 0;

    private void Awake()
    {
        Time.timeScale = 1;
        _rigidbody = GetComponent<Rigidbody2D>();
        pontos = 0;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && (transform.position.y < 1.2f))
        {
            _rigidbody.velocity = Vector2.up * speed;
        }
        

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
        Points.GetComponent<Text>().color = Color.white;
        Points.GetComponent<Text>().text = "Sua pontuação foi de \n" + pontos + " Talkeys";
        GameOverPanel.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Point")
        {
            pontos++;
            Points.GetComponent<Text>().text = pontos + " Talkeys";
        }
    }
}
