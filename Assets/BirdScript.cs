using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BirdScript : MonoBehaviour
{
    public float height;

    Rigidbody2D rb;
    public float rotatePower;

    public int Points;
    public TextMeshPro pointsText;
    public AudioClip clip;

    public WallScript wall;
    public GameObject endGameScreen;

    public GameObject flash;
    public GameObject startBird;
    public GameObject startGetReady;
    public GameObject PillerSpawner;

    public AudioClip death;

    public bool jumped = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumped = false;
    }

    // Update is called once per frame
    void Update()
    {      
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //transform.position += Vector3.up * height;

            Jump();
        }

        float x = transform.position.x;

        if (x <= -6)
        {
            Destroy(gameObject);
        }

        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * rotatePower);
    }

    void Jump()
    {
        rb.velocity = Vector2.up * height;
        PillerSpawner.SetActive(true);
        jumped = true;
        
    }
       

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("PointCounter"))
        {
            Points++;
            pointsText.text = Points.ToString();
            AudioSource.PlayClipAtPoint(clip, transform.position, 1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Walls"))
        {
            Die();
            Invoke("ShowMenu", 0.5f);
        }
    }

    void Die()
    { 
        WallScript Wall = wall.GetComponent<WallScript>();
        Wall.speed = 0;
        height = 0;
        flash.SetActive(true);
        AudioSource.PlayClipAtPoint(death, transform.position, 1);

        int score = int.Parse(pointsText.text);
        PlayerPrefs.SetInt("Points", score);
    }

    void ShowMenu()
    {
        endGameScreen.SetActive(true);
        pointsText.gameObject.SetActive(false);
    }
}
